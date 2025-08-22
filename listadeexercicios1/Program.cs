// See https://aka.ms/new-console-template for more information
Console.WriteLine("calculo da area de uma circunferencia:");

double raio, pi, area;

pi = 3.14;

Console.Write("digite o valor do raio:");
raio = Double.Parse(Console.ReadLine());
area = pi * (raio * raio);
Console.WriteLine("o valor da area e de: ." + area);

