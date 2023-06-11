from bs4 import BeautifulSoup
import requests
import re
import mysql.connector
from mysql.connector import errorcode

site_url = "https://www.dieei.unict.it"
prof_info = []
programs_info = {}

try:
    mydb = mysql.connector.connect(
        host="localhost",
        user="utente",
        password="utente",
        database="HeyDieei",
        port=3306
    )
    mycursor = mydb.cursor()
except mysql.connector.Error as err:
    if err.errno == errorcode.ER_ACCESS_DENIED_ERROR:
        print("Something is wrong with your user name or password")
    elif err.errno == errorcode.ER_BAD_DB_ERROR:
        print("Database does not exist")
    else:
        print(err)


def prof_scraping():
    url = site_url+"/corsi/lm-32/docenti"
    response = requests.get(url)
    map = []
    reduce = []
    soup = BeautifulSoup(response.content, "html.parser")
    teachings_prof = soup.find_all("td")
    i = 0
    for prof in teachings_prof:
        map.append(prof.text)
        if i != 0 and i % 2 != 0:
            reduce.append(map)
            map = [] #nota che con il clear non funziona e quindi vatti a guardare perchè
        i = i + 1
    for item in reduce:
        item[1] = tuple(item[1].split('-'))
    return reduce

def prof_Sql_Load():
    global prof_info
    prof_info = prof_scraping()
    for item in prof_info:
        sql = """INSERT INTO PROFESSORI (Professore, materiaID, nomeMateria) VALUES (%s,%s,%s);"""
        val = (item[0], item[1][0], item[1][1])
        mycursor.execute(sql, val)
        mydb.commit()

def programs_scraping():
    url = site_url + "/corsi/lm-32/programmi"
    response = requests.get(url)
    soup = BeautifulSoup(response.content, "html.parser")
    reduce = {}
    programs_href = soup.find_all("a", attrs={'href': re.compile("^/corsi/lm-32/i")})  # script per prendere i link alle
    for href in programs_href:
        url = site_url + href.get("href")
        reduce[url] = href.text.split(" - ")

    first_key = next(iter(reduce))
    reduce.pop(first_key)
    return reduce

def programs_Sql_Load():
    global programs_info
    programs_info = programs_scraping()
    for k,v in programs_info.items():
        #print(f"{k} -> url:{v[0]} materia: {v[1]}")
        sql = """INSERT INTO MATERIE (materiaID, nome, url) VALUES (%s,%s,%s);"""
        val = (v[0], v[1], k)
        mycursor.execute(sql, val)
        mydb.commit()
        

def arguments_scraping(url):
    map = []
    reduce = []
    response = requests.get(url)
    soup = BeautifulSoup(response.content, "html.parser")
    arguments = soup.find_all("td")
    for arg in arguments:
        map.append(arg.text)
    map = map[4:]
    for item in map:
        if map.index(item) % 3 == 0:
            reduce.append(item)
    return reduce

def arguments_Sql_Load():
    for k,v in programs_info.items():
        print(k)
        arg = arguments_scraping(k)
        for item in arg:
            sql = """INSERT INTO ARGOMENTI (nome, materiaID) VALUES (%s,%s);"""
            val = (item,v[0])
            mycursor.execute(sql, val)
            mydb.commit()

def start_scraping():
    prof_Sql_Load()
    programs_Sql_Load()
    arguments_Sql_Load()


if __name__ == "__main__":
    start_scraping()