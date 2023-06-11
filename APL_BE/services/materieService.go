package services

import (
	"log"
	"APL_BE/config"
	"APL_BE/models"
)

func FindMaterie() []models.Materie{
	db := config.DatabaseConnection()
	var dup uint32
	var conf uint32 = 0
	var all_materie []models.Materie

	rows, err := db.Query("SELECT * FROM MATERIE")
	 if err != nil {
            log.Fatal(err)
        }
	defer rows.Close()

	var mat models.Materie
	for rows.Next(){
		if err:= rows.Scan(&mat.ID, &mat.MateriaID, &mat.NomeMateria, &mat.Url); err != nil{
			log.Fatal(err)
		}
		dup = mat.MateriaID
		if (dup != conf) {
			all_materie = append(all_materie, mat)
			conf = mat.MateriaID
		}			
	}

	if err := rows.Err(); err != nil {
        log.Fatal(err)
	}

	return all_materie
}