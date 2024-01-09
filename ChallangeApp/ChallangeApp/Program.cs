string imię = "Michał";
string płeć = "m";
int wiek = 25;

if (płeć == "k")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (imię == "Ewa" && wiek == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (płeć == "m" && wiek < 18 )
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}