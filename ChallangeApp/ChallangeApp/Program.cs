string name = "Michał";
string gender = "m";
int age = 25;

if (gender == "k")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (gender == "m" && age < 18 )
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}