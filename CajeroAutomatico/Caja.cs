using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    class Caja
    {
        private int colones;
        private int dolares;
       
        private const int dolar = 530;



        public Caja()
        {
            this.colones = 0;
            this.dolares = 0;
           
        }

        public Caja(int colones, int dolares)
        {
            this.colones = colones;
            this.dolares = dolares;

        }

        public void setColones(int colones)
        {
            this.colones = colones;
        }

        public int getColones()
        {
            return colones;
        }

        public void setDolares(int dolares)
        {
            this.dolares = dolares;

        }

        public int getDolares()
        {
            return dolares;
        }


        public int cambioColones(int colones)
        {
            this.dolares = colones / dolar;
            return this.dolares;
        }

        public int cambioDolares(int dolares)
        {

            this.colones = dolares * dolar;
            return this.colones;
        }

       

    }
}