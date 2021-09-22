using System;

namespace fahrenheit
{

	public class Program
	{
		public static void Main(string[] args)
		{
			//passando graus celcius para fahrenheit
			//variaveis
			double celcius;
			double fahrenheit;
			//algoritmo
			Console.WriteLine("Passe a temperatura em graus celcius para Fahrenheit!!\n");
			Console.WriteLine("\nDigite a temperatura em graus celcius: ");
			celcius = double.Parse(Console.ReadLine());
			fahrenheit = (celcius * 9 / 5) + 32;
			Console.WriteLine("\nA temperatura em Fahrenheit é: {0}", fahrenheit);
		}
	}
}