string name = "ewa";
string gender = "woman";
byte age = 31;

if (age < 30 & gender == "woman")
{
    Console.WriteLine("Kobieta ponizej 30");
}
else if (name == "ewa" & age == 33 & gender == "woman")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 18 & gender == "man")
{
    Console.WriteLine("Nieponoletni Facet");
}
else
{
    Console.WriteLine("Jestes Ufoludek");
}
