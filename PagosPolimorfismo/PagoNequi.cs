using System;
using System.Collections.Generic;
using System.Text;

namespace PagosPolimorfismo
{
    public class PagoNequi : IPagoService //hacemos el llamado a la interfaz (el contrato)
	{
        public bool ProcesarPago(decimal monto) 
		{
			//logica para especificar y procesar un pago con bitcoin
			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine($"[Pago_Nequi] Conectando con la plataforma de Pago de Nequi");
			Console.WriteLine($"[Pago_Nequi] Debitanto el monto: {monto}");
			Console.WriteLine($"[Pago_Nequi] Pago Registrado Correctamente. ");
			Console.ResetColor();
			return true;

		}
	}
}
