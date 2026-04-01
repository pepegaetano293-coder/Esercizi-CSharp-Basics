using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.Esercizi
{
    internal class ListaVIP
    {
        static void Main_VIP(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Esercizio: Sistema di controllo accessi VIP (confronto stringhe)
            // Questo simula tun buttafuori digitale. Serve a capire come cercare dati dentro una lista
            // (1) Chiedi il nome all'utente.
            // (2) Crea un sistema che decide se  far entrare il VIP o no.
            // (3) Se non è in lista, chiedigli se vuole pagare 20€ per entrare. Se dice "Sì", aggiungilo alla lista e scala i soldi da un portafoglio immaginario.

            List<string> ListaVip = new List<string>()
            {
                "marco", "luca", "anna", "alessia", "silvia"
            };

            Console.WriteLine("Quale è il tuo nome?");
            string risposta = Console.ReadLine().ToLower();

            if (ListaVip.Contains(risposta))
            {
                Console.WriteLine($"Nome '{risposta}' trovato in lista. Puoi entrare!");
            }
            else
            {
                Console.WriteLine("Nome non trovato in lista. Vuoi pagare 20€ per entrare?");
                string risposta2 = Console.ReadLine().ToLower();
                if(risposta2 == "sì" || risposta2 == "si" || risposta2 == "SI")
                {
                    int biglietto = 20;
                    int portafoglio = 100;
                    portafoglio = portafoglio - biglietto;
                    Console.WriteLine($"Perfetto, hai pagato {biglietto} e adesso {risposta} è in lista. Saldo disponibile: {portafoglio}");
                    ListaVip.Add(risposta);
                    
                    foreach(string nome in ListaVip) // <- Per stampare la lista aggiornata.
                    {
                        Console.WriteLine($"Nomi presenti in lista: {nome}");
                    }
                }else Console.WriteLine("Perfetto, allora vai via.");
                
            }         

  



        }
    }
}
