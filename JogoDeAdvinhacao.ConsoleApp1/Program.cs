// See https://aka.ms/new-console-template for more information
using System;

using System.Security.Cryptography;

while (true  == true)
{
    Console.Clear();

    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Jogo De Adivinhação de Números");
    Console.WriteLine("-----------------------------------");

    int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

    Console.WriteLine("Digite um número entre 1 a 20: ");
    string? chute = Console.ReadLine();
    int numeroDigitado = Convert.ToInt32(chute);


    if (numeroDigitado == numeroAleatorio)
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Parábens, você acertou!");
        Console.WriteLine("-----------------------------------");
    }
    else if (numeroDigitado > numeroAleatorio)
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("O numero digitado é maior que o numero secreto!");
        Console.WriteLine("-----------------------------------");
    }
    else
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("O número digitado foi menor que o número secreto!");
        Console.WriteLine("-----------------------------------");
    }

    Console.WriteLine("Deseja continuar? (S/N): ");
    string? opcaoContinuar = Console.ReadLine();

    if (opcaoContinuar.ToUpper() != "S")
    {
        Console.WriteLine("Programa finalizado!!");
        break;
    }
    

    Console.ReadLine();

}



