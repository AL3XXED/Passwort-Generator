// Main UI-Flow
using cerberus_pass;


var manager = new PasswortManager();
var pass1 = new PasswordEntry
("steam", "WaldmeisterSD", "@ssword",
 "https://store.steampowerd.com", "Mein Account");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Willkomen zu Cerberus-Pass!");
Console.ResetColor();

do
{
    Console.WriteLine("Wähle was du tun willst");

    Console.WriteLine("""
 1. Passwort-Liste ausgeben
 2. Passwort mit ID ausgeen
 3. Neues Passwort erstellen
 4. Vorhandenes Passwort bearbeiten
 5. Passwort löschen
 """);

    var userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            var vault = manager.GetAll()
            console.WriteLine(vault);
            break;

        case "2":
            break;

        case "3":
            Console.WriteLine("Gib ein Titel an:");
            var titel = Console.ReadLine();
            Console.WriteLine("Gib ein Login an:");
            var login = Console.ReadLine();
            Console.WriteLine("Gib ein Passwort an:");
            var password = Console.ReadLine();
            var newEntry = manager.CreateEntry(titel, login, password);
            Console.WriteLine(newEntry);
            break;

        case "4":
            break;

        case "5":
            break;

        default:
            break;
    };
    Console.ReadKey();
} while (true);
//Console.WriteLine("""Programm Ende");