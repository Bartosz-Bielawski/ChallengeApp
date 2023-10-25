string name = "Ewa";
char gender = 'f';
var age = 33;

if (gender == 'f')
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    
}
else if (age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}