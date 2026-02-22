using System;
using System.Collections.Generic;
using System.Text;

namespace PagosPolimorfismo
{
	public class PagoBitcoin : IPagoService  //hacemos el llamado a la interfaz (el contrato)
	{
			public bool ProcesarPago(decimal monto)
			{

				//aqui iria la logica especifica para procesar un pago con bitcoin
				Console.ForegroundColor = ConsoleColor.Green;

				Console.WriteLine($"[BITCOIN] Accediendo a la WALLET..");
				Console.WriteLine($"[BITCOIN] Conectando con Visa/Mastercard ...En Progreso..");
				Console.WriteLine($"[BITCOIN] Debitando {monto}  de la Cuenta Terminada en  *****9237. ");
				Console.ResetColor();
				return true; //Simulacion del pago Exitoso.

			}


		}
}
