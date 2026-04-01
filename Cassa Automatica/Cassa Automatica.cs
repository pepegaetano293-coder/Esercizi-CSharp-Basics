using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.Esercizi
{
    internal class Cassa_Automatica
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Esercizio: Cassa automatica
            // (1) Crea una lista chiamata "carrello" (vuota).
            // Utilizzando la funzione Random, crea casualmente dei valori per ogni prodotto aggiunto in carrello.
            // (2) L'utente può aggiungere prodotti al carrello scrivendo il nome.
            // (3) Quando l'utente scrive "totale", il programma calcola la somma dei prezzi di tutto quello che c'è nella lista.
            // (4) Se il totale supera i 50€, applica uno sconto del 10%.
            // (5) Stampa il conto finale e svuota la lista per il cliente successivo.

            List<string> carrello = new List<string>();
            List<int> valori = new List<int>();
            Random rdn = new Random();

            string risposta = "";

            Console.WriteLine("Inserisci i prodotti da comprare");

            while (risposta.ToLower() != "totale")
            {
                risposta = Console.ReadLine();
                if(risposta.ToLower() != "totale")
                {
                    carrello.Add(risposta);
                    int prezzo = rdn.Next(1, 50);
                    valori.Add(prezzo);
                    Console.WriteLine($"Prodotto acquistato: {risposta}. Prezzo: {prezzo}€");
                }
                else
                {
                    int somma = 0;
                    Console.WriteLine("\n--- Riepilogo Spesa ---");
                    for(int i = 0; i< valori.Count; i++)
                    {
                        Console.WriteLine($"Prodotto: {carrello[i]} - Prezzo: {valori[i]}");
                        somma = somma + valori[i];
                    }
                    if(somma >= 50)
                    {
                        double sconto = (somma * 10) / 100;
                        double TotaleSconto = somma - sconto;
                        Console.WriteLine($"Sconto del 10% applicato: {sconto}€. Totale da pagare: {TotaleSconto}€ ");
                    }
                    else Console.WriteLine($"TOTALE FINALE: {somma}€");
                    Console.WriteLine("Grazie e arrivederci!");
                }
              
            }
        }
    }
}
