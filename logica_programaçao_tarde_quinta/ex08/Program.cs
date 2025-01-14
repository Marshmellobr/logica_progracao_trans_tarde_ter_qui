// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculo da Media");

Console.WriteLine("qual é o primeiro numero?");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("qual é o segundo numero?");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("qual é o terceiro numero?");
int num3 = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine($"A media dos numeros presentados: {num1 + num2 + num3 / 3 }" );
