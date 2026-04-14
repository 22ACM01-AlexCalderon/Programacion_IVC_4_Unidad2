Algoritmo Estadio
	Definir sector, e Como Entero
	Definir precio Como Real
	Escribir "1. Palco (Q300.00)"
	Escribir "2. Tribuna (Q100.00 - Q125.00)"
	Escribir "3. Preferencia (Q50.00 - Q75.00)"
	Escribir "4. Generales (Q30.00 - Q50.00)"
	Escribir "Seleccione el sector (1-4): "
	leer sector
	Escribir "Ingrese cantidad de entradas: "
	leer e 
	Segun sector Hacer
		1:
			precio <- 300
			Escribir "Sector: Palco"
			Escribir "Precio: Q", precio * e
			
		2:
			Escribir "Ingrese el precio dentro del rango (100 - 125): "
			Leer precio
			Si precio >= 100 Y precio <= 125 Entonces
				Escribir "Sector: Tribuna"
				Escribir "Precio: Q", precio * e 
			SiNo
				Escribir "Precio fuera de rango"
			FinSi
			
		3:
			Escribir "Ingrese el precio dentro del rango (50 - 75): "
			Leer precio
			Si precio >= 50 Y precio <= 75 Entonces
				Escribir "Sector: Preferencia"
				Escribir "Precio: Q", precio * e
			SiNo
				Escribir "Precio fuera de rango"
			FinSi
			
		4:
			Escribir "Ingrese el precio dentro del rango (30 - 50): "
			Leer precio
			Si precio >= 30 Y precio <= 50 Entonces
				Escribir "Sector: Generales"
				Escribir "Precio: Q", precio * e
			SiNo
				Escribir "Precio fuera de rango"
			FinSi
			
		De Otro Modo:
			Escribir "Opcion no valida"
	FinSegun
FinAlgoritmo
