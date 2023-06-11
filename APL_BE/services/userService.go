package services

import (
	"fmt"
	"APL_BE/config"
	"APL_BE/models"
)

func CreateUser(user *models.User) (response int) {
	var e models.User
	var u models.User
	db := config.DatabaseConnection()
	var id int

	response = 200

	defer db.Close()

	r_m, e_m := db.Query("SELECT * FROM utenti WHERE email = ?;", user.Email)
	r_m.Next()
	r_m.Scan(&id, &e.Nome, &e.Cognome, &e.Username, &e.Password, &e.Email, &e.Matricola, &e.Sesso, &e.DataNascita)
	if (user.Email == e.Email) {
		response = 400;
		return response;
	}
	if (e_m != nil) {
		response = 400
		r_m.Close()
		return response
	}

	r_u, e_u := db.Query("SELECT * FROM utenti WHERE username = ?;", user.Username)
	r_u.Next()
	r_u.Scan(&id, &e.Nome, &u.Cognome, &u.Username, &u.Password, &u.Email, &u.Matricola, &u.Sesso, &u.DataNascita)
	if (user.Username == u.Username) {
		response = 400;
		return response;
	}
	if (e_u != nil) {
		response = 400
		r_u.Close()
		return response
	}

	_, err := db.Query("INSERT INTO utenti (nome, cognome, username, password, email, matricola, sesso, dataNascita) VALUES (?, ?, ?, ?, ?, ?, ?, ?);", user.Nome, user.Cognome, user.Username, user.Password, user.Email, user.Matricola, user.Sesso, user.DataNascita)
	if(err != nil) {
		fmt.Printf("Could not create User: %v", err)
		response = 500
		return response
	}
	return response
}

func PostUserPass(user *models.User) (response int) {
	db := config.DatabaseConnection()
	response = 200

	defer db.Close()

	rows, err := db.Query("SELECT * FROM utenti WHERE username = ? AND password = ?;", user.Username, user.Password)
	if (err != nil) {
		response = 400
		rows.Close()
		return response
	}

	return response
}

func GetUserbyUsername(username string) models.User{
	db := config.DatabaseConnection()
	var user models.User
	var id int

	defer db.Close()
	fmt.Println(username)
	rows, err := db.Query("SELECT * FROM utenti WHERE username = ?;", username)
	if (err != nil) {
		return models.User{}
	}

	defer rows.Close()

	rows.Next()
	err_row := rows.Scan(&id, &user.Nome, &user.Cognome, &user.Username, &user.Password, &user.Email, &user.Matricola, &user.Sesso, &user.DataNascita)
	fmt.Println(user.Nome)
	if (err_row != nil) {
		fmt.Println(err_row)
		return models.User{}
	}
	return user
}