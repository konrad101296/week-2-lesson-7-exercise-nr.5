Console.WriteLine("podaj swoj wiek liczbą: ");
int Wiek = int.Parse(Console.ReadLine());

if (Wiek > 20 && Wiek < 29)
{
    Console.WriteLine("Możesz zostac posłem");
    Console.WriteLine("Mozesz zostac premierem");
}
else if (Wiek >= 29 && Wiek < 35)
{
    Console.WriteLine("Możesz zostac senatorem");
    Console.WriteLine("Możesz zostac posłem");
    Console.WriteLine("Mozesz zostac premierem");
}
else if (Wiek >= 35)
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
