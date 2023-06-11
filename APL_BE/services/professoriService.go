package services

import (
	"APL_BE/config"
	"APL_BE/models"
	"fmt"
	"log"
)

func FindProfessori() []models.Professori {
	db := config.DatabaseConnection()
	var all_professori []models.Professori

	rows, err := db.Query("SELECT * FROM PROFESSORI")
	if err != nil {
		log.Fatal(err)
	}
	defer rows.Close()

	var prof models.Professori
	for rows.Next() {
		//var alb Album
		if err := rows.Scan(&prof.ID, &prof.Professore, &prof.MateriaID, &prof.NomeMateria); err != nil {
			log.Fatal(err)
		}
		all_professori = append(all_professori, prof)
	}

	if err := rows.Err(); err != nil {
		log.Fatal(err)
	}
	return all_professori
}

func Valutation_Professori(valutation []models.ValProfessori) (response int) {
	db := config.DatabaseConnection()
	var verify models.ValProfessori
	var id int
	response = 200
	
	defer db.Close()

	r_m, e_m := db.Query("SELECT * FROM VAL_PROFESSORI WHERE Username = ? AND Professore = ?;", valutation[len(valutation)-1].Username, valutation[len(valutation)-1].Professore)
	for r_m.Next() {
		r_m.Scan(&id, &verify.Username, &verify.Professore, &verify.Valutazione); 
		if (valutation[len(valutation)-1].Professore == verify.Professore) {
			response = 400;
			return response;
		}
		if (e_m != nil) {
			response = 400
			r_m.Close()
			return response
		}
	}

	for i := 0; i < len(valutation); i++ {
		_, err := db.Query("INSERT INTO VAL_PROFESSORI (Username, Professore, valutazione) VALUES (?, ?, ?);", valutation[i].Username, valutation[i].Professore, valutation[i].Valutazione)
		if err != nil {
			fmt.Printf("Could not create Valutation: %v", err)
			response = 500
			return response
		}
	}

	return response

}