Console.Clear();

//parte do "robô"
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Oii! Me diga seu nome para nos conhecermos!^^");
Console.ResetColor();

//parte do usuário
string nomezin = Console.ReadLine()!;

//parte do "robô"
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Olá {nomezin}!");
Console.ResetColor();