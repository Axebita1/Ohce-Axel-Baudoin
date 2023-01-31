using OHCE;
using OHCE.Console;

PeriodeJournee periode = new Time().PeriodeActuelle;
ILangue langue = new Proxy().Langue; //Automatisation dans les prochaines Etapes.

var ohce = new Ohce(langue, periode);

Console.WriteLine(" ___ TP OHCE AXEL BAUDOIN ___ \n");

Console.WriteLine(langue.LangageUtilise + " : " + langue);

Console.WriteLine(langue.Periode + " : " + periode);

Console.WriteLine(langue.InputText);

Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));