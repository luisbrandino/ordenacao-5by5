// 3 - Faça um programa que leia cinco numeros guarde-os num vetor e ordene-os de forma crescente em um novo vetor 

int[] numbers = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o {i + 1}º valor: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

int[] sortedNumbers = new int[5];

//Array.Copy(numbers, sortedNumbers, 5);

for (int i = 0; i < 5; i++)
{
    sortedNumbers[i] = numbers[i];
}

for (int i = 0; i < 5; i++)
{
    for (int j = i + 1; j < 5; j++)
    {
        if (sortedNumbers[j] < sortedNumbers[i])
        {
            int aux = sortedNumbers[i];
            sortedNumbers[i] = sortedNumbers[j];
            sortedNumbers[j] = aux;
        }
    }
}

Console.WriteLine("\nVetor ordenado:");

for (int i = 0; i < 5; i++)
{
    Console.Write($"{sortedNumbers[i]} ");
}