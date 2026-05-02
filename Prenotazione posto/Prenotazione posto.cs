using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CorsoCSharp.Esercizi
{
    internal class Prenotazione_posto
    {
        static void Main(string[] args)
        {
            // Esercizio: Prenotazione posto.
            // Immagina di voler prenotare un volo aereo con la compagnia aerea Ryanair.
            // Scrivi un programma che simula la prenotazione aerea, domandando all'utente se
            // vuole prenotare un posto o no.
            // Se non prenota il posto, il sistema dovrà scegliere in modo randomico il posto libero che assegnerà al cliente.
            // Se il posto è occupato, stampa: "Posto occupato". Riprova.

            List<string> posti = new List<string>
            {
                "A01","A02","A03","A04","A05","A06","A07","A08","A09","A010",
                "B01","B02","B03","B04","B05","B06","B07","B08","B09","B010",
                "C01","C02","C03","C04","C05","C06","C07","C08","C09","C010",
                "D01","D02","D03","D04","D05","D06","D07","D08","D09","D010",
                "E01","E02","E03","E04","E05","E06","E07","E08","E09","E010",
                "F01","F02","F03","F04","F05","F06","F07","F08","F09","F010"
            };


            Random rdn = new Random();
            Console.WriteLine("Salve, vuole prenotare un posto? (Sì / No / Casuale)");
            string risposta = Console.ReadLine().Trim().ToLower(); // Pulizia input

            // 1. Gestione uscita immediata
            if (risposta == "forse" || risposta == "non lo so")
            {
                Console.WriteLine("Risposta non valida! Uscita in corso...");
                return;
            }

            if (risposta == "no")
            {
                Console.WriteLine("Grazie e arrivederci.");
                return;
            }

            // 2. Visualizzazione posti
            Console.WriteLine("I posti disponibili sono i seguenti:");
            var gruppi = posti.Chunk(10);
            foreach (var gruppo in gruppi)
            {
                Console.WriteLine(string.Join(", ", gruppo));
            }

            // 3. Logica di prenotazione
            bool prenotazioneCompletata = false;

            if (risposta == "si" || risposta == "sì")
            {
                while (!prenotazioneCompletata)
                {
                    Console.WriteLine("\nDigita il posto desiderato:");
                    string scelta = Console.ReadLine().ToUpper(); // I posti in lista sono maiuscoli

                    if (posti.Contains(scelta))
                    {
                        posti.Remove(scelta);
                        prenotazioneCompletata = true;
                        Console.WriteLine($"Ottimo, ha scelto {scelta}. Le auguriamo buon viaggio.");
                    }
                    else
                    {
                        Console.WriteLine("Posto non disponibile o inesistente. Riprova.");
                    }
                }
            }
            else // Gestione "Casuale" o qualsiasi altra risposta non prevista come NO
            {
                if (posti.Count > 0)
                {
                    int indiceRandom = rdn.Next(posti.Count);
                    string postoScelto = posti[indiceRandom];
                    posti.RemoveAt(indiceRandom); // Rimuoviamolo per coerenza!
                    Console.WriteLine($"Il sistema ha scelto per lei il posto: {postoScelto}. Buon viaggio!");
                }
                else
                {
                    Console.WriteLine("Spiacenti, i posti sono esauriti.");
                }
            }
        }
    }
}
