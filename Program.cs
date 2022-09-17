decimal gastosMensais, valorAinvestir;
double dividendo;

Console.WriteLine("--- Vivendo de dividendos ---\n");

Console.WriteLine("Vivendo de dividendos ---\n");

Console.Write("Gastos mensais (em R$)....: ");
gastosMensais = Convert.ToDecimal(Console.ReadLine());

Console.Write("Rendimentos mensais (%)...: ");

dividendo= Convert.ToDouble(Console.ReadLine());

valorAinvestir = gastosMensais / Convert.ToDecimal(dividendo / 100);

Console.WriteLine($"\nPara receber {gastosMensais:C} por mês com rendimentos de {dividendo:N1}% voce precisa ter investido {valorAinvestir:C}.");