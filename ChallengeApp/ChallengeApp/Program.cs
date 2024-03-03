

string name = "Ewa";
bool woman = true;
int age = 30;

if (woman && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa lat 30");
}
else if (!woman && age < 18)
{
    
  Console.WriteLine("Niepelnoletni mezczyzna");  
}

