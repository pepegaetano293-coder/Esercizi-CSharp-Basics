using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CorsoC_.Esercizi_CSharp_Basics.Distributore_di_sigarette
{
    internal class Distributore_di_sigarette
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // <- Introduzione simbolo "€"
            // Esercizio: Simulatore distributore di sigarette
            // Crea un progeramma che simuli il software di un distributore automatico. Il distributore
            // vende tre tipi di pacchetti con prezzi diversi e richiede la verifica dell'età

            // Requisiti del programma:
            // (1) Inizializzazione e verifica età.
            // (2) Menu prodotti e prezzi.
            // (3) Inserimento credito.
            // (4) Gestione del resto.

            Hashtable prodotti = new Hashtable
            {
                {"Sigarette Rosse", 6.00},
                {"Sigarette Blu", 5.50 },
                {"Tabacco", 8.00}
            };

            Console.WriteLine("Salve, benvenuto nel nostro distributore automatico di sigarette. Inserisci l'anno di nascita");
            DateTime dataLocal = DateTime.Now;
            int risposta = int.Parse(Console.ReadLine());
            int eta = dataLocal.Year - risposta;
            

            // Passo (1): Verifica età:

            if(eta <18 || risposta < 1900 || risposta > 2026)
            {
                Console.WriteLine("Non puoi acquistare sigarette perchè ancora non sei maggiorenne. Chiusura del programma in corso...");
                return;
            }
            else
            {

                Console.Clear();
                // Passo (2): Menù prodotti e prezzi:

                Console.WriteLine("Perfetto. I prodotti disponibili sono i seguenti:");
                foreach (DictionaryEntry sigarette in prodotti)
                {
                    Console.WriteLine($"{sigarette.Key} a {sigarette.Value}€.");
                }

                Console.WriteLine("Quale vuoi acquistare? (1) = Sigarette Rosse. (2) = Sigarette Blu. (3) = Tabacco.");

                char input = Console.ReadKey(true).KeyChar; // <- Con questo, l'utente inserirà il numero corrispondente al prodotto.

                if (input == '1' || input == '2' || input == '3')
                {
                    Console.WriteLine($"Hai inserito il numero {input}");
                }
                else
                {
                    Console.WriteLine("Opzione non valida. Chiusura del programma in corso...");
                    return;
                }
                // Passo (3): Inserimento credito:

                Console.WriteLine("Inserisci il credito: ");

                double credito = double.Parse(Console.ReadLine());
                double prezzoscelto = 0;
                if (input == '1')
                {
                    prezzoscelto = (double)prodotti["Sigarette Rosse"];
                }
                else if (input == '2')
                {
                    prezzoscelto = (double)prodotti["Sigarette Blu"];
                }
                else if (input == '3')
                {
                    prezzoscelto = (double)prodotti["Tabacco"];
                }
                    
                if (credito == prezzoscelto) // <- Ho specificato la "Value" presente in Hashtable fosse di tipo "double", in modo tale da poter effettuare le dovute operazioni.
                {
                    Console.WriteLine("Erogazione del prodotto in corso. Grazie e arrivederci.");
                    return;
                }
                else if (credito < prezzoscelto)
                {
                    Console.WriteLine("Credito non sufficiente. Vuoi inserire altri soldi? (1) = Sì. (2) = No");

                    char input2 = Console.ReadKey(true).KeyChar;
                    if (input2 == '2')
                    {
                        Console.WriteLine("Erogazione credito in corso...");
                        Console.Write($"Credito restituito: {credito}€");
                        return;
                    }
                    else if (input2 == '1')
                    {
                        while (credito < prezzoscelto)
                        {
                            Console.WriteLine("Inserisci credito: ");
                            double credito2 = double.Parse(Console.ReadLine());
                            credito = credito2 + credito;
                            if (credito < prezzoscelto)
                            {
                                Console.WriteLine($"Insufficiente. Mancano {prezzoscelto - credito}€");
                            }
                            else if (credito == prezzoscelto)
                            {
                                Console.WriteLine("Erogazione del prodotto in corso. Grazie e arrivederci.");
                                return;
                            }
                            else if (credito > prezzoscelto)
                            {
                                Console.WriteLine("Erogazione del resto in corso...");
                                double resto = credito - prezzoscelto;
                                Console.Write($"Resto erogato: {resto}€. Grazie e arrivederci.");
                            }
                        }

                    }
                }
                


            }
            


        }
    }
}
