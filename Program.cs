// See https://aka.ms/new-console-template for more information

//array
string[] cibi_preferiti = {
"tiramisù",
"salmone",
"pizza",
"pasta",
"sushi",
"carciofi",
"roast beef",
"torta",
"tortellini",
};

//lunghezza array
int lungArray = cibi_preferiti.Length;


//EXTRA - BONUS
bool verify = false;
string userCibo;

do
{
    //chiedere all'utente il suo cibo preferito
    Console.WriteLine("\nScrivi il tuo cibo preferito");

    userCibo = Console.ReadLine();

    //verificare che il cibo inserito dall'utente sia inserito nel array
    for (int i = 0; i < lungArray; i++)
    {
        if (cibi_preferiti[i] == userCibo)
        {
            verify = true;
        }
    }

    if (!verify)
    {
        Console.WriteLine("\nIl cibo inserito non è in classifica, riprova!");
    }

} while (!verify);


//generare un numero random
Random rnd = new Random();
int cpuNumber = rnd.Next(lungArray);


//stampa elementi array
Console.WriteLine($"La tua classifica contiene {lungArray} cibi:");

for(int i = 0; i < lungArray; i++)
{
    if (cibi_preferiti[i] == userCibo && i == cpuNumber)
    {
        Console.WriteLine($"{i + 1} - {cibi_preferiti[i]} - Abbiamo gli stessi gusti");
    }
    else if (cibi_preferiti[i] == userCibo)
    {
        Console.WriteLine($"{i + 1} - {cibi_preferiti[i]} --> Questo è il tuo cibo preferito");
    }
    else if (i == cpuNumber)
    {
        Console.WriteLine($"{i + 1} - {cibi_preferiti[i]} --> Questo è il mio cibo preferito");
    }
    else
    {
        Console.WriteLine($"{i + 1} - {cibi_preferiti[i]}");
    }
}

Console.WriteLine($"\nIl tuo cibo preferito è: {cibi_preferiti[0]}");
Console.WriteLine($"\nIl tuo cibo preferito ma non troppo è: { cibi_preferiti[lungArray - 1]}");


//------------BONUS
// metà array
int metaArray = lungArray / 2;

if(lungArray % 2 == 0)
{
    //array pari stampa due cibi
    Console.WriteLine($"\nCibo mediani: {cibi_preferiti[metaArray - 1]}, {cibi_preferiti[metaArray]}");
}
else
{
    //array dispari stampa il cibo a metà
    Console.WriteLine($"\nCibo mediani: {cibi_preferiti[metaArray]}");
}