using OHCE;

var ohce = new Ohce();
Console.WriteLine(" ___ TP OHCE AXEL BAUDOIN ___ \n");
Console.WriteLine("Entrez un mot : ");
Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));