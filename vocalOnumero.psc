Algoritmo VocalONumero
	Definir dato Como Caracter
	
	Escribir "Ingrese un caracter: "
	Leer dato
	
	Si dato = "a" o dato = "e" o dato = "i" o dato = "o" o dato = "u" o dato = "A" o dato = "E" o dato = "I" o dato = "O" o dato = "U" Entonces
		Escribir "Es una vocal"
		
	SiNo
		Si dato >= "0" Y dato <= "9" Entonces
			Escribir "Es un numero"
		SiNo
			Escribir "No es vocal ni numero"
		FinSi
	FinSi
FinAlgoritmo
