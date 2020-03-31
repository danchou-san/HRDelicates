using System;
using Newtonsoft.Json;
using System.IO;
using Figgle;

namespace HRDelicates
{
	class Program
	{
		static void Main(string[] args)
		{
			string retry = "No";
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			do
			{
				// Startscreen
				Console.Clear();
				Console.WriteLine(FiggleFonts.Standard.Render("HRDelicates"));
				Console.WriteLine("Welkom bij de HRDelicates Reservation App!");
				Console.WriteLine("------------------------------------------\n");
				Console.WriteLine("Typ 'r' om te reserveren");
				Console.WriteLine("Typ 'm' om het menu te zien");
				Console.WriteLine("Typ 'c' om de contactgegevens te zien");
				Console.WriteLine("Typ 'q' om de applicatie te sluiten");
				Console.WriteLine("Druk op Enter als u een letter heeft ingetypt\n");
				Console.Write("Typ in: ");
				
				// Code voor kiezen van een letter
				switch (Console.ReadLine())
				{
					case "r":
						// Reserveren
						Reserve();
						Console.WriteLine("U heeft gekozen voor r");
						break;
					case "m":
						// Menu
						Menu();
						retry = Console.ReadLine();
						break;
					case "c":
						// Contactgegevens

						Console.WriteLine("U heeft gekozen voor c");
						Console.Clear();
						Console.WriteLine("Contactgegevens");
						Console.WriteLine("Email : HRDELICATES@hr.nl");
						Console.WriteLine("Telefoon : 0104287287");
						Console.WriteLine("Whatsapp : 0616666602");
						Console.WriteLine(string.Empty);
						Console.WriteLine(string.Empty);
						Console.WriteLine("Openingstijden");
						Console.Write("Ma-Zo: 17.00 - 23.00");
						Console.WriteLine(string.Empty);
						Console.WriteLine(string.Empty);
						Console.WriteLine("Wijnhaven 107,");
						Console.WriteLine("3011 WN Rotterdam.");
						Console.ReadKey();
						break;
					case "q":
						// Quit

						Environment.Exit(0);
						break;
					default:
						// Wanneer er een verkeerde letter is ingetypt

						Console.WriteLine("Er is iets misgegaan. Probeer het opnieuw");
						retry = Console.ReadLine();
						break;
				}
			} while (retry != "No");
		}

		public static void Menu()
		{
			Console.Clear();
			string dish_file = File.ReadAllText(@"Gerechten.json");
			dynamic dishes = JsonConvert.DeserializeObject(dish_file);

			Console.WriteLine(FiggleFonts.Standard.Render("Menu"));
			Console.WriteLine("Gerechten");
			Console.WriteLine("------------------------------------------");

			foreach (var n in dishes)
			{
				Console.Write(n.name + " | ");
				Console.Write("\u20AC" + n.price + "\n");
			}

			Console.WriteLine("\nDranken");
			Console.WriteLine("------------------------------------------");

			foreach (var n in dishes)
			{
				Console.Write(n.name + " | ");
				Console.Write("\u20AC" + n.price + "\n");
			}

			Console.Write("\nDruk enter om terug naar het hoofdmenu te gaan");
		}

		public static void Reserve()
		{
			Console.Clear();

			Console.WriteLine(FiggleFonts.Standard.Render("Reserveren"));
		}
	}
}
