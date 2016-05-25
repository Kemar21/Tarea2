using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    class Moneda
    {


        private int valorMoneda;
        private int cantidad;
        
        

        public Moneda()
        {
            this.cantidad = 0;
            this.valorMoneda = 0;
           
        }

        public Moneda(int valorMoneda, int cantidad)
        {
            this.cantidad = cantidad;
            this.valorMoneda = valorMoneda;
            
        }

        public void setValorMoneda(int valorMoneda)
        {
            this.valorMoneda = valorMoneda;
        }

        public int getValorMoneda()
        {
            return valorMoneda;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public int getCantidad()
        {
            return cantidad;
        }



        public void cantidadMonedas(int moneda)
        {
            this.cantidad = moneda++;
        }

       
    }
}
