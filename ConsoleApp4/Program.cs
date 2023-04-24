double n1, n2;
string op;
Console.WriteLine("Digite Qual operãção deseja fazer:\n + Adição\n - Subtração\n * Multiplicação\n / Divisão");
op = Console.ReadLine();
Console.WriteLine("Digite o primeiro número:");
n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo número:");
n2 = Convert.ToDouble(Console.ReadLine());

switch (op)
{
    case "+":
        Console.WriteLine($"O Resultado de {n1} {op} {n2} = {n1 + n2}");
        break;
    case "-":
        Console.WriteLine($"O Resultado de {n1} {op} {n2} = {n1 - n2}");
        break;
    case "*":
        Console.WriteLine($"O resultado de {n1} {op} {n2} = {n1 * n2}");
        break;
    case "/":
        Console.WriteLine($"O Resultado de {n1} {op} {n2} = {n1 / n2}");
        break;
    default:
        Console.WriteLine("Digite uma operação válida");
        break;
}





