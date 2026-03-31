using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.Esercizi
{
    internal class Gestione_Parcheggio
    {
        static void Main_Parcheggio(string[] args)
        {
            // Esercizio: Sistema di Gestione Parcheggio
            // Scrvi un programma che gestisce un piccolo parcheggio con 10 posti.
            // (1) Chiedi all'utente se vuole parcheggiare o uscire.
            // (2) Se vuole parcheggiare, il sistema cerca automaticamente il primo posto libero.
            // (3) Se il parcheggio è pieno, stampa: "Parcheggio al completo".

            List<string> posti = new List<string>()
            {
                "A01","A02","A03","A04","A05","A06","A07","A08","A09","A010",
            };
            
            
            Console.WriteLine("Salve, vuole parcheggiare o uscire?");
            string risposta = Console.ReadLine().ToLower();
            Random rdn = new Random();
            bool posto_libero = false; // <- Bandiera. Sto ipotizzando che il posto NON E' libero.

            

            if (risposta != "parcheggiare" && risposta != "uscire")
            {
                Console.WriteLine("Risposta non corretta. Uscita dal sistema in corso...");
                return;
            }
            else if (risposta == "parcheggiare")
            {
                if (posti.Count == 0) Console.WriteLine("Parcheggio al completo.");
                while (!posto_libero)
                {
                    int IndiceRandom = rdn.Next(posti.Count);
                    string posto_random = posti[IndiceRandom];
                    posti.Contains(posto_random);
                    posto_libero = true;
                    Console.WriteLine($"Il posto è {posto_random}! Passi una buona giornata.");
                    posti.Remove(posto_random);
                }
            }
            else if(risposta == "uscire")
            {
                int IndiceRandom = rdn.Next(posti.Count);
                string posto_random = posti[IndiceRandom];
                posti.Contains(posto_random);
                posto_libero = true;
                Console.WriteLine($"Ha liberato il posto {posto_random}. Le auguriamo una buona giornata.");
                posti.Add(posto_random);

            }
        }
    }
}
