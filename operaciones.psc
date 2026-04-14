Algoritmo Operaciones
	Definir n1, n2 Como Real
	Definir op Como Entero
	Escribir "Ingrese el primer numero"
	leer n1
	Escribir "Ingrese el segundo numero"
	leer n2
	Escribir "1. Suma"
	Escribir "2. Resta"
	Escribir "3. Multiplicacion"
	Escribir "4. Division"
	Escribir "Seleccione una opcion: "
	leer op
	Segun op Hacer
		1:
			Escribir "Suma seleccionada"
			Escribir "El resultado de la operacion es: ", n1+n2
		2:
			Escribir "Resta seleccionada"
			Escribir "El resultado de la operacion es: ", n1-n2
		3:
			Escribir "Multiplicacion seleccionada"
			Escribir "El resultado de la operacion es: ", n1*n2
		4:
			Escribir "Division seleccionada"
			Si n2 <> 0 Entonces
				Escribir "El resultado de la operacion es: ", n1/n2
			SiNo
				Escribir "Error: No se puede dividir entre 0"
			Fin Si

		De Otro Modo:
			Escribir "Opcion Invalida"
	Fin Segun
FinAlgoritmo
