using CorsoCSharp.OOP.Esercizio_16;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.Esercizi
{
    internal class Distributore_Snack
    {
        static void Main_Snack(string[] args)
        {
            // Esercizio: Crea un simulatore di un distributore che ha 5 tipi di prodotti, ognuno con una quantità limitata (es. 3 pezzi per tipo).
            // (1) L'utente sceglie un prodotto tramite un ID (0-4).
            // (2) Se il prodotto è disponibile, scala la quantità e conferma l'acquisto.
            // (3) Se la quantità è 0, stampa: "Prodotto esaurito. Scegli un altro snack".
            // (4) Il programma continua finché l'utente non decide di smettere o finchè tutti i prodotti sono esauriti.

            List<string> prodotti = new List<string>()
            {
                "Barretta proteica", "Patatine proteiche", "Tramezzini", "Yogurt", "Caramelle"
            };

            bool snack_disponibile = false; // <- Bandiera. Ipotizzo che lo snack NON E' disponibile
            int quantità = 3;

            while (quantità > 0) // <- Ciclo infinito che permette di effettuare più acquisti
            {
                Console.WriteLine("Ciao, scegli un prodotto da 0 a 4: ");
                int risposta = int.Parse(Console.ReadLine());
                if (risposta >=0 && risposta < prodotti.Count)
                {
                    snack_disponibile = true;
                    Console.WriteLine($"Quantità disponibile: {quantità}. Hai scelto {prodotti[risposta]}. Desidera altro?");
                    quantità--;
                    Console.WriteLine($"Quantità rimasta: {quantità}");
                } else Console.WriteLine("Scelta non valida. Riprova!");

            }
            Console.WriteLine("Distributore vuoto. Arrivederci");
        }
    }
}
