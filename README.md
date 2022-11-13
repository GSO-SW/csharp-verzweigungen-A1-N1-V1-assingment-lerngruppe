<div id="container" style="white-space:nowrap">

  <div id="image" style="display:inline float: right;">
        <img style="float: left;" src="./AddFiles/C%23_logo.png" alt="drawing" width="8%"/>
  </div>

  <div id="texts" style="display:inline; white-space:nowrap; float: right;"> 
        <h1>C#-Grundlagen</h1>
        <h3>Arbeitsauftrag zu if-else(if) und switch-case-Anweisungen</h3>
</div>

## :dart: Zielsetzung

Dieser Auftrag hat folgende Ziele:

+ Einfache Programmierprobleme nutzen, um die in den Modulen 1, 2, 3 und 4 behandelten Themen zu Vertiefen
+ Üben ein Problem in kleinere Teilprobleme zu zerlegen
+ Üben Informationen zu Recherchieren, die nicht explizit in der Aufgabenstellung genannt werden
+ Üben Sie das Erstellen, Klonen und Einreichen von Aufträgen über Visual Studio 2022 und GitHub

##  :school_satchel: Skills

+ Zerlegung eines Problems in eine Folge einfacher Aufgaben oder Berechnungen
+ Nutzung des Internets, um Informationen oder Formeln zu finden, die zur Lösung von Programmieraufgaben benötigt werden
+ Verwendung von Zuweisungs-Workflow-Schritten

## :bulb: Benötigtes Wissen
+ Konsolenausgabe formatieren und Daten über die Konsole einlesen
+ Verwendung und Konvertierung von Variablen mit unterschiedlichen Datentypen
+ Verarbeitung von Variablen und Literalen durch Operatoren
+ Anweisungen unter verschiedenen Bedingungen

## :bookmark_tabs: Informationsquelle
Das Informationsmaterial zur Aufgabe finden Sie [hier](./AddFiles/Informationsmaterial)
  
## :white_check_mark: Aufgaben



### Allgemeine Schritte beim Schreiben von Programmen

Die meisten unserer Programme werden dem gleichen allgemeinen Ablauf folgen: Informationen vom Benutzer einlesen, Daten verarbeiten/berechnen, eine Ausgabe erzeugen. Eine Möglichkeit, Ihre Gedanken zu ordnen, besteht darin, **Kommentare zu schreiben**. Verwenden Sie diese als Gliederung für den Code, den Sie schreiben werden. Beginnen Sie mit der Erstellung von Abschnitten für jede der oben genannten Gruppen.

Für jedes Problem müssen Sie die nötigen Schritte zu Eingabe,Verarbeitung und Aufgabe identifizieren und sie in eine Reihenfolge bringen. Schreiben Sie die Schritte als Kommentar auf Deutsch in Ihren Code, bevor Sie programmieren. Wenn Sie das Programm sprachlich nicht umsetzen können, wissen Sie nicht genug, um den Code zu schreiben. 

Bevor Sie den Code schreiben, lesen Sie das Problem und ordnen Sie die Informationen den folgenden Kategorien zu. Tun Sie dies in Kommentaren in Ihrer Codedatei. 

1. **Eingabe** - welche Informationen werden vom Benutzer benötigt? Entwickeln Sie einige Beispieleingaben. Die Eingabefunktion gibt Informationen in Form einer Zeichenkette (Text) zurück. Wenn Sie nach einer Zahl fragen, vergessen Sie nicht, den Text in eine Zahl umzuwandeln, die in nachfolgenden Berechnungen verwendet werden kann. 

2. **Verarbeitung** (Berechnungen) - formeln aufschreiben. Wenden Sie die Beispieleingabewerte von Hand auf Ihre Formeln an, um sie auf ihre Richtigkeit zu überprüfen.

3. **Ausgabe**- was sind die gewünschten Ergebnisse? Liefern Ihre Berechnungen alles, was Sie brauchen? Wenn nicht, gehen Sie  wieder zu Punkt 2.

