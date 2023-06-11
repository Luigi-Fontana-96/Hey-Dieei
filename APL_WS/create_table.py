import mysql.connector
from mysql.connector import errorcode


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
        mycursor = mydb.cursor()  # crea il cursore per interagire con il BD
        mycursor.execute("CREATE TABLE MATERIE (ID int AUTO_INCREMENT, materiaID int, nome varchar(255), url varchar(255), PRIMARY KEY(ID));")
        mycursor.execute("CREATE TABLE ARGOMENTI (argomentoID int AUTO_INCREMENT, nome varchar(255), materiaID varchar(255), PRIMARY KEY(argomentoID));")
        mycursor.execute("CREATE TABLE VAL_ARGOMENTI (ID int AUTO_INCREMENT, Username varchar(255), argomentoID varchar(255), valutazione int ,PRIMARY KEY(ID));")
        mycursor.execute("CREATE TABLE PROFESSORI (ID int AUTO_INCREMENT, Professore varchar(255), materiaID int, nomeMateria varchar(255) ,PRIMARY KEY(ID));")
        mycursor.execute("CREATE TABLE VAL_PROFESSORI (ID int AUTO_INCREMENT, Username varchar(255), Professore varchar(255), valutazione int ,PRIMARY KEY(ID));")
        mycursor.execute("CREATE TABLE utenti(idUtenti int AUTO_INCREMENT, nome varchar(255), cognome varchar(255), username varchar(255), password varchar(255), email varchar(255), matricola varchar(255), sesso varchar(255), dataNascita varchar(255), PRIMARY KEY(idUtenti));")
        
        #sql = "SELECT * FROM prediction_min WHERE metric = '{0}';".format(metric_name)
        #mycursor.execute(sql)

        mydb.close()


clientSQL()