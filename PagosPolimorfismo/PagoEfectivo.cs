using System;
using System.Collections.Generic;
using System.Text;

namespace PagosPolimorfismo
{
    public class PagoEfectivo : IPagoService //hacemos el llamado a la interfaz (el contrato)
	{
        public bool ProcesarPago(decimal monto)
        {
			//logica para especificar y procesar un pago con bitcoin
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"[EFECTIVO] Conectando con el Sistema de pagos_Cajero..");
            Console.WriteLine($"[EFECTIVO] Registrando la transaccion bajo el monto: {monto}");
            Console.WriteLine($"[EFECTIVO] Pago Registrado correctamente. ");
            Console.ResetColor();
			return true; //Simulacion del pago Exitoso.
		}
	}
}
