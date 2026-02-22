using System;
using System.Collections.Generic;
using System.Text;

namespace PagosPolimorfismo
//El procesador (Donde Ocurre la magia del Polimorfismo)
////es el encargado de recibir cualquier tipo de pago, sin importar su implementacion concreta, 
/////y procesarlo usando la interfaz IPagoService. 
/////Esto permite que el sistema sea altamente extensible y mantenible, 
/////ya que se pueden agregar nuevos tipos de pagos sin modificar el codigo existente, 
/////solo creando nuevas clases que implementen la interfaz.

{
    public class ProcesadorDePedidos
    {
        private readonly IPagoService _servicioDePago;

        //Inyeccion de Dependencias (Manual por el Momento)
        //El servicio especifico viene desde afuera (Constructor)

        public ProcesadorDePedidos(IPagoService servicioDePago)
        {
            _servicioDePago = servicioDePago;
		}
    public void FinalizarPedido(decimal total)
        {
            Console.WriteLine($"Iniciando Proceso de Compra por un total de $ {total}");
			//Polimorfismo en Acción: No sabemos el tipo de pago, pero sabemos que tiene el metodo ProcesarPago() gracias a la interfaz
            //aqui se ejecuta el codigo comun para targeta, nequi, efectivo bitcoin, etc

            bool resultado = _servicioDePago.ProcesarPago(total);

            if (resultado) 
            {
                Console.WriteLine("Pedido enviado al almacen. !Gracias Por su Compra!!!");
            }
            else
            {
                Console.WriteLine("Pedido pendiente de pago. Por"); 
            }

		}
	}
           
}
