// See https://aka.ms/new-console-template for more information
Console.WriteLine("salva malandro");
Console.WriteLine("qual é o primeiro numero?");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("qual é o segundo numero?");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("qual é o terceiro numero?");
int num3 = int.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("============");
Console.WriteLine(" resposta! ");
Console.WriteLine("===========");
Console.WriteLine($"O resultado da soma é: {num1 + num2 + num3}");
Console.WriteLine($"O resultado da  é subtração é: {num1 - num2 - num3}");
Console.WriteLine($"O resultado da divisão é: {num1 / num2 / num3}");
Console.WriteLine($"O resultado da multiplicação é: {num1 * num2 * num3}");

if (num2 != 0 && num3 !=0)
{
    Console.WriteLine("/ : " + (num1 / num2));
}
else
{
    Console.WriteLine("/ : divisao por 0 não pode ");
}
Console.WriteLine("Os numeros são parecidos?" + (num1 == num2));
Console.WriteLine("Os numeros 1 é maior que o segundo Numero? " + (num1 > num2));
Console.WriteLine("Os numeros 1 é menor que o segundo Numero? " + (num1 < num2));
Console.WriteLine("Os numeros 1 é menor igual o segundo Numero? " + (num1 <= num2));
Console.WriteLine("Os numeros 1 é maior igual o segundo Numero? " + (num1 >= num2));