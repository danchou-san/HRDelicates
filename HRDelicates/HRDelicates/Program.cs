using System;

namespace HRDelicates
{
	class Program
	{
		static void Main(string[] args)
		{
			// Startscreen
			Console.WriteLine("Welkom bij de HRDelicates Reservation App!");
			Console.WriteLine("------------------------------------------\n");
			Console.WriteLine("Typ 'r' om te reserveren");
			Console.WriteLine("Typ 'm' om de menu te zien");
			Console.WriteLine("Typ 'c' om de contactgegevens te zien");
			Console.WriteLine("Druk op Enter als u een letter heeft ingetypt\n");
			Console.Write("Typ in: ");

			switch (Console.ReadLine())
			{
				case "r":
					Console.WriteLine("U heeft gekozen voor r");
					break;
				case "m":
					Console.WriteLine("U heeft gekozen voor m");
					break;
				case "c":
					Console.WriteLine("U heeft gekozen voor c");
					break;
				default:
					Console.WriteLine("Er is iets misgegaan. Probeer het opnieuw");
					break;
			}
		}
	}
}
