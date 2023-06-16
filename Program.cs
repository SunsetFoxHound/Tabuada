Console.Write("Insira um número para ver sua tabuada: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int b = 0;
int produto;

while (b <= 10)
{
    produto = a * b;
    Console.WriteLine($"{a} x {b} = {produto}");
    b += 1;
}