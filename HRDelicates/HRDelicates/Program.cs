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
				retry = "No";
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
						Reserve_start();
						retry = Console.ReadLine();
						break;
					case "m":
						// Menu
						Menu();
						retry = Console.ReadLine();
						break;
					case "c":
						// Contactgegevens
						Contact();
						retry = Console.ReadLine();
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
		}

		public static void Reserve_start()
		{
			string table_file = File.ReadAllText(@"Tafels.json");
			dynamic tables = JsonConvert.DeserializeObject(table_file);
			string retry = "No";

			do
			{
				retry = "No";

				Console.Clear();
				string temp_number;
				int t_number;

				Console.WriteLine(FiggleFonts.Standard.Render("Reserveren"));
				Console.WriteLine("------------------------------------------");
				Console.WriteLine("Voor hoeveel personen wilt u reserveren? Typ in een nummer van 1 tot en met 6:");

				temp_number = Console.ReadLine();

				if (temp_number != "")
				{
					t_number = Convert.ToInt32(temp_number);

					if (t_number >= 1 && t_number <= 6)
					{
						Console.Clear();

						Console.WriteLine("Tafels die beschikbaar zijn voor " + t_number + " personen:");
						Console.WriteLine("------------------------------------------");

						if (t_number <= 2)
						{
							foreach (var n in tables)
							{
								if (n.space >= 2 && n.status == "Available")
								{
									Console.WriteLine("Tafel " + n.id + " | max " + n.space + " personen");
								}
							}
						}
						else if (t_number <= 4)
						{
							foreach (var n in tables)
							{
								if (n.space >= 4 && n.status == "Available")
								{
									Console.WriteLine("Tafel " + n.id + " | max " + n.space + " personen");
								}
							}
						}
						else if (t_number <= 6)
						{
							foreach (var n in tables)
							{
								if (n.space == 6 && n.status == "Available")
								{
									Console.WriteLine("Tafel " + n.id + " | max " + n.space + " personen");
								}
							}
						}
						else
						{
							Console.WriteLine("Er is iets misgegaan. Probeer het opnieuw");
							retry = Console.ReadLine();
						}

						Console.WriteLine("------------------------------------------");
						Console.WriteLine("Kies een tafelnummer:");
						TableChoose();
					}
					else
					{
						Console.WriteLine("Er is iets misgegaan. Probeer het opnieuw");
						retry = Console.ReadLine();
					}
				}
				else
				{
					Console.WriteLine("Er is iets misgegaan. Probeer het opnieuw");
					retry = Console.ReadLine();
				}
			} while (retry != "No");
		}

		public static void TableChoose()
		{

		}

		public static void Contact()
		{
			Console.Clear();
			Console.WriteLine("Contactgegevens");
			Console.WriteLine("------------------------------------------\n");
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
			Console.Write("\nDruk enter om terug naar het hoofdmenu te gaan");
		}
	}
}
