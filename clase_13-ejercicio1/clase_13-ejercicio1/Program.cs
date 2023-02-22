using clase_13_ejercicio1.models;

namespace clase_13_ejercicio1
{
    internal class Program
    {
        /*
         Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

            BilletesDe10
            BilletesDe20
            BilletesDe50
            BilletesDe100
            BilletesDe200
            BilletesDe500
            BilletesDe1000

        Agregar un método que se llame Total del tipo decimal,
        y que devuelva el Importe Total en la billetera teniendo en cuenta 
        la cantidad de billetes que se tenga de cada tipo.

        Agregar un metodo que se llame Combinar,
        que reciba como parámetro otra billetera y que devuelva una nueva Billetera 
        con la suma o combinacion del dinero de ambas billeteras.  
        Una vez combinadas las 2 billeteras (y creada la tercera), 
        las 2 primeras billeteras deberan quedar en cero. (Sin billetes)
         
         */
        static void Main(string[] args)
        {
            Billetera miBilletera = new Billetera()
            {
                BilletesDe10 = 17,
                BilletesDe50 = 3,
                BilletesDe100= 4,
                BilletesDe500 = 2,
                BilletesDe200 = 1,
                BilletesDe1000 = 7
            };

            Billetera billeteraVieja = new Billetera()
            {
                BilletesDe10 = 5,
                BilletesDe100 = 10,
                BilletesDe1000 = 2,
                BilletesDe500 = 1
            };

            Console.WriteLine("EN MI BILLETERA TENGO $"+miBilletera.Total());
            Console.WriteLine("EN LA BILLETERA VIEJA TENGO $"+billeteraVieja.Total());

            Billetera billeteraNueva = miBilletera.Combinar(miBilletera, billeteraVieja);

            Console.WriteLine($"ME COMPRE UNA BILLETERA NUEVA Y SUMANDO TODAS LAS BILLETERAS TENGO ${billeteraNueva.Total()}");

            Console.WriteLine($"SALDO BILLETERA: ${miBilletera.Total()}");
            Console.WriteLine($"SALDO BILLETERA VIEJA: ${billeteraVieja.Total()}");


            Console.ReadKey();
            
        }
    }
}