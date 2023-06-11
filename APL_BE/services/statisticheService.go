package services

import (
	"fmt"
	"log"
	"APL_BE/config"
	"APL_BE/models"
)

func ClassificaArgUtente(username string) []models.Statistiche_Argomenti{
	db := config.DatabaseConnection()
	var stats []models.Statistiche_Argomenti
	var valutazioni []models.ValArgomenti
	var s int = 0
	var c int
	var id int

	defer db.Close()

	rows, err := db.Query("SELECT * FROM VAL_ARGOMENTI WHERE Username = ?", username)
	if err != nil {
            log.Fatal(err)
    	}
	defer rows.Close()
	
	var val models.ValArgomenti
	for rows.Next(){
		if err:= rows.Scan(&id, &val.Username, &val.ArgomentoID, &val.Valutazione); err != nil{
			log.Fatal(err)
		}
		valutazioni = append(valutazioni, val)
	}

	var tmp models.Statistiche_Argomenti
	for i := 0; i < len(valutazioni); i++ {
		fmt.Println(valutazioni[i].ArgomentoID)
		switch {
			case valutazioni[i].ArgomentoID <= 13:
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 13 {
					tmp.Materia = "ADVANCED COMPUTER ARCHITECTURES"
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}
			
			case valutazioni[i].ArgomentoID >= 14 && valutazioni[i].ArgomentoID <= 21:
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 8 {
					tmp.Materia = "ARCHITETTURE E TECNOLOGIE DI TLC"
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}

			case valutazioni[i].ArgomentoID >= 22 && valutazioni[i].ArgomentoID <= 58:
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 37 {
					tmp.Materia = "INGEGNERIA DEL SOFTWARE"
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}

			case valutazioni[i].ArgomentoID >= 59 && valutazioni[i].ArgomentoID <= 77:
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 19 {
					tmp.Materia = "RETI PER L'AUTOMAZIONE INDUSTRIALE"
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}
			
			case valutazioni[i].ArgomentoID >= 78 && valutazioni[i].ArgomentoID <= 83:
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Materia = "SICUREZZA DEI SISTEMI INFORMATIVI"
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}
			
				
			case valutazioni[i].ArgomentoID >= 84 && valutazioni[i].ArgomentoID <= 86:
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 3 {
					tmp.Materia = "TECNOLOGIE DEI SISTEMI DI CONTROLLO"
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}
			
			case valutazioni[i].ArgomentoID >= 87 && valutazioni[i].ArgomentoID <= 96:
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 10 {
					tmp.Materia = "ADVANCED PROGRAMMING LANGUAGE"
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}
			
			case valutazioni[i].ArgomentoID >= 97 && valutazioni[i].ArgomentoID <= 108:
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 11 {
					tmp.Materia = "COGNITIVE COMPUTING AND ARTIFICIAL INTELLIGENCE"
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}

			case valutazioni[i].ArgomentoID >= 109 && valutazioni[i].ArgomentoID <= 138:
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 30 {
					tmp.Materia = "DISTRIBUTED SYSTEM AND BIG DATA"
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}

			case valutazioni[i].ArgomentoID >= 139 && valutazioni[i].ArgomentoID <= 153:
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 15 {
					tmp.Materia = "INDUSTRIAL INFORMATICS"
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}
			
			case valutazioni[i].ArgomentoID >= 154 && valutazioni[i].ArgomentoID <= 159:
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Materia = "IOT BASED SMART SYSTEMS"
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}
		}
	}

	
	return stats
	
}


