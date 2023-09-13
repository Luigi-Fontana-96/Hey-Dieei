package services

import (
	"fmt"
	"log"
	"APL_BE/config"
	"APL_BE/models"
)


func ClassificaProfGenerale() []models.Statistiche_Professori{
	db := config.DatabaseConnection()
	type Tupla struct {
		valore   float64
		contatore    float64
	}
	var id int
	var user string
	var valutazioni []models.Statistiche_Professori
	var final_val []models.Statistiche_Professori
	defer db.Close()

	rows, err := db.Query("SELECT * FROM VAL_PROFESSORI")
	if err != nil {
            log.Fatal(err)
    	}
	defer rows.Close()
	
	var ex models.Statistiche_Professori
	for rows.Next(){
		if err:= rows.Scan(&id, &user, &ex.Professore, &ex.Media); err != nil{
			log.Fatal(err)
		}
		valutazioni = append(valutazioni, ex)
	}

	mappa_val := make(map[string]Tupla)
	for i := 0; i < len(valutazioni); i++ {

		_ , presente := mappa_val[valutazioni[i].Professore]
		if presente {
			mappa_val[valutazioni[i].Professore] = Tupla{valore: mappa_val[valutazioni[i].Professore].valore + valutazioni[i].Media, contatore: mappa_val[valutazioni[i].Professore].contatore + 1}
		} else {
			mappa_val[valutazioni[i].Professore] = Tupla{valore: valutazioni[i].Media, contatore: 1}
		}
		
	}
	var tmp models.Statistiche_Professori
	for k, v := range mappa_val {
		tmp.Professore = k
		tmp.Media = v.valore/v.contatore
		final_val = append(final_val, tmp)
    }

	return final_val

}



func ClassificaProfUtente(username string) []models.Statistiche_Professori{
	db := config.DatabaseConnection()
	type Tupla struct {
		valore   float64
		contatore    float64
	}
	var final_val []models.Statistiche_Professori
	var valutazioni []models.Statistiche_Professori
	var id int
	var user string

	defer db.Close()

	rows, err := db.Query("SELECT * FROM VAL_PROFESSORI WHERE Username = ?", username)
	if err != nil {
            log.Fatal(err)
    	}
	defer rows.Close()
	
	var ex models.Statistiche_Professori
	for rows.Next(){
		if err:= rows.Scan(&id, &user, &ex.Professore, &ex.Media); err != nil{
			log.Fatal(err)
		}
		valutazioni = append(valutazioni, ex)
	}
	

	mappa_val := make(map[string]Tupla)
	for i := 0; i < len(valutazioni); i++ {

		_ , presente := mappa_val[valutazioni[i].Professore]
		if presente {
			mappa_val[valutazioni[i].Professore] = Tupla{valore: mappa_val[valutazioni[i].Professore].valore + valutazioni[i].Media, contatore: mappa_val[valutazioni[i].Professore].contatore + 1}
		} else {
			mappa_val[valutazioni[i].Professore] = Tupla{valore: valutazioni[i].Media, contatore: 1}
		}
		
	}
	var tmp models.Statistiche_Professori
	for k, v := range mappa_val {
		tmp.Professore = k
		tmp.Media = v.valore/v.contatore
		final_val = append(final_val, tmp)
    }

	return final_val
}






func ClassificaArgGenerale() []models.Statistiche_Argomenti{
	db := config.DatabaseConnection()
	type Tupla struct {
		valore   float64
		contatore    float64
	}
	var valutazioni []models.Statistiche_Argomenti
	var final_val []models.Statistiche_Argomenti
	defer db.Close()

	rows_mat, err_mat := db.Query("select val_argomenti.valutazione , materie.nome from val_argomenti inner join argomenti on val_argomenti.argomentoId = argomenti.argomentoId join materie on argomenti.materiaID = materie.materiaID;")
	if err_mat != nil {
            log.Fatal(err_mat)
    	}
	defer rows_mat.Close()

	var mat_tmp models.Statistiche_Argomenti
	for rows_mat.Next(){
		if err:= rows_mat.Scan(&mat_tmp.Media, &mat_tmp.Materia,); err != nil{
			log.Fatal(err)
		}
		valutazioni = append(valutazioni, mat_tmp)			
	}

	mappa_val := make(map[string]Tupla)
	for i := 0; i < len(valutazioni); i++ {

		_ , presente := mappa_val[valutazioni[i].Materia]
		if presente {
			mappa_val[valutazioni[i].Materia] = Tupla{valore: mappa_val[valutazioni[i].Materia].valore + valutazioni[i].Media, contatore: mappa_val[valutazioni[i].Materia].contatore + 1}
		} else {
			mappa_val[valutazioni[i].Materia] = Tupla{valore: valutazioni[i].Media, contatore: 1}
		}
		
	}

	var tmp models.Statistiche_Argomenti
	for k, v := range mappa_val {
		tmp.Materia = k
		tmp.Media = v.valore/v.contatore
		final_val = append(final_val, tmp)
    }

	return final_val

}


func ClassificaArgUtente(username string) []models.Statistiche_Argomenti{
	db := config.DatabaseConnection()
	type Tupla struct {
		valore   float64
		contatore    float64
	}
	var valutazioni []models.Statistiche_Argomenti
	var final_val []models.Statistiche_Argomenti

	defer db.Close()

	rows_mat, err_mat := db.Query("select val_argomenti.valutazione , materie.nome from val_argomenti inner join argomenti on val_argomenti.argomentoId = argomenti.argomentoId join materie on argomenti.materiaID = materie.materiaID where val_argomenti.Username = ?;", username)
	if err_mat != nil {
            log.Fatal(err_mat)
    	}
	defer rows_mat.Close()
	
	var mat_tmp models.Statistiche_Argomenti
	for rows_mat.Next(){
		if err:= rows_mat.Scan(&mat_tmp.Media, &mat_tmp.Materia,); err != nil{
			log.Fatal(err)
		}
		valutazioni = append(valutazioni, mat_tmp)			
	}

	mappa_val := make(map[string]Tupla)
	for i := 0; i < len(valutazioni); i++ {

		_ , presente := mappa_val[valutazioni[i].Materia]
		if presente {
			mappa_val[valutazioni[i].Materia] = Tupla{valore: mappa_val[valutazioni[i].Materia].valore + valutazioni[i].Media, contatore: mappa_val[valutazioni[i].Materia].contatore + 1}
		} else {
			mappa_val[valutazioni[i].Materia] = Tupla{valore: valutazioni[i].Media, contatore: 1}
		}
		
	}

	var tmp models.Statistiche_Argomenti
	for k, v := range mappa_val {
		tmp.Materia = k
		tmp.Media = v.valore/v.contatore
		final_val = append(final_val, tmp)
    }

	fmt.Println("Done!")
	return final_val
	
}


