using System;

public class Class1
{
	public Class1()
	{
        //Que son los metodos?
        /* Se entiende por metodo a aquella funcion o procedimiento que se encuentra asociada a una clase u objeto
		 * Esta cumple una funcion especifica y puede recibir parametros de entrada y salida
		 */
        //Para que sirven?
        /* Los metodos sirven para organizar y estructurar el codigo, permitiendo la reutilizacion de codigo
		 * Facilitan el mantenimiento y la legibilidad del codigo, ya que permiten dividir el codigo en bloques logicos
		 */
		//Syntax
		int Suma(int x, int y) 
		{
			x += y;
			return x;
		}
		Console.WriteLine(Suma(4, 5));
		//Syntax metodos sin retorno
		void Suma2(int x, int y)
		{
			x += y;
			Console.WriteLine("El resultado de la suma es:" + x);
		}
		Suma2(1,3);
    }
}
