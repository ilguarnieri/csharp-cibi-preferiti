// See https://aka.ms/new-console-template for more information

string[] cibi_preferiti = {
"Tiramisù",
"Salmone con crema di pistacchio",
"Pasta al forno",
"Carciofi ripieni",
"Roast beef",
"Torta al cioccolato",
"Orecchiette alle cime di rapa"
};

int lungArray = cibi_preferiti.Length;

Console.WriteLine($"La tua classifica contiene {lungArray} cibi:");

int k = 1;
for(int i = 0; i < lungArray; i++)
{
    Console.WriteLine($"{k} {cibi_preferiti[i]}");
    k++;
}

Console.WriteLine($"Il tuo cibo preferito è: {cibi_preferiti[0]}");
Console.WriteLine($"Il tuo cibo preferito ma non troppo è: { cibi_preferiti[lungArray - 1]}");

if(lungArray % 2 == 0)
{
    Console.WriteLine("pari");
}
else
{
    Console.WriteLine("dispari");
}