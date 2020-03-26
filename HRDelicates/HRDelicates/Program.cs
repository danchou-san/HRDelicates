﻿using System;
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
			
				switch (Console.ReadLine())
				{
					case "r":
						Console.WriteLine("U heeft gekozen voor r");
						break;
					case "m":
						Console.Clear();
						string dish_file = File.ReadAllText(@"dishes.json");
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
						retry = Console.ReadLine();

						break;
					case "c":
						Console.WriteLine("U heeft gekozen voor c");
						break;
					case "q":
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("Er is iets misgegaan. Probeer het opnieuw");
						retry = Console.ReadLine();
						break;
				}
			} while (retry != "No");
		}
	}
}
