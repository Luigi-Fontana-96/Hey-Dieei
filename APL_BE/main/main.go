package main

import (
	"fmt"
	"log"
	"net/http"
	"sort"

	"APL_BE/models"
	"APL_BE/services"

	"github.com/gin-gonic/gin"
)

/*API User*/
func createUser(c *gin.Context) {
	fmt.Println("PUT ARRIVATO")

	var user models.User
	var response int

	if err := c.ShouldBindJSON(&user); err != nil {
		log.Print(err)
		c.JSON(http.StatusBadRequest, gin.H{"msg": err})
		return
	}

	//In questo modo abbiamo già il JSON che è assegnato ad user.
	response = services.CreateUser(&user)

	if response == 500 {
		c.JSON(http.StatusInternalServerError, gin.H{"msg": "Internal Server Error"})
	} else if response == 200 {
		fmt.Println("Tutto OK")
		c.JSON(http.StatusOK, "Utente Aggiunto nel DB")
	} else if response == 400 {
		c.JSON(http.StatusBadRequest, gin.H{"msg": "Utente già presente nel DB"})
	}

}

func PostUserPass(c *gin.Context) {
	fmt.Println("GET ARRIVATO")

	var user models.User
	var response int

	if err := c.ShouldBindJSON(&user); err != nil {
		log.Print(err)
		c.JSON(http.StatusBadRequest, gin.H{"msg": err})
		return
	}

	response = services.PostUserPass(&user)

	if response == 400 {
		c.JSON(http.StatusBadRequest, gin.H{"msg": "Non presente nel DB o valori inseriti errati"})
	} else if response == 200 {
		fmt.Println("Tutto OK")
		c.JSON(http.StatusOK, "Utente Trovato")
	}
}

func getUserbyUsername(c *gin.Context) {
	fmt.Println("GET ARRIVATO")
	username := c.Param("username")
	fmt.Println(username)
	user := models.User{}

	if len(username) == 0 {
		c.JSON(http.StatusBadRequest, gin.H{"msg": "username not populated"})
		return
	}
	user = services.GetUserbyUsername(username)

	if (models.User{}) == user {
		c.JSON(http.StatusNotFound, gin.H{"msg": "User not found"})
		return
	}

	c.JSON(http.StatusOK, user)
}

/*API MATERIE*/
func getMaterie(c *gin.Context) {
	mat := services.FindMaterie()

	c.JSON(http.StatusOK, mat)
}

func getArgomenti(c *gin.Context) {
	var materiaId string = c.Param("materiaID")
	if len(materiaId) == 0 {
		c.JSON(http.StatusBadRequest, gin.H{"msg": "materiaID not populated"})
		return
	}
	arg := services.FindArgomenti(materiaId)
	c.JSON(http.StatusOK, arg)
}

func postValArgomenti(c *gin.Context) {
	var valt []models.ValArgomenti
	var response int

	if err := c.ShouldBindJSON(&valt); err != nil {
		log.Print(err)
		c.JSON(http.StatusBadRequest, gin.H{"msg": err})
		return
	}
	fmt.Println(valt)

	response = services.Valutation_Argomenti(valt)

	if response == 500 {
		c.JSON(http.StatusBadRequest, gin.H{"msg": "Problemi in inserimento valutazioni argomenti"})
	} else if response == 200 {
		fmt.Println("Tutto OK")
		c.JSON(http.StatusOK, "Valutazioni Inserite correttamente")
		valt = []models.ValArgomenti{}
	} else if response == 400 {
		c.JSON(http.StatusBadRequest, gin.H{"msg": "Valutazione già presente"})
	}
}

/*API PROF*/
func getProfessori(c *gin.Context) {
	prof := services.FindProfessori()
	c.JSON(http.StatusOK, prof)
}

func postValProfessori(c *gin.Context) {
	var valt []models.ValProfessori
	var response int

	if err := c.ShouldBindJSON(&valt); err != nil {
		log.Print(err)
		c.JSON(http.StatusBadRequest, gin.H{"msg": err})
		return
	}
	response = services.Valutation_Professori(valt)

	if response == 500 {
		c.JSON(http.StatusBadRequest, gin.H{"msg": "Problemi in inserimento valutazioni Professori"})
	} else if response == 200 {
		fmt.Println("Tutto OK")
		c.JSON(http.StatusOK, "Valutazioni Inserite correttamente")
		valt = []models.ValProfessori{}
	} else if response == 400 {
		c.JSON(http.StatusBadRequest, gin.H{"msg": "Valutazione già presente"})
	}
}

