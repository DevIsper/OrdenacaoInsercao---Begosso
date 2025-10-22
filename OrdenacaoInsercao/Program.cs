using System.Collections;

int[] vetor = { 3, 4, 2, 5, 3 };

for (var i = 1; i < vetor.Length; i++)
{
    var aux = vetor[i];
    var j = i - 1;

    while (j >= 0 && vetor[j] > aux)
    {
        vetor[j + 1] = vetor[j];
        j -= 1;
    }

    vetor[j + 1] = aux;
}

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine(vetor[i]);
}