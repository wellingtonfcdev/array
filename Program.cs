int[] arrayCopia = new int[4];

arrayCopia[0] = 72;
arrayCopia[1] = 64;
arrayCopia[2] = 50;
arrayCopia[3] = 1;

//Copiando um array para outro
int[] arrayDobrado = new int[arrayCopia.Length * 2];
Array.Copy(arrayCopia, arrayDobrado, arrayCopia.Length);



int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

Console.WriteLine("percorrendo o array com o For");
for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
}

Console.WriteLine("\npercorrendo o array com o Foreach");
int contadorForeach = 0;
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
    contadorForeach++;
}