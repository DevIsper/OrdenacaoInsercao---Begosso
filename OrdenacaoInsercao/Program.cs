using System;

int[] vetor = { 6, 5, 3, 4, 2, 1};

Console.WriteLine("INSERTION SORT VISUAL - PASSO A PASSO\n");

Console.Write("Lista original: ");
Console.WriteLine($"[{string.Join(", ", vetor)}]");
Console.WriteLine(new string('=', 50));

for (int i = 1; i < vetor.Length; i++)
{
    int chave = vetor[i];
    int j = i - 1;

    Console.WriteLine($"\n--- Passo {i} ---");
    Console.WriteLine($"Chave atual: {chave} (posição {i})");

    int[] parteOrdenada = new int[i];
    Array.Copy(vetor, 0, parteOrdenada, 0, i);
    int[] parteNaoOrdenada = new int[vetor.Length - i];
    Array.Copy(vetor, i, parteNaoOrdenada, 0, vetor.Length - i);

    Console.WriteLine($"Parte ordenada: [{string.Join(", ", parteOrdenada)}] | Parte não ordenada: [{string.Join(", ", parteNaoOrdenada)}]");
    Console.WriteLine($"Comparando {chave} com elementos da parte ordenada...");

    int deslocamentos = 0;
    int comparacoes = 0;

    while (j >= 0 && chave < vetor[j])
    {
        comparacoes++;
        Console.WriteLine($"  Comparação {comparacoes}: {chave} < {vetor[j]}? SIM → Deslocando {vetor[j]} para direita");

        vetor[j + 1] = vetor[j];
        deslocamentos++;
        j--;

        // Mostrar estado intermediário
        string[] estado = new string[vetor.Length];
        for (int k = 0; k < vetor.Length; k++)
        {
            if (k == j + 1)
                estado[k] = $"[{vetor[k]}]";
            else
                estado[k] = vetor[k].ToString();
        }
        Console.WriteLine($"  Estado após deslocamento: [{string.Join(", ", estado)}]");
    }

    // Caso não tenha entrado no while, mas houve comparação
    if (j >= 0 && comparacoes == 0)
    {
        comparacoes++;
        Console.WriteLine($"  Comparação {comparacoes}: {chave} < {vetor[j]}? NÃO → Mantém posição");
    }

    vetor[j + 1] = chave;

    Console.WriteLine($"\n✓ Inserindo {chave} na posição {j + 1}");
    Console.WriteLine($"✓ Total: {comparacoes} comparações, {deslocamentos} deslocamentos");

    // Mostrar vetor com destaque para a chave inserida
    string[] vetorDestacado = new string[vetor.Length];
    for (int k = 0; k < vetor.Length; k++)
    {
        if (k == j + 1)
            vetorDestacado[k] = $"*{chave}*";
        else
            vetorDestacado[k] = vetor[k].ToString();
    }

    Console.WriteLine($"✓ Lista atual: [{string.Join(", ", vetorDestacado)}]");
    Console.WriteLine(new string('-', 40));
}

Console.WriteLine("\n" + new string('=', 50));
Console.WriteLine($"LISTA FINAL ORDENADA: [{string.Join(", ", vetor)}]");
