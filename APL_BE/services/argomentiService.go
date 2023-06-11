package services

import (
	"fmt"
	"log"
	"APL_BE/config"
	"APL_BE/models"
)

func FindArgomenti(materiaID string)[]models.Argomenti{
	db := config.DatabaseConnection()
	var all_argomenti []models.Argomenti

	rows, err := db.Query("SELECT * FROM ARGOMENTI WHERE materiaID = ?", materiaID)
	 if err != nil {
            log.Fatal(err)
        }
	defer rows.Close()

	var arg models.Argomenti
	for rows.Next(){
		if err:= rows.Scan(&arg.ArgomentoID, &arg.Nome, &arg.MateriaID); err != nil{
			log.Fatal(err)
		}
		all_argomenti = append(all_argomenti, arg)
	}

	if err := rows.Err(); err != nil {
        log.Fatal(err)
	}
	return all_argomenti
}

func Valutation_Argomenti(valutation []models.ValArgomenti) (response int) {
	db := config.DatabaseConnection()
	var verify models.ValArgomenti
	var id int
	response = 200

	defer db.Close()

	r_m, e_m := db.Query("SELECT * FROM VAL_ARGOMENTI WHERE Username = ? AND argomentoID = ?;", valutation[len(valutation)-1].Username, valutation[len(valutation)-1].ArgomentoID)
	for r_m.Next() {
		r_m.Scan(&id, &verify.Username, &verify.ArgomentoID, &verify.Valutazione); 
		if (valutation[len(valutation)-1].ArgomentoID == verify.ArgomentoID) {
			fmt.Println("Trovato nel DB")
			response = 400;
			return response;
		}
		if (e_m != nil) {
			response = 400
			r_m.Close()
			return response
		}
	}

	for i:= 0; i < len(valutation); i++ {
		_, err := db.Query("INSERT INTO VAL_ARGOMENTI (Username, argomentoID, valutazione) VALUES (?, ?, ?);", valutation[i].Username, valutation[i].ArgomentoID, valutation[i].Valutazione) 
		if (err != nil) {
			fmt.Printf("Could not insert Valutation: %v", err) 
			response = 500
			return response
		}
	}
	return response
}