func ClassificaProfUtente(username string) []models.Statistiche_Professori{
	db := config.DatabaseConnection()
	var stats []models.Statistiche_Professori
	var valutazioni []models.ValProfessori
	var s int = 0
	var c int
	var id int

	defer db.Close()

	rows, err := db.Query("SELECT * FROM VAL_PROFESSORI WHERE Username = ?", username)
	if err != nil {
            log.Fatal(err)
    	}
	defer rows.Close()
	
	var val models.ValProfessori
	for rows.Next(){
		if err:= rows.Scan(&id, &val.Username, &val.Professore, &val.Valutazione); err != nil{
			log.Fatal(err)
		}
		valutazioni = append(valutazioni, val)
	}

	var tmp models.Statistiche_Professori
	for i := 0; i < len(valutazioni); i++ {
		switch {
			case valutazioni[i].Professore == "Ascia Giuseppe":
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Professore = valutazioni[i].Professore
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}
			
			case valutazioni[i].Professore == "Carchiolo Vincenza":
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Professore = valutazioni[i].Professore
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}

			case valutazioni[i].Professore == "Catania Vincenzo":
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Professore = valutazioni[i].Professore
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}

			case valutazioni[i].Professore == "Cavalieri Salvatore":
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Professore = valutazioni[i].Professore
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}
			
			case valutazioni[i].Professore == "Di Stefano Antonella":
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Professore = valutazioni[i].Professore
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}
			
				
			case valutazioni[i].Professore == "Gambuzza Lucia Valentina":
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Professore = valutazioni[i].Professore
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}
			
			case valutazioni[i].Professore == "Giordano Daniela":
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Professore = valutazioni[i].Professore
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}
			
			case valutazioni[i].Professore == "Lo Bello Lucia":
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Professore = valutazioni[i].Professore
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}

			case valutazioni[i].Professore == "Malgeri Michele Giuseppe":
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Professore = valutazioni[i].Professore
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}

			case valutazioni[i].Professore == "Mangioni Giuseppe":
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Professore = valutazioni[i].Professore
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}
			
			case valutazioni[i].Professore == "Morana Giovanni":
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Professore = valutazioni[i].Professore
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}

			case valutazioni[i].Professore == "Palesi Maurizio":
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Professore = valutazioni[i].Professore
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}
			
			case valutazioni[i].Professore == "Panno Daniela Giovanna Anna":
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Professore = valutazioni[i].Professore
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}

			case valutazioni[i].Professore == "Riolo Salvatore":
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Professore = valutazioni[i].Professore
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}

			case valutazioni[i].Professore == "Tomarchio Orazio":
				s = s + int(valutazioni[i].Valutazione)
				c++
				if c == 6 {
					tmp.Professore = valutazioni[i].Professore
					tmp.Media = float64(s)/float64(c)
					stats = append(stats, tmp)
					s = 0
					c = 0
				}
		}
	}

	return stats
}

func ClassificaArgGenerale() []models.Statistiche_Argomenti{
	db := config.DatabaseConnection()
	var stats []models.Statistiche_Argomenti
	var valutazioni []models.ValArgomenti
	var id int
	var s [11]int
	var c [11]int
	var dup uint32
	var conf uint32 = 0
	var materie []string
	defer db.Close()

	rows_mat, err_mat := db.Query("SELECT * FROM MATERIE")
	if err_mat != nil {
            log.Fatal(err_mat)
    	}
	defer rows_mat.Close()

	var mat_tmp models.Materie
	for rows_mat.Next(){
		if err:= rows_mat.Scan(&mat_tmp.ID, &mat_tmp.MateriaID, &mat_tmp.NomeMateria, &mat_tmp.Url); err != nil{
			log.Fatal(err)
		}
		dup = mat_tmp.MateriaID
		if (dup != conf) {
			materie = append(materie, mat_tmp.NomeMateria)
			conf = mat_tmp.MateriaID
		}		
	}

	rows, err := db.Query("SELECT * FROM VAL_ARGOMENTI")
	if err != nil {
            log.Fatal(err)
    	}
	defer rows.Close()
	
	var val models.ValArgomenti
	for rows.Next(){
		if err:= rows.Scan(&id, &val.Username, &val.ArgomentoID, &val.Valutazione); err != nil{
			log.Fatal(err)
		}
		valutazioni = append(valutazioni, val)
	}

	
	for i := 0; i < len(valutazioni); i++ {
		fmt.Println(valutazioni[i].ArgomentoID)
		switch {
			case valutazioni[i].ArgomentoID <= 13:
				s[0] = s[0] + int(valutazioni[i].Valutazione)
				c[0]++
			
			case valutazioni[i].ArgomentoID >= 14 && valutazioni[i].ArgomentoID <= 21:
				s[1] = s[1] + int(valutazioni[i].Valutazione)
				c[1]++

			case valutazioni[i].ArgomentoID >= 22 && valutazioni[i].ArgomentoID <= 58:
				s[2] = s[2] + int(valutazioni[i].Valutazione)
				c[2]++
			
			case valutazioni[i].ArgomentoID >= 59 && valutazioni[i].ArgomentoID <= 77:
				s[3] = s[3] + int(valutazioni[i].Valutazione)
				c[3]++
				
			
			case valutazioni[i].ArgomentoID >= 78 && valutazioni[i].ArgomentoID <= 83:
				s[4] = s[4] + int(valutazioni[i].Valutazione)
				c[4]++
			
				
			case valutazioni[i].ArgomentoID >= 84 && valutazioni[i].ArgomentoID <= 86:
				s[5] = s[5] + int(valutazioni[i].Valutazione)
				c[5]++

			
			case valutazioni[i].ArgomentoID >= 87 && valutazioni[i].ArgomentoID <= 96:
				s[6] = s[6] + int(valutazioni[i].Valutazione)
				c[6]++
			
			
			case valutazioni[i].ArgomentoID >= 97 && valutazioni[i].ArgomentoID <= 108:
				s[7] = s[7] + int(valutazioni[i].Valutazione)
				c[7]++


			case valutazioni[i].ArgomentoID >= 109 && valutazioni[i].ArgomentoID <= 138:
				s[8] = s[8] + int(valutazioni[i].Valutazione)
				c[8]++


			case valutazioni[i].ArgomentoID >= 139 && valutazioni[i].ArgomentoID <= 153:
				s[9] = s[9] + int(valutazioni[i].Valutazione)
				c[9]++
			
			case valutazioni[i].ArgomentoID >= 154 && valutazioni[i].ArgomentoID <= 159:
				s[10] = s[10] + int(valutazioni[i].Valutazione)
				c[10]++
		}
	}

	var tmp models.Statistiche_Argomenti

	for i:= 0; i < 11; i++ {
		if s[i] > 0 {
			tmp.Materia = materie[i]
			tmp.Media = float64(s[i])/float64(c[i])
			fmt.Println(tmp.Media)
			stats = append(stats, tmp)
		}
		
	}

	return stats	
}


