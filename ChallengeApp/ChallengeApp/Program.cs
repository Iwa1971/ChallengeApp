

string name = "Ewa";
bool kobieta = true;
int age = 30;

if (kobieta && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa lat 30");
}
else if (!kobieta && age < 30)
{
    Console.WriteLine("Niepelnoletni mezczyzna");  
}
else
{
    Console.WriteLine();
}
