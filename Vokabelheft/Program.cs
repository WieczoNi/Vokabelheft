List<string[]> vokabeln = new List<string[]>();
string deutsch;
string englisch;

while (true)
{
    Console.Clear();
    Console.WriteLine("Bitte geben sie ein Deutsches wort ein");
    deutsch = Console.ReadLine();
    
    Console.WriteLine("Bitte geben sie die englische Übersetzung ein");
    englisch = Console.ReadLine();
    vokabeln.Add(new string[2] {deutsch, englisch} );
   
    foreach (string[] wort in vokabeln)
    {
        Console.WriteLine("");
        Console.WriteLine(wort[0]);
        Console.WriteLine(wort[1]);
    }
    Console.WriteLine("");
    Console.WriteLine("Taste drücken, um ein weiteres Wort hinzuzufügen");
    Console.ReadKey();
}
