using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    class Cuenta
    {

        private int monto;
        private int cuenta;
        private bool seguir;
        private int totalCuenta;

        public Cuenta()
        {
            this.monto =0;
            this.cuenta = 50000;
            this.seguir = false;
            this.totalCuenta = 0;

        }

        public Cuenta(int monto, int cuenta)
        {
            this.monto = monto;
            this.cuenta = cuenta;
        }

        public void setMonto(int monto)
        {
            this.monto = monto;
        }

        public int getMonto()
        {
            return monto;
        }

        public void setTotalCuenta(int totalCuenta)
        {
            this.totalCuenta = totalCuenta;
        }
        public int getTotalCuenta()
        {
            return totalCuenta;
        }

        public void retirarDinero(int monto)
        {
            if (monto == 10000 || monto == 20000 || monto == 5000 || monto == 2000)
            {
                this.totalCuenta = cuenta - monto;
            }
            else
            {
                if (monto == 50000 && monto == 1000) {
                    Console.WriteLine("No se puede retirar billetes de 50 000 ni de 1000");
                }
            }
        }

        public void depositarDinero(int monto)
        {

            this.totalCuenta = cuenta + monto;
        }

        
        }

    }
}
