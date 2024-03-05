Console.WriteLine("podaj swoj wiek liczbą: ");
int age = int.Parse(Console.ReadLine());

if (age > 20 && age < 29)
{
    Console.WriteLine("Możesz zostac posłem");
    Console.WriteLine("Mozesz zostac premierem");
}
else if (age >= 29 && age < 35)
{
    Console.WriteLine("Możesz zostac senatorem");
    Console.WriteLine("Możesz zostac posłem");
    Console.WriteLine("Mozesz zostac premierem");
}
else if (age >= 35)
{
    Console.WriteLine("Możesz zostac senatorem");
    Console.WriteLine("Możesz zostac posłem");
    Console.WriteLine("Mozesz zostac premierem");
    Console.WriteLine("Możesz zostac prezydentem");
}
else
{
    Console.WriteLine("Jestes za młody");
}
