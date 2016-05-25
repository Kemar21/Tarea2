using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    class Menu

    {
        private Moneda mo;
       
        private Cuenta cuenta;
        private Caja caja;

        public Menu()
        {
            this.mo = new Moneda();
            this.cuenta = new Cuenta();
            this.caja = new Caja();
        }
        
        
        public void recibirMonedas()
        {

            Console.WriteLine("Deposito de monedas");
            Console.WriteLine("Instrucciones para el deposito de dinero:\n 1.Puede ingresar hasta 50 monedas.\n2.Solo puede depositar monedas de 5, 10, 25, 50, 100 y 500");
            Console.WriteLine("Ingrese la cantidad de monedas de 5");
            int moneda1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de monedas de 10");
            int moneda2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de monedas de 25");
            int moneda3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de monedas de 50");
            int moneda4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de monedas de 100");
            int moneda5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de monedas de 500");
            int moneda6 = int.Parse(Console.ReadLine());

            int totalMonedas = (moneda1 * 5) + (moneda2 * 10) + (moneda3 * 25) + (moneda4 * 50) + (moneda5 * 100) + (moneda6 * 500);

            Console.WriteLine("Total Monedas\n" + totalMonedas);
            int total = this.cuenta.getTotalCuenta() + totalMonedas;
            Console.WriteLine("Total en la cuenta"+total);
        }

        
       
        

        public void menuPrincipal()
        {
            bool salir = true;

            while (salir)
            {
                Console.WriteLine("Bienvenido al Cajero Banco Estado");
                Console.WriteLine("");

                Console.WriteLine("Menu Principa");
                Console.WriteLine("1.Deposito de dinero\n2.Retirar Dinero\n3. Recibo de Monedas\n4. Consulta tipo de cambio\n5. Salir");
                Console.WriteLine("Escoja una opcion");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese el monto a depositar");
                            int monto = int.Parse(Console.ReadLine());
                            this.cuenta.depositarDinero(monto);
                            Console.WriteLine("El total en su cuenta es:\n" + this.cuenta.getTotalCuenta());
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            
                            Console.WriteLine("Ingrese el monto a retirar");
                            int monto = int.Parse(Console.ReadLine());
                            if (monto > 50000)
                            {
                                Console.WriteLine("No tiene suficientes fondos");

                            }
                            else
                            {
                                this.cuenta.retirarDinero(monto);
                                Console.WriteLine("El monto total es de\n:" + this.cuenta.getTotalCuenta());

                            }

                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Total en la cuenta\n" + this.cuenta.getTotalCuenta());
                            this.recibirMonedas();
             
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Campio de dolares\n Compra en 540" + "    " + "Venta en 540")
                            Console.WriteLine("Escoja una opcion");
                            ;
                            Console.WriteLine("1.Dolares-Colones");
                            Console.WriteLine("2. Colones-Dolares");
                             opcion = int.Parse(Console.ReadLine());
                            if (opcion == 1) { 
                                Console.WriteLine("Ingrese la cantidad de dolares");
                                int dolares = int.Parse(Console.ReadLine());
                                this.caja.cambioDolares(dolares);
                                Console.WriteLine("Quedaria en \n"+this.caja.getColones() + "colones");
                        }else{
                                Console.WriteLine("Ingrese la cantidad de colones");
                                int colones = int.Parse(Console.ReadLine());
                                this.caja.cambioColones(colones);
                                Console.WriteLine("Quedaria en \n" + this.caja.getDolares() + "dolares");
                            }

                            break;
                            
                        }
                    case 5:
                        {
                            salir = false;
                            
                            break;

                        }
                      
                }
               
            }  
        }
    }
}

         
          
        

    