func ClassificaProfGenerale() []models.Statistiche_Professori{
	db := config.DatabaseConnection()
	var stats []models.Statistiche_Professori
	var valutazioni []models.ValProfessori
	var id int
	var s [15]int
	var c [15]int
	var professori []string
	defer db.Close()

	rows_prof, err_prof := db.Query("SELECT * FROM PROFESSORI")
	if err_prof != nil {
            log.Fatal(err_prof)
    	}
	defer rows_prof.Close()

	var prof_tmp models.Professori
	for rows_prof.Next(){
		if err:= rows_prof.Scan(&prof_tmp.ID, &prof_tmp.Professore, &prof_tmp.MateriaID, &prof_tmp.NomeMateria); err != nil{
			log.Fatal(err)
		}
		
		professori = append(professori, prof_tmp.Professore)
	}

	rows, err := db.Query("SELECT * FROM VAL_PROFESSORI")
	if err != nil {
            log.Fatal(err)
    	}
	defer rows.Close()
	
	var val models.ValProfessori
	for rows.Next(){
		if err:= rows.Scan(&id, &val.Username, &val.Professore, &val.Valutazione); err != nil{
			log.Fatal(err)
		}
		valutazioni = append(valutazioni, val)
	}

	
	for i := 0; i < len(valutazioni); i++ {
		switch {
			case valutazioni[i].Professore == "Ascia Giuseppe":
				s[0] = s[0] + int(valutazioni[i].Valutazione)
				c[0]++
			
			case valutazioni[i].Professore == "Carchiolo Vincenza":
				s[1] = s[1] + int(valutazioni[i].Valutazione)
				c[1]++

			case valutazioni[i].Professore == "Catania Vincenzo":
				s[2] = s[2] + int(valutazioni[i].Valutazione)
				c[2]++
			
			case valutazioni[i].Professore == "Cavalieri Salvatore":
				s[3] = s[3] + int(valutazioni[i].Valutazione)
				c[3]++
				
			
			case valutazioni[i].Professore == "Di Stefano Antonella":
				s[4] = s[4] + int(valutazioni[i].Valutazione)
				c[4]++
			
				
			case valutazioni[i].Professore == "Gambuzza Lucia Valentina":
				s[5] = s[5] + int(valutazioni[i].Valutazione)
				c[5]++

			
			case valutazioni[i].Professore == "Giordano Daniela":
				s[6] = s[6] + int(valutazioni[i].Valutazione)
				c[6]++
			
			
			case valutazioni[i].Professore == "Lo Bello Lucia":
				s[7] = s[7] + int(valutazioni[i].Valutazione)
				c[7]++


			case valutazioni[i].Professore == "Malgeri Michele Giuseppe":
				s[8] = s[8] + int(valutazioni[i].Valutazione)
				c[8]++


			case valutazioni[i].Professore == "Mangioni Giuseppe":
				s[9] = s[9] + int(valutazioni[i].Valutazione)
				c[9]++
			
			case valutazioni[i].Professore == "Morana Giovanni":
				s[10] = s[10] + int(valutazioni[i].Valutazione)
				c[10]++
			
			case valutazioni[i].Professore == "Palesi Maurizio":
				s[11] = s[11] + int(valutazioni[i].Valutazione)
				c[11]++
			
			case valutazioni[i].Professore == "Panno Daniela Giovanna Anna":
				s[12] = s[12] + int(valutazioni[i].Valutazione)
				c[12]++

			case valutazioni[i].Professore == "Riolo Salvatore":
				s[13] = s[13] + int(valutazioni[i].Valutazione)
				c[13]++

			case valutazioni[i].Professore == "Tomarchio Orazio":
				s[14] = s[14] + int(valutazioni[i].Valutazione)
				c[14]++

		}
	}

	var tmp models.Statistiche_Professori

	for i:= 0; i < 15; i++ {
		if s[i] > 0 {
			tmp.Professore = professori[i]
			tmp.Media = float64(s[i])/float64(c[i])
			fmt.Println(tmp.Media)
			stats = append(stats, tmp)
		}
		
	}

	return stats	
	
}