using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CorsoCSharp.Esercizi
{
    internal class Prenotazione_posto
    {
        static void Main_Prenotazione(string[] args)
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
            Console.WriteLine("Salve, vuole prenotare un posto?");
            string risposta = Console.ReadLine();
            bool posto_libero = false; // <- Rappresenta una bandiera. In questo caso, parto dal presupposto che
                                       // il posto NON sia libero.

            var gruppi = posti.Chunk(10); // <- Utilizzo questo comando per "separare" i posti a 10 a 10 in console.
                                          // In questo caso, sto semparando la lista 'posti' in una sotto-lista 'gruppi' composta da 10 elementi.

            if (risposta == "Forse" || risposta == "Non lo so")
            {
                Console.WriteLine("Risposta non valida! Uscita in corso...");
                return;
            }
            Console.WriteLine($"I posti disponibili sono i seguenti: ");
            foreach (var gruppo in gruppi)
            {
                Console.WriteLine(string.Join(", ", gruppo) + ",");
            }
            if(risposta == "sì" || risposta == "Sì" || risposta == "SI" || risposta == "si")
            {
                while (!posto_libero)
                {
                    Console.WriteLine("Digità il posto desiderato: ");
                    string risposta2 = Console.ReadLine();

                    if (posti.Contains(risposta2)) // <- Sto dicendo il seguente: "SE la 'risposta' che viene scritta in input APPARTIENE alla
                                                   // Lista "posti". 
                    {
                        posti.Remove(risposta2); // <- In questo caso, quando viene scritto in input il posto desiderato, quest ultimo verrà eliminato dalla lista.
                        posto_libero = true;
                        Console.WriteLine($"Ottimo, ha scelto {risposta2}. Le auguriamo buon viaggio.");
                    } else Console.WriteLine("Posto non disponibile. Riprova.");
                    
                }
            }
            else
            {
                while (!posto_libero)
                {
                    int IndiceRandom = rdn.Next(posti.Count);
                    string posto_random = posti[IndiceRandom];
                    posti.Contains(posto_random);
                    posto_libero = true;
                    Console.WriteLine($"Il posto assegnato è {posto_random}. Le auguriamo buon viaggio.");
                }
            }
        }
    }
}
