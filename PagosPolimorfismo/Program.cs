// See https://aka.ms/new-console-template for more information
using PagosPolimorfismo;
//Rosca E27 = estandar o Contrato --> basicamente dice si quieres encajar aqui, debes tener esta forma para recibir electricidad y funcionar
// El Bombillo = es la implementacion de la interfaz del Contrato
//              --> este puede ser Led, Inteligente, Alogeno, Incandecente, de colores, Grande, Pequeño,

//en una casa si no usamos un plafon con este tipo de rosca, toca soldar el bombillo a los alambres de la red electrica
// si usamos interfaces que en este caso es el Plafon. solo es en-rooscarlo lo cual nos permitira mas adelante cambiarlo, actualizarlo. etc

//Poliformismo: es la capacidad de un objeto de tomar muchas formas. en C#, el polimorfismo se logra a través de la herencia y la implementación 
//interfaz: es un contrato que define un conjunto de metodos y propiedades que en una clase debe implementar pero no define como lo hace. en C#, las interfaces se utilizan para definir contratos que las clases pueden implementar, lo que permite una mayor flexibilidad y desacoplamiento en el diseño del software.
//

//Objetivo: crear el nucleo de un sistema de pagos, que pueda procesar diferentes tipos de pagos sin necesidad de cambiar el codigo existente, solo agregando nuevas clases que implementen la interfaz IPagoService
//Problema  nivel 1 = Usar un IF gigante : 
//--> if (pago == "tarjetaCredito") { ...} else if (pago == "Nequi") {...} else if (pago == "Efectivo") {...}
//solucion nivel 5 = definir una interfaz IPago con un metodo ProcesarPago(), luego crear clases concretas como PagoTarjetaCred, PagoNequi, etc que implementen esta interfaz, y finalmente usar polimorfismo para procesar los pagos sin necesidad de ifs gigantes.

class Program
{
	static void Main(string[] args)
	{ 
		decimal totalCompra = 150000m; //la letra m indica que es un decimal, no un double

		Console.WriteLine("=== BIENVENIDO AL E-COMMERCE ITM ===");
		Console.WriteLine("= PROCESO DE PAGO =");
		Console.WriteLine(" Seleccione su metodo de Pago");
		Console.WriteLine("1. Tarjeta de Credito");
		Console.WriteLine("2. Nequi");
		Console.WriteLine("3. Eectivo");
		Console.WriteLine("4. Bitcoin");

		string opcion = Console.ReadLine();

		//variable Polimorfica: puede c guardar cualquiera de las implementaciones de IPagoService
		IPagoService metodoSeleccionado = null;

		//Factory simple  (Fabica de Objetos)
			switch (opcion)
		{
			case "1":
				metodoSeleccionado = new PagoTarjetaCredito();
				break;
			case "2":
				metodoSeleccionado = new PagoNequi();
				break;
			case "3":
				metodoSeleccionado = new PagoEfectivo();
				break;
			case "4":
				metodoSeleccionado = new PagoBitcoin();
				break;
			default:
				Console.WriteLine("Opcion no valida, se Usará el pago en efectivo");
				metodoSeleccionado = new PagoEfectivo();
				break;
		}
		Console.WriteLine("\n Procesando tu pedido...\n");

		//Magia del polimorfismo le paso el metodo seleccionado al procesador de pagos sin importar cual sea, el solo sabe que es un IPagoService y llama al metodo ProcesarPago() sin necesidad de saber como se implementa cada clase concreta
		//El procesador NO SABE que elegi, solo que cumple la interfaz y puede procesar el pago

		var procesador = new ProcesadorDePedidos(metodoSeleccionado);
		procesador.FinalizarPedido(totalCompra);

		Console.ReadKey();
	}

}