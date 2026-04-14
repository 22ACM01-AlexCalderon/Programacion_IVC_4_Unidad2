Algoritmo CalculadoraTrigonometrica
	Definir op Como Entero
	Definir angulo, resultado Como Real
	
	Escribir "CALCULADORA  DE FUNCIONES TRIGONOMETRICAS BASICAS"
	Escribir "*************************************************"
	Escribir "1. Seno"
	Escribir "2. Coseno"
	Escribir "3. Tangente"
	Escribir "*************************************************"
	Leer op
	
	Escribir "Ingrese el angulo en grados: "
	Leer angulo
	
	// Convertir grados a radianes
	angulo = angulo * PI / 180
	
	Segun opcion Hacer
		1:
			resultado = Sen(angulo)
			Escribir "El seno es: ", resultado
		2:
			resultado = Cos(angulo)
			Escribir "El coseno es: ", resultado
		3:
			resultado = Tan(angulo)
			Escribir "La tangente es: ", resultado
		De Otro Modo:
			Escribir "Opcion no valida"
	FinSegun
FinAlgoritmo