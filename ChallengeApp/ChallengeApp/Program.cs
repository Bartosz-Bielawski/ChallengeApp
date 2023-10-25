string name = "Ewa";
char gender = 'f';
var age = 33;

if (gender == 'f')
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    
}
else
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}