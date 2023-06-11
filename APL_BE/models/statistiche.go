package models

type Statistiche_Argomenti struct {
	Materia string `json:"Materia"` 
	Media float64 `json:"Media"`
}

type Statistiche_Professori struct {
	Professore string `json:"Professore"`
	Media float64 `json:"Media"`
}
