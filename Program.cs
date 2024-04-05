
int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
}