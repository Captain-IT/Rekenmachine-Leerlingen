REKENMACHINE MET STAARTDELING - STARTERPROJECT
=============================================

Doel:
-----

Je gaat een rekenmachine maken in C# (WinForms) die:

- kan optellen, aftrekken, vermenigvuldigen en delen
- bij delen (/) geen gewone / operator gebruikt, maar staartdeling
- een extra venster toont met alle stappen van de staartdeling

Bestanden:
----------

- Programma.cs
  Start de applicatie en opent het hoofdscherm (RekenmachineForm).

- RekenmachineForm.cs
  Dit is het hoofdscherm met:
    - een display (tekstvak bovenaan)
    - knoppen 0 t/m 9
    - knoppen +, -, *, /
    - knop C (wissen)
    - knop = (uitrekenen)

  In dit bestand vul je vooral de event-handlers in:
    - KnopCijferKlik
    - KnopOperatorKlik
    - KnopIsKlik

- RekenLogica.cs
  Hier schrijf je de basisberekening:
    - plus, min, keer
    - delen via staartdeling (met Staartdeling.DeelNaarDecimaleTekst)

- Staartdeling.cs
  Hier schrijf je de staartdeling-logica.
  Belangrijk:
    - je mag hier NIET de gewone / operator gebruiken voor de deling
    - je gebruikt herhaald aftrekken en rest * 10, zoals op papier

  Twee belangrijke methodes:
    - DeelNaarDecimaleTekst: geeft alleen het antwoord (bijv. "2.33333")
    - GenereerVisueleStaartdeling: geeft een uitlegtekst met alle stappen

- StaartdelingForm.cs
  Dit is een apart venster met een groot tekstvak.
  Hier wordt de tekst uit Staartdeling.GenereerVisueleStaartdeling getoond.


Aanpak (suggestie):
-------------------

OPDRACHT 1 - BASISREKENMACHINE
  - Maak de TODO's in RekenLogica.Bereken af voor +, - en *.
  - Maak KnopCijferKlik in RekenmachineForm af zodat je getallen kunt typen.
  - Maak KnopOperatorKlik af zodat de rekenmachine weet welke operator is gekozen.
  - Maak KnopIsKlik af zodat de som wordt uitgerekend en het antwoord in het display komt.
  - Gebruik voor / tijdelijk gewoon (a / b).ToString() om te testen.

OPDRACHT 2 - STAARTDELING ZONDER DECIMALEN
  - Begin in Staartdeling.DeelNaarDecimaleTekst:
      - bereken eerst alleen het gehele deel met herhaald aftrekken.
      - negeer de decimalen nog (aantalDecimalen).
  - Test met simpele delingen, bijvoorbeeld 8 / 2, 9 / 3, 7 / 3.

OPDRACHT 3 - STAARTDELING MET DECIMALEN
  - Vul de TODO's verder in:
      - rest * 10
      - while-lus om decimale cijfers te bepalen
  - Test met 7 / 3, 10 / 4, 1 / 8, enz.

OPDRACHT 4 - VISUELE STAARTDELING
  - Maak GenereerVisueleStaartdeling af.
  - Zorg dat je bij het drukken op = en operator "/" een StaartdelingForm laat zien.

Veel succes!
