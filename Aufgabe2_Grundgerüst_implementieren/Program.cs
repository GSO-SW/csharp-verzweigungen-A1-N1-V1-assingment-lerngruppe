// IHR NAME
// IHRE KLASSE

/// <summary>
/// SAS Kontrollstrukturen
/// Arbeitsauftrag 1 - Aufgabe 2
/// Hotel-Check-In-App Grundgerüst
/// </summary>


Aufgabe_2.Aufgabe2();

public static class Aufgabe_2
{
    public static void Aufgabe2()
    {
        //Diese Zeile mit Ihrem Quellcode ersetzen

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
        gesamtpreis = netto_preis * (1 + mwst);

        Console.WriteLine($"Der Gesamtpreis beträgt:{gesamtpreis,10:F2} EUR");

    }
}