/*CHE PROF*/
func postCheProf(c *gin.Context) {
	var risposte []int
	var somma int = 0

	if err := c.ShouldBindJSON(&risposte); err != nil {
		log.Print(err)
		c.JSON(http.StatusBadRequest, gin.H{"msg": err})
		return
	}

	for i := 0; i < len(risposte); i++ {
		somma = somma + risposte[i]
	}

	if somma <= 5 {
		c.JSON(http.StatusOK, "Giuseppe Ascia")
	} else if somma > 5 && somma <= 10 {
		c.JSON(http.StatusOK, "Lucia Lo Bello")
	} else if somma > 10 && somma <= 13 {
		c.JSON(http.StatusOK, "Antonella Di Stefano")
	} else if somma > 13 && somma <= 16 {
		c.JSON(http.StatusOK, "Michele Giuseppe Malgeri")
	} else if somma > 16 && somma <= 20 {
		c.JSON(http.StatusOK, "Daniela Giovanna Anna Panno")
	} else if somma > 20 && somma <= 23 {
		c.JSON(http.StatusOK, "Vincenzo Catania")
	} else if somma > 23 && somma <= 27 {
		c.JSON(http.StatusOK, "Orazio Tomarchio")
	} else if somma > 27 && somma <= 30 {
		c.JSON(http.StatusOK, "Giuseppe Mangioni")
	} else if somma > 30 {
		c.JSON(http.StatusOK, "Vincenza Carchiolo")
	}

}

// API Statistiche
func getUserStatArgomenti(c *gin.Context) {
	username := c.Param("user")
	if len(username) == 0 {
		c.JSON(http.StatusBadRequest, gin.H{"msg": "username not populated"})
		return
	}

	var stat []models.Statistiche_Argomenti
	stat = services.ClassificaArgUtente(username)
	sort.Slice(stat, func(i, j int) bool {
		return stat[i].Media > stat[j].Media
	})
	c.JSON(http.StatusOK, stat)
}

func getUserStatProfessori(c *gin.Context) {
	username := c.Param("user")
	if len(username) == 0 {
		c.JSON(http.StatusBadRequest, gin.H{"msg": "username not populated"})
		return
	}

	var stat []models.Statistiche_Professori
	stat = services.ClassificaProfUtente(username)
	sort.Slice(stat, func(i, j int) bool {
		return stat[i].Media > stat[j].Media
	})
	fmt.Println(stat)
	c.JSON(http.StatusOK, stat)
}

func getStatArgomenti(c *gin.Context) {
	var stat []models.Statistiche_Argomenti
	stat = services.ClassificaArgGenerale()
	sort.Slice(stat, func(i, j int) bool {
		return stat[i].Media > stat[j].Media
	})
	c.JSON(http.StatusOK, stat)
}

func getStatProfessori(c *gin.Context) {
	var stat []models.Statistiche_Professori
	stat = services.ClassificaProfGenerale()
	sort.Slice(stat, func(i, j int) bool {
		return stat[i].Media > stat[j].Media
	})
	c.JSON(http.StatusOK, stat)
}

func main() {
	r := gin.Default()

	//API User
	r.PUT("/user/signup", createUser)
	r.POST("/user/login", PostUserPass)
	r.GET("user/:username", getUserbyUsername)

	//API Materie
	r.GET("/Materie", getMaterie)
	r.GET("/Argomenti/:materiaID", getArgomenti)
	r.POST("/Val_Argomenti", postValArgomenti)

	//API Professori
	r.GET("/Professori", getProfessori)
	r.POST("/Val_Professori", postValProfessori)

	//API Statistiche
	r.GET("Statistiche/argomenti/:user", getUserStatArgomenti)
	r.GET("Statistiche/professori/:user", getUserStatProfessori)
	r.GET("Statistiche/argomenti", getStatArgomenti)
	r.GET("Statistiche/professori", getStatProfessori)

	//API Che Prof Sei
	r.POST("/Cheprof", postCheProf)

	//RUN SERVER
	r.Run("localhost:8080") // listen and serve on 0.0.0.0:8080
}