Erst wenn Sie herausgefunden haben, was Sie tun müssen, beginnen Sie mit dem Schreiben von Code. Beginnen Sie mit dem Abschnitt Eingaben. Schreiben Sie eine Anweisung, die einen Wert vom Benutzer erhält. Sie müssen Variablen erstellen, um die Informationen zu speichern. Verwenden Sie für diese Variablen beschreibende Namen. Geben Sie nach einer Konsoleneingabe den Wert der Eingabe durch eine Konsolenausgabe wieder aus. Führen Sie das Programm zum Testen aus, um sicherzustellen, dass Ihr Code funktioniert. Wenn ja, können Sie die Konsolenausgabe entfernen oder auskommentieren und mit dem nächsten Eingabewert fortfahren. Wenn nicht, müssen Sie Ihren Code korrigieren, bis er funktioniert. Setzen Sie diesen Code- und Testzyklus fort - schreiben Sie eine Zeile Code, dann testen Sie diese.

Sobald Sie alle Eingabewerte haben, fahren Sie mit dem Abschnitt Verarbeitung fort. Möglicherweise müssen Sie zusätzliche Variablen erstellen, um die berechneten Daten zu speichern. Geben Sie diese Berechnungen nach und nach aus. Stimmen sie mit den Handrechnungen überein, die Sie oben gemacht haben? Wenn nicht, korrigieren Sie Ihren Code, um die richtigen Ergebnisse zu erhalten.

Schließlich schreiben Sie die Konsolenausgabe, die die Ausgabe erzeugen. In einem ersten Durchgang geben Sie einfach die gewünschte Ausgabe ein. Gehen Sie dann zurück und fügen Sie die Formatierung hinzu. Um zum Beispiel die Ausgabe in einigen der Beispiele zu erzeugen, müssen Sie möglicherweise Tabulatorzeichen in Ihre Ausgabestrings einfügen.

---

## Hauptauftrag Hotel-Check-In-App

Der Projektleiter beauftragt Sie ein Programm zu entwickeln, das ein Angebot für Hotelübernachtungen erstellen soll.
Die Analyse des Hauptauftrags ergibt folgende wesentliche Verarbeitungsschritte:

Eingabe von:
- Aufenthaltsdauer
- Anzahl der Personen
- Saison (Frühling = 1, Sommer = 2, Herbst = 3, Winter = 4)
- Zimmerkategorie (Standard = 1, Komfort = 2 und Suit = 3)
- Kundenkategorie (Stammkunde = 1, Firmenkunde = 2, Reisebüro = 3)
- Anzahl der Kinder
- Alter je Kind (0 bis 18)

Der Gesamtpreis wird wie folgt berechnet:
- der Zimmerpreis ist abhängig von Zimmerkategorie, Saison und Anzahl Personen:
Nettopreis?Zimmerpreis*Aufenthaltsdauer*Anzahl Personen
- Wenn der Gast nur eine Übernachtung bestellt, wird ein Zuschlag berechnet. 
- Abhängig von der Kundenkategorie werden unterschiedliche Rabatte gewöhrt.
- Für jedes Kind werden folgende Rabatte angeboten:
-- 0 bis 6 Jahre: 100%
-- 7 bis 11 Jahre: 70%
-- Sonst 30 %
- Gesamtpreis = Nettopreis + Nettopreis*MwSt./100

Am Bildschirm wird Folgendes Ausgegeben: 
- Meldung "Berechnen eines Angebots"
- Preisliste je Zimmerkategorie uns Saison
- Für jede Eingabe wird eine Eingabeaufforderung ausgegeben
- Anzahl der Kinder
- Gesamtpreis 

---

### Aufgabe 1: Hotel-Check-In-App Grundgerüst

In der Enwurfsphase für den ersten Anwendungsfall ist das folgende Struktogramm entstanden. Erstellen Sie für dieses Struktogramm den passenden Programmablaufplan (PAP) und laden sie diesen unter der Dateibezeichnung "HotelCeckInApp_Grundgerüst_PAP.jpg" in den Ordner "AddFiles" hoch.



