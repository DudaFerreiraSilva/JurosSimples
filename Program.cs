decimal capital, taxa, meses, juros, montante;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Juros simples (j)\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Capital [c] (R$): ");
capital = Convert.ToDecimal(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Taxa de juros [i] (%): ");
taxa = Convert.ToDecimal(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Tempo [t] (meses): ");
meses = Convert.ToDecimal(Console.ReadLine());
Console.ResetColor();

juros = capital * (taxa / 100) * meses;
montante = capital + juros;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nJuros.....: {juros:C2}");
Console.WriteLine($"Montante..: {montante:C2}");
Console.ResetColor();