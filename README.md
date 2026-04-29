# Esercizi-CSharp-Basics
Nella seguente repository verranno caricati diversi esercizi e mini-progetti realizzati in C# per il consolidamento delle logiche di programmazione procedurale e della gestione dei dati.

## Sistema prenotazione voli
Simulazione di un software di biglietteria aerea.
**Logica:** Gestione della disponibilità posti tramite List<string>.
**Funzionalità:** Scelta del posto o assegnazione randomica in caso di mancata selezione. Controllo iterativo dello stato di occupazione.

## Gestione parcheggio
Applicazione console per il monitoraggio di un'aera di sosta.
**Logica:** Utilizzo di List<string> per gestire ingressi e uscite dinamiche.
**Funzionalità:** Verifica della capienza massima, rimozione di elementi specifici e aggiornamento dello stato libero/occupato in tempo reale.

## Distributore automatico
Simulazione di un'interfaccia per distributori automatici.
**Logica:** Gestione delle scorte tramite variabili contatore.
**Funzionalità:** Implementazione di cicli di acquisto continui e gestione dello stato "esaurito" con interruzione del servizio al raggiungimento dello zero.

## Sistema accessi VIP
Un filtro di sicurezza per la gestione degli ingressi in un locale.
**Logica:** Verifica della presenza di un nominativo all'interno di una lista predefinita.
**Funzionalità:** Gestione della case-sensitivity e normalizzazione dell'input utente.

## Cassa automatica
Simulatore di un punto vendita con generazione dinamica dei prezzi.
**Logica:** Creazione di uno scontrino virtuale con calcolo del totale e applicazione di sconti.
**Funzionalità:** Sincronizzazione di due liste parallele (prodotti e prezzi) e calcolo di percentuali su tipi di dato double per mantenere la precisione dei decimali. Inoltre, è stato creato un sistema di sconto automatico del 10% per spese superiori a 50€.

## Distributore di sigarette
Simulatore di un distributore di sigarette.
**Logica:** Gestione del flusso di acquisto tramite validazione dell'anno di nascita e controllo dinamico della transazione economica.
**Funzionalità:** Utilizzo di una "Hashtable" per mappare le coppie prodotto-prezzo e implementazione di un sistema di "rabbocco" del credito tramite cicli "while". Il programma gestisce il calcolo del resto in tempo reale in include filtri di sicurezza per bloccare l'accesso ai minori e prevenire errori di inserimento (casting di tipi "double" e "char").

## Strumenti
**Linguaggio:** C#.
**Piattaforma:** Visual Code.
