
string auswahlmenü;
do
    
{
    Console.Clear();
    Console.WriteLine("Immobilienrechner");
    Console.WriteLine("Menü");
    Console.WriteLine("Bitte wählen Sie den passenden Rechner für Sie");
    Console.WriteLine("1 - Kaufkostenrechner");
    Console.WriteLine("2 - Mietrenditenrechner (Brutto)");
    Console.WriteLine("3 - Baufinanzierungsrechner");
    Console.WriteLine("4 - Zurück zum Sub-Menü");
    Console.WriteLine("5 - Exit--> Programm beenden");
    auswahlmenü = Console.ReadLine();
    if (auswahlmenü == "1")
    {
        Console.Clear();
        Console.WriteLine("Kaufkostenrechner");
        Console.WriteLine("Geben Sie den Kaufpreis der Immobilie ein:");
        string Kaufpreisvar = Console.ReadLine();
        double Kaufpreisdouble = Convert.ToDouble(Kaufpreisvar);
        
        Console.WriteLine("Geben Sie die Marklerkosten in % ein");
        string Marklerkostenvar = Console.ReadLine();
        double Marklerkostendouble = Convert.ToDouble(Marklerkostenvar);

        double Notarbetrag = Kaufpreisdouble * 0.015;
        
        double Grundwerbesteuer = Kaufpreisdouble * 0.065;
        
        double Marklergeld = Marklerkostendouble / 100 * Kaufpreisdouble  ;
        double Gesamt = Kaufpreisdouble + Notarbetrag + Grundwerbesteuer + Marklergeld;
        Console.WriteLine($"Ihr Gesamtpreis beträgt:{Gesamt}");

        Console.ReadLine();

    }


}
while (auswahlmenü != "4" || auswahlmenü != "5"); 
