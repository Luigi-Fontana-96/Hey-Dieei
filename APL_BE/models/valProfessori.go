package models

type ValProfessori struct {
	Username    string `json:"Username"`
	Professore  string `json:"Professore"`
	Valutazione uint16  `json:"Valutazione"`
}
