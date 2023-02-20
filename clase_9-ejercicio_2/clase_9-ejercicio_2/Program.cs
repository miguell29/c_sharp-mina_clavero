/*
Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

1)    Cartón de 3 filas por 9 columnas
2)    El cartón debe tener 15 números y 12 espacios en blanco
3)    Cada fila debe tener 5 números
4)    Cada columna debe tener 1 o 2 números
5)    Ningún número puede repetirse
6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19,
      la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
7)    Mostrar el carton por pantalla 
 
*/

Console.WriteLine(" _______________  GENERADOR DE CARTON DE BINGOS _______________ ");
Console.WriteLine();
Console.WriteLine("Cuantos cartones quiere generar?");
int cantidad = int.Parse(Console.ReadLine());


for (int cant = 0; cant < cantidad; cant++)
{
	int[,] carton = new int[3, 9];
	int numerosTotales = 0;
	int[] numFila = new int[3], numColumna = new int[9]; //cantidad de numeros por filas y por columnas
	int columnaDoble; //cantidad de columnas con dos numeros
	Random num = new Random();

	do
	{
		int fila, columna; //variables que almacenan las posiciones del valor aleatorio
		columnaDoble = 0;
		fila = num.Next(3);
		columna = num.Next(9);

			for (int i = 0; i < numColumna.Length; i++) // contamos la catidad de columnas con 2 numeros
			{
				if (numColumna[i] == 2)
				{
					columnaDoble++;
				}
			}

			int maximoNumColumna = 2; // si la cantidad de columnas con dos numeros es mayor que 6
			if (columnaDoble > 5)		// la cantidad maxima de numeros por columnas se reduce a 1
			{							// por que no puede haber mas de 6 columnas con 2 numeros
				maximoNumColumna = 1;
			}
		if (carton[fila,columna] !=0) // verifica si la posicion ya contiene un numero
		{
			continue;
		}
		else
		{

			if (numFila[fila] >= 5 || numColumna[columna] >= maximoNumColumna) // verificamos que la posicion cumpla con las condiciones del carton
			{
				continue;
			}
			else
			{
				// Aumentamos los contadores de numeros por filas y columnas
				numFila[fila]++;
				numColumna[columna]++;

				int minimo, maximo; //calculamos el minimo y el maximo de numeros posibles dependiendo de la columna
				if (columna == 0)
				{
					//numeros del 1 al 9
					minimo = 1;
					maximo = 10;
				}
				else
				{
					if (columna==8)
					{
						//numeros del 80 al 90
						minimo = 80;
						maximo = 91;
					}
					else
					{
						//numeros del 10 al 79
						minimo = columna * 10;
						maximo = columna * 10 + 10;
					}
				}
				bool repetido;// controlamos que el numero no este repetido

				do
				{
					repetido = false;
					int numeroAleatorio = num.Next(minimo, maximo);  // generamos el numero aleatorio
					for (int i = 0; i < 3; i++)
					{
						if (carton[i,columna] == numeroAleatorio)
						{
							repetido = true; 
						}
					}
					if (!repetido)
					{
					carton[fila, columna] = numeroAleatorio;
					}

				} while (repetido);

			}
		}

		numerosTotales++;

	} while (numerosTotales < 15);

	//Ordenar de menor  mayor
	for (int i = 0; i < numColumna.Length; i++)
	{
		int num1 = -1, num2 = -1;

		if (numColumna[i] == 2)
		{
			for (int j = 0; j < carton.GetLength(0); j++)
			{
				if (carton[j,i] != 0 && num1 == -1)
				{
					num1 = j;
				}
				else
				{
					if (carton[j, i] != 0 && num2 == -1)
					{
						num2 = j;
					}
				}
			}
			if (carton[num1, i] > carton[num2, i])
			{
				int aux = carton[num1, i];
				carton[num1, i] = carton[num2, i];
				carton[num2, i] = aux;
			}
		}
	
	}


	//IMPRIMIR EL CARTON
	Console.WriteLine("-------------------------------------------");
	for (int i = 0; i < carton.GetLength(0); i++)
	{
		for (int j = 0; j < carton.GetLength(1); j++)
		{
			if (j > 0)
			{
				if (carton[i,j] == 0)
				{
				   Console.Write("   | ");
				}
				else
				{
					Console.Write(carton[i, j] + " | ");
				}
			}
			else
			{
				if (carton[i,j] == 0)
					{

					Console.Write("  | ");
				}
				else
				{
				Console.Write(carton[i, j] + " | ");
				}
			}
		}
		Console.WriteLine();
	}
Console.WriteLine("-------------------------------------------");
Console.WriteLine();
Console.WriteLine();
}


Console.ReadKey();