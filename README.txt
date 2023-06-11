Benvenuti su HeyDieei! 

Qui sono elencati i passaggi per poter avere un corretto funzionamento del Programma.

I linguaggi usati sono C# per il Front-End, Go per il Back-end e Python per effettuare lo scraping dal sito del dipartimento nella sezione della laurea magistrale LM-32.

Dunque, l'esecuzione è divisa in due fasi:
- Fase 1 -> Scraping: 
  Come requisito principale è necessario avere attivo un db su mysql oppure creare un container su docker. Nella cartella APL_WS è presente il file docker-compose.yml 
  il quale permette di creare un container mysql con dentro il database.
  Successivamente, installare tutte le dipendenze degli script con il comando "pip3 install -r requirements.txt".
  Una volta fatto questo, avviare nell'ordine i tre script presenti dentro la cartella APL_WS:
    1. create_table.py: script per creare le tabelle nel DB HeyDIeei;
    2. scraper.py: script per fare lo scraping del sito del dipartimento;
    3. fill_tables.py (opzionale): script per riempire le tabelle del database.
- Fase 2 -> Esecuzione Server e Client:
  Server
  Il server è scritto in Go. Per poterlo eseguire senza problemi, eseguire prima il comando "go mod tidy" per installare le dipendenze necessarie al funzionamento. 
  A questo punto è possibile avviare il server semplicemente avviando il main nella cartella main con il comando "go run main.go".
  Client
  Il client può essere avviato o tramite Visual Studio, oppure andando dentro la cartella \APL_FE\bin\Debug\net6.0-windows in cui è presente l'eseguibile. 

A questo punto è possibile fare tutte le operazioni che sono previste dal programma.

BUON DIVERTIMENTO!
  
