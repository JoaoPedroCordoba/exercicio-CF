double C, F;

Console.WriteLine("Digite a temperatura em Graus °C, por favor:");
C = Convert.ToDouble(Console.ReadLine());

F = C * 1.8 + 32;

Console.WriteLine($"A temperatura em °F é {F}°F");