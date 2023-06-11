package models

//File per modellare la struttura dell'utente
type User struct {
	Nome     string `json:"Nome"`
	Cognome  string `json:"Cognome"`
	Username string `json:"Username"`
	Password string `json:"Password"`
	Email    string `json:"Email"`
	Matricola    string `json:"Matricola"`
	Sesso    string `json:"Sesso"`
	DataNascita    string `json:"DataNascita"`
}