> :information_source: **Hinweise**:exclamation:
> + Sie müssen das Dateiformat und die Namensgebung einhalten damit die PAP Ihnen hier angezeigt wird.

Struktorgramm und PAP:

<img src="./AddFiles/HotelCeckInApp_Grundgerüst_STR.jpg" width=50% ><img src="./AddFiles/HotelCeckInApp_Grundgerüst_PAP.jpg" width=50% >

---
  
### Aufgabe 2: Hotel-Check-In-App Grundgerüst implementieren

Setzen Sie den Entwurf aus Aufgabe 1 in ein C#-Programm um. Beachten Sie dabei die folgenden Werte.

Zimmerpreis: 70€   
Mehrwertsteuer: 19%
  
> :information_source: **Hinweise**:exclamation:
> + Beachten Sie, dass Sie die Ausgabe unter der gestrichelten Linie erzeugen müssen, um die Aufgabe zu bestehen
> + Die Ausgabe hat nach dem ':' genau 14 Stellen
> + Runden Sie das Ergebnis auf **zwei** Nachkommastelle


Beispiel (Aufenthaltsdauer: 1 Tag / Anzahl der Personen: 2):

<img src="./AddFiles/Task1_example.jpg" width=100% >
  
---

### Aufgabe 3: Hotel-Check-In-App Aufschlag

Wenn der Gast nur eine Übernachtung bestellt, wird ein Zuschlag von 20€ Netto berechnet. Passen Sie Struktorgramm und Programmablaufplan entsprechend an und laden Sie es unter der Bezeichnung "HotelCeckInApp_Aufschlag_STR.jpg" und "HotelCeckInApp_Aufschlag_PAP.jpg" in den Ordner AddFiles hoch. 

<img src="./AddFiles/HotelCeckInApp_Aufschlag_STR.jpg" width=50% ><img src="./AddFiles/HotelCeckInApp_Aufschlag_PAP.jpg" width=50% >


> :information_source: **Hinweise**:exclamation:
> + Sie müssen das Dateiformat und die Namensgebung einhalten damit die PAP Ihnen hier angezeigt wird.

---

### Aufgabe 4: Hotel-Check-In-App Aufschlag implementieren

Setzen Sie den Entwurf aus Aufgabe 3 in ein C#-Programm um. Beachten Sie dabei die folgenden Werte.

Zimmerpreis: 70€   
Mehrwertsteuer: 19%


> :information_source: **Hinweise**:exclamation:
> + Beachten Sie, dass Sie die Ausgabe unter der gestrichelten Linie erzeugen müssen, um die Aufgabe zu bestehen
> + Die Ausgabe hat nach dem ':' genau 14 Stellen
> + Runden Sie das Ergebnis auf **zwei** Nachkommastelle


Beispiel (Aufenthaltsdauer: 1 Tag / Anzahl der Personen: 2):

<img src="./AddFiles/Task2_example.jpg" width=100% >

---
  
### Aufgabe 5: Arbeit einreichen

1. In Visual Studio 2022 das Fenster "Git-Änderungen" aufrufen
2. Eine kurze Beschreibung Ihrer Änderungen in die Textbox eingeben und "commit für alle" klicken
3. Mit dem Pfeil nach oben die Arbeit auf GitHub pushen.
4. Das Repository im Brower aufrufen und aktualisieren um die Änderungen zu bestätigen.
5. Im Pull-Request die Nachricht "Bereit zum Bewerten" hinterlassen, damit Ihre Lehrkraft weiss das Sie fertig sind.

---
  
# :100: Erfolgskriterien
  
+ Eingesetzten Quellcode kommentieren
+ Quellcode schreiben der lesbar ist und mit Hilfe einer logischen Folge das Problem löst
+ Programmausgabe die korrekt, lesbar und richtig formatiert ist 
