using OHCE;
using OHCE.Langues;

ILangue langue = new LangueEN(); //Automatisation dans les prochaines Etapes.

PeriodeJournee periode = PeriodeJournee.Soir; //Automatisation dans les prochaines Etapes.

var ohce = new Ohce(langue, periode);

Console.WriteLine(" ___ TP OHCE AXEL BAUDOIN ___ \n");

Console.WriteLine(langue.LangageUtilise + " : " + langue);

Console.WriteLine(langue.Periode + " : " + periode);

Console.WriteLine(langue.InputText);

Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));