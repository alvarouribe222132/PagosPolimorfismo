using System;
using System.Collections.Generic;
using System.Text;

namespace PagosPolimorfismo
{ // OPCION A: Pago con Tarjeta (Bombillo Led)
	public class PagoTarjetaCredito : IPagoService //hacemos el llamado a la interfaz (el contrato)
	{
		public bool ProcesarPago(decimal monto)
		{
			//aqui iria la logica especifica para procesar un pago con tarjeta
			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine($"[TARJETA] Conectando con Visa/Mastercard ...En Progreso..");
			Console.WriteLine($"[TARJETA] Debitando {monto}  de la Cuenta Terminada en  *****9237. ");
			Console.ResetColor();
			return true; //Simulacion del pago Exitoso.
		}
	}

	//OPCION B: Pago con Nequi (El )
}
