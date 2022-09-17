// See https://aka.ms/new-console-template for more information

//---------SNACK 1

//L'utente inserisce due numeri in successione
/* Console.Write("Inserisci un numero");
int Numero1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Inserisci un altro numero");
int Numero2 = Convert.ToInt32(Console.ReadLine());

if (Numero1 > Numero2)
{
   Console.WriteLine("Il numero maggiore tra i due è {0}", Numero1);
}
else
{
   Console.WriteLine("Il numero maggiore tra i due è {0}", Numero2);
}
*/


//---------SNACK 2

//L'utente inserisce due parole in successione
/*Console.Write("Inserisci una parola");
string Parola1 = Console.ReadLine();

Console.Write("Inserisci un altra parola");
string Parola2 = Console.ReadLine();

if (Parola1.Length < Parola2.Length)
{
    Console.WriteLine("La parola più corta è {0}", Parola1);
}
else
{
    Console.WriteLine("La parola più corta è {0}", Parola2);
}
*/


//-----------SNACK 3

//L'utente inserisce 1 numero per 10 volte
/*
int sum = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write("Inserisci un numero");
    int numeriUtente = Convert.ToInt32(Console.ReadLine());
    sum = sum + numeriUtente;
}

Console.WriteLine(sum);
*/


//----------SNACK 4

//Calcola la somma e la media dei numeri da 2 a 10

/*int[] arrayNumeri = new int[9] { 2, 3, 4, 5, 6 , 7, 8, 9, 10 };

int sum = 0; 

for (int i = 0; i < arrayNumeri.Length; i++)
{
    Console.WriteLine("La somma dei numeri è ", sum += arrayNumeri[i] );
}
*/


//----------SNACK 5

//chiedi all' utente di inserire un numero

/*Console.WriteLine("inserisci un numero");
int Numero = Convert.ToInt32(Console.ReadLine());

//se il numero è pari stampa 
if (Numero == 2)
{
    Console.WriteLine("Il numero è pari");
}
//se è dispari scartalo
else if (Numero == 3)
{
    Console.WriteLine("Il numero è dispari");
}
*/


//------------SNACK 6

//chiedo all' utente il nome

/*string[] lista = {"Mario", "Luca", "Filippo", "Andrea", "Matteo"};

Console.WriteLine("Inserisci il tuo nome!");
string Utente = Convert.ToString(Console.ReadLine());

bool invitato = false;

for (int i = 0; i < lista.Length; i++)
{
    if (Utente == lista[i])
    {
        invitato = true;
    }
}

if (invitato)
{
    Console.WriteLine("ok sei invitato");
}
else
{
    Console.WriteLine("ops non sei invitato");
}
*/



//-----------SNACK 7
//crea un array vuoto
// 

/*int[] numeriDispari = new int[6];

for (int i = 0; i < numeriDispari.Length; i++)
{
    int numeroInserito = Convert.ToInt32(Console.ReadLine());

    if (numeroInserito % 2 != 0)
    {
        numeriDispari[i] = numeroInserito;
        i++;
    }
}
*/


//--------------SNACK 8
//crea un array 












//--------SNACK 12
//Scrivere una funzione per verificare se un numero è pari o dispari.
//Quindi chiedere un numero all'utente e comunicargli se è pari o dispari.


Console.WriteLine("inserisci un numero");
int numeroUtente = Convert.ToInt32(Console.ReadLine());

void VerificaPariDispari(int numero)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("Numero pari");
    }
    else
    {
        Console.WriteLine("Numero dispari");
    }
}

VerificaPariDispari(numeroUtente);
