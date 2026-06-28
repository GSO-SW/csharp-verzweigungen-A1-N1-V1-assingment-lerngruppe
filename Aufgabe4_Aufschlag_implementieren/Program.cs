// IHR NAME
// IHRE KLASSE

/// <summary>
/// SAS Kontrollstrukturen
/// Arbeitsauftrag 1 - Aufgabe 2
/// Hotel-Check-In-App Aufschlag
/// </summary>


Aufgabe_4.Aufgabe4();

public static class Aufgabe_4
{
    public static void Aufgabe4()
    {

        double zimmerpreis = 70;
        double mwst = 0.19;

        int anzahlNaechte = 0;
        int anz_personen = 0;
        double gesamtpreis = 0;
        double netto_preis = 0;

        Console.WriteLine("Willkommen im Hotel Check-In App");
        Console.WriteLine("Bitte geben Sie die Anzahl der Nächte ein:");
        anzahlNaechte = Convert.ToInt32(Console.ReadLine());



        Console.WriteLine("Bitte geben Sie die Anzahl der Personen ein:");
        anz_personen = Convert.ToInt32(Console.ReadLine());


        netto_preis = zimmerpreis * anzahlNaechte * anz_personen;

        if (anzahlNaechte <= 1) 
        {
            netto_preis += 20;
        }

        gesamtpreis = netto_preis * (1 + mwst);

        Console.WriteLine($"Der Gesamtpreis beträgt:{gesamtpreis,10:F2} EUR");
        
    }
}
