import mysql.connector
from mysql.connector import errorcode
import random

# da fare dopo  nome varchar, cogmome varchar, username varchar, password varchar(255), email varchar, matricola varchar(255), sesso varchar(255), dataNascita varchar(255)
utenti = {
    "Mark":["marco","castanucci","Markpass","Mark@gmail.com","1000203","M","19/06/1995"],
    "Lucas":["luca","lamelli","Lucaspass","Lucas@gmail.com","1000204","M","22/03/1999"],
    "Vittorya":["Vittoria","Astaldi","Vittoryopass","Vittoryo@gmail.com","1000205","M","05/09/1999"]}
id = 1
professori = ["Ascia Giuseppe", "Carchiolo Vincenza", "Catania Vincenzo", "Cavalieri Salvatore",
              "Di Stefano Antonella", "Gambuzza Lucia Valentina", "Giordano Daniela", "Lo Bello Lucia",
              "Malgeri Michele Giuseppe", "Mangioni Giuseppe", "Morana Giovanni", "Palesi Maurizio",
              "Panno Daniela Giovanna Anna", "Riolo Salvatore", "Tomarchio Orazio"]

def clientSQL():
    try:
        mydb = mysql.connector.connect(
            host="localhost",
            user="utente",
            password="utente",
            database="HeyDieei",
            port=3306
        )
    except mysql.connector.Error as err:
        if err.errno == errorcode.ER_ACCESS_DENIED_ERROR:
            print("Something is wrong with your user name or password")
        elif err.errno == errorcode.ER_BAD_DB_ERROR:
            print("Database does not exist")
        else:
            print(err)
    else:  # se la connessione va a buon fine
        mycursor = mydb.cursor()
        for k,v in utenti.items():

            
            sql_ut = """INSERT INTO utenti (nome, cognome, username, password, email, matricola, sesso, dataNascita) VALUES (%s,%s,%s,%s,%s,%s,%s,%s);"""
            val_ut = (v[0],v[1],k,v[2],v[3],v[4],v[5],v[6])
            mycursor.execute(sql_ut,val_ut)
            mydb.commit()

            for id in range(1,160): 
                sql = """INSERT INTO VAL_ARGOMENTI (Username, argomentoID, valutazione) VALUES (%s,%s,%s);"""
                val = (k, id, random.randint(0,5)) 
                mycursor.execute(sql,val)
                mydb.commit()

            for prof in professori:
                for i in range(6):
                    sql = """INSERT INTO VAL_PROFESSORI (Username, Professore, valutazione) VALUES (%s,%s,%s);"""
                    val = (k, prof, random.randint(0,5))
                    mycursor.execute(sql,val)
                    mydb.commit()
                

        mydb.close()


clientSQL()







