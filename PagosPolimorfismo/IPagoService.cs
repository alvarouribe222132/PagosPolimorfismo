using System;
using System.Collections.Generic;
using System.Text;

namespace PagosPolimorfismo
{
    //summary
    //Contrato: Todo tipo de transaccion que necesite procesar un pago
    //DEBE Saber Esto: No es relevante saber el Como lo hace.
    //</summary>
    public interface IPagoService
    {
        //Solo se define la firma: Que ingresa y que sale, pero no el proceso
        // No hay llaves {} ni codigo aqui, solo la firma del metodo
        bool ProcesarPago(decimal monto);
    }
}
