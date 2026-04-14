Algoritmo impresoras
	Definir cantidad, opcion Como Entero
	Definir precioUnitario, iva, precioConIVA Como Real
	Definir totalSinDescuento, descuento, totalPagar Como Real
	Definir formaPago Como Caracter
	
	precioUnitario <- 650
	iva <- 0.12
	
	Escribir "=== VENTA DE IMPRESORAS ==="
	Escribir "Ingrese la cantidad de impresoras: "
	Leer cantidad
	
	Escribir "Forma de pago:"
	Escribir "1. Efectivo (10%)"
	Escribir "2. Tarjeta de credito (5%)"
	Escribir "3. Vale de regalo (15%)"
	Leer opcion
	
	precioConIVA = precioUnitario + (precioUnitario * iva)
	
	
	totalSinDescuento = cantidad * precioConIVA
	
	
	Segun opcion Hacer
		1:
			descuento = totalSinDescuento * 0.10
			formaPago = "Efectivo"
		2:
			descuento = totalSinDescuento * 0.05
			formaPago = "Tarjeta de credito"
		3:
			descuento = totalSinDescuento * 0.15
			formaPago = "Vale de regalo"
		De Otro Modo:
			Escribir "Opcion no valida"
	FinSegun
	
	
	totalPagar <- totalSinDescuento - descuento
	
	Escribir "=== DETALLE DE PAGO ==="
	Escribir "Cantidad de impresoras: ", cantidad
	Escribir "Precio unitario con IVA: Q", precioConIVA
	Escribir "Total sin descuento: Q", totalSinDescuento
	Escribir "Forma de pago: ", formaPago
	Escribir "Descuento: Q", descuento
	Escribir "Total a pagar: Q", totalPagar
	
FinAlgoritmo