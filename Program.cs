int numero;
int numeroPar = 0;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("              Sequencia Par");
Console.WriteLine("Exibe os números pares entre 0 e o número digitado\n");
Console.ResetColor();

do
{
    Console.Write("Digite um número inteiro e positivo: ");
    Int32.TryParse(Console.ReadLine(), out numero);      
} 
while (numero <= 0);

while (numeroPar <= numero)
{
    Console.Write($"{numeroPar} ");
    numeroPar += 2;
}

