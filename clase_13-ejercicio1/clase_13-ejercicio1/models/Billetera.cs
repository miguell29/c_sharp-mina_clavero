using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_13_ejercicio1.models
{
    internal class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }


        //Constructor 

        public Billetera() 
        {
            BilletesDe10 = 0;
            BilletesDe50 = 0;
            BilletesDe100 = 0;
            BilletesDe200 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;
        }

        public decimal Total()
        {
            decimal total = 0;
            total += BilletesDe10*10;
            total += BilletesDe50*50;
            total += BilletesDe100*100;
            total += BilletesDe200*200;
            total += BilletesDe500*500;
            total += BilletesDe1000*1000;
            return total;
        }

        public Billetera Combinar(Billetera billetera1, Billetera billetera2)
        {
            Billetera nueva = new Billetera()
            {
                BilletesDe10 = billetera1.BilletesDe10 + billetera2.BilletesDe10,
                BilletesDe50 = billetera1.BilletesDe50 + billetera2.BilletesDe50,
                BilletesDe100 = billetera1.BilletesDe100 + billetera2.BilletesDe100,
                BilletesDe200 = billetera2.BilletesDe200 + billetera2.BilletesDe200,
                BilletesDe500 = billetera1.BilletesDe500 + billetera2.BilletesDe500,
                BilletesDe1000 = billetera1.BilletesDe1000 + billetera2.BilletesDe1000,
                
            };
            billetera1.BilletesDe10 = 0;
            billetera1.BilletesDe50 = 0;
            billetera1.BilletesDe100 = 0;
            billetera1.BilletesDe200 = 0;
            billetera1.BilletesDe500 = 0;
            billetera1.BilletesDe1000 = 0;
            billetera2.BilletesDe10 = 0;
            billetera2.BilletesDe50 = 0;
            billetera2.BilletesDe100 = 0;
            billetera2.BilletesDe200 = 0;
            billetera2.BilletesDe500 = 0;
            billetera2.BilletesDe1000 = 0;

            return nueva;
        }
    }
}