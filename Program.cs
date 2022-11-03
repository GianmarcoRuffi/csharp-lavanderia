//Una lavanderia è aperta 24 ore su 24 e permette ai clienti di servizi autonomamente di 5 Lavatrici e 5 Asciugatrici.
//I clienti che usufruiscono delle macchine, possono effettuare diversi programmi di lavaggio e asciugatura ognuno con un costo diverso (in gettoni) e di una specifica durata. Ogni gettone costa 0.50 centesimi di euro e ogni lavaggio consuma detersivo e ammorbidente dai serbatoi della lavatrice. Ogni lavatrice può tenere fino ad un massimo di 1 litro di detersivo e 500ml di ammorbidente.
//I programmi di lavaggio hanno quindi queste caratteristiche
//Rinfrescante, costo di 2 gettoni, durata di 20 minuti, consumo di 20ml di detersivo e 5ml di ammorbidente.
//Rinnovante, costo di 3 gettoni, durata di 40 minuti, consumo di 40ml di detersivo e 10ml di ammorbidente.
//Sgrassante, costo di 4 gettoni, durata di 60 minuti, consumo di 60 ml di detersivo e 15ml di ammorbidente.
//Le asciugatrici invece hanno soltanto due programmi di asciugatura, rapido 2 gettoni e intenso 4 gettoni della durata di 30 minuti e 60 minuti rispettivamente.
//Si richiede di creare un sistema di controllo in grado di riportare lo stato della lavanderia, in particolare si vuole richiedere:
//1 - Lo stato generale di utilizzo delle macchine: un elenco di tutte le macchine che semplicemente dica quali sono in funzione e quali non lo sono (in lavaggio / asciugatura oppure ferme)
//2 - Possa essere richiesto il dettaglio di una macchina: Tutte le informazioni relative alla macchina, nome del macchinario, stato del macchinario (in funzione o no), tipo di lavaggio in corso, quantità di detersivo presente (se una lavatrice), durata del lavaggio, tempo rimanente alla fine del lavaggio.
//3 - l’attuale incasso generato dall’utilizzo delle macchine.

using System;

// oggetti macchine

Lavatrice lavatrice1 = new Lavatrice("Lavatrice 1");
Lavatrice lavatrice2 = new Lavatrice("Lavatrice 2");
Lavatrice lavatrice3 = new Lavatrice("Lavatrice 3");
Lavatrice lavatrice4 = new Lavatrice("Lavatrice 4");
Lavatrice lavatrice5 = new Lavatrice("Lavatrice 5");


Asciugatrice asciugatrice1 = new Asciugatrice("Asciugatrice 1", true);
Asciugatrice asciugatrice2 = new Asciugatrice("Asciugatrice 2", true);
Asciugatrice asciugatrice3 = new Asciugatrice("Asciugatrice 3", false);
Asciugatrice asciugatrice4 = new Asciugatrice("Asciugatrice 4", false);
Asciugatrice asciugatrice5 = new Asciugatrice("Asciugatrice 5", false);

// creazione classe lavatrice

public class Lavatrice
{
    //costruttore
    public Lavatrice(string nome)
    {
        Nome = nome;
        Random random = new Random();
        var randomBool = random.Next(2) == 1; // 0 = false, 1 = true;
        InFunzione = randomBool;
        QuantitaDetersivo = random.Next(1001);
        QuantitaAmmorbidente = random.Next(501);
        IncassoTotale = random.Next(501) * 0.50f;
    }

    //properties
    public string Nome { get; }
    public bool InFunzione { get; }
    public int QuantitaDetersivo { get; }
    public int QuantitaAmmorbidente { get; }
    public float IncassoTotale { get; }
}

//creazione classe asciugatrice
public class Asciugatrice
{
    //costruttore
    public Asciugatrice(string nome, bool inFunzione)
    {
        Nome = nome;
        Random random = new Random();
        InFunzione = inFunzione;
        IncassoTotale = random.Next(1, 101) * 0.50f;
    }

    //properties
    public string Nome { get; }
    public bool InFunzione { get; }
    public float IncassoTotale { get; }
}
