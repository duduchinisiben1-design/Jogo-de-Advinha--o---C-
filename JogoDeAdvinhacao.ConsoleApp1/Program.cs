// See https://aka.ms/new-console-template for more information

using System;

using System.Security.Cryptography;

while (true == true)
{
    int[] numerosDigitados = new int[100];
    int contadorDeNumerosDigitados = 0;
    int pontuacao = 100;

    Console.Clear();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Jogo De Adivinhação de Números");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Escolha o nível de didiculdade:");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("1 - Fácil (10 tentativas)");
    Console.WriteLine("2 - Médio (5 tentativas)");
    Console.WriteLine("3 - Difícil (3 tentativas)");

    Console.WriteLine("Digite sua escolha: ");
    string? dificuldade = Console.ReadLine();

    int numeroMaximo;
    int tentativasMaximas;

    switch (dificuldade)
    {
        case "1":
            numeroMaximo = 20;
            tentativasMaximas = 10;
            break;
        case "2":
            numeroMaximo = 50;
            tentativasMaximas = 5;
            break;
        case "3":
            numeroMaximo = 100;
            tentativasMaximas = 3;
            break;
        default:
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Por Favor, selecione uma dificuldade válida");
            Console.WriteLine("Clique ENTER para prosseguir...");
            Console.ReadLine();
            continue;
    }

    int numeroAleatorio = RandomNumberGenerator.GetInt32(1, numeroMaximo + 1);



    for (int tentativas = 1; tentativas <= tentativasMaximas; tentativas++)
    {
        Console.Clear();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"Tentiva {tentativas} de {tentativasMaximas}");
        Console.WriteLine("-------------------------------------");

        Console.WriteLine($"Digite um número entre 1 e {numeroMaximo}: ");
        string? chute = Console.ReadLine();

        int numeroDigitado = Convert.ToInt32(chute);

        if (contadorDeNumerosDigitados < numerosDigitados.Length)
        {
            numerosDigitados[contadorDeNumerosDigitados] = numeroDigitado;

            contadorDeNumerosDigitados++;
        }
        bool numeroRepitido = false;

        for (int contadorNumeros = 0; contadorNumeros < numerosDigitados.Length; contadorNumeros++)
        {
            if (numerosDigitados[contadorNumeros] == numeroDigitado)
            {
                numeroRepitido = true;
                break;
            }
        }

        if (numeroRepitido == true)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Você já digitou esse número, tente novamente.");
            Console.WriteLine("--------------------------------");
            Console.Write("Clique ENTER para prosseguir...");
            Console.ReadLine();

            tentativas--;

            continue;
        }

        if (numeroDigitado == numeroAleatorio)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Parábens, você acertou!");
            Console.WriteLine("-----------------------------------");
            break;
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

        int diferencaNumerica = Math.Abs(numeroAleatorio - numeroDigitado);

        if (diferencaNumerica >= 10)
        {
            pontuacao -= 100;
        }
        else if (diferencaNumerica >= 5)
        {
            pontuacao -= 50;
        }
        else
        {
            pontuacao -= 20;
        }

        if (tentativas == tentativasMaximas)
        {
            Console.WriteLine($"Você usou toda as suas tentativas! o numero era {numeroAleatorio}");
            Console.WriteLine("--------------------------------------------");
            break;
        }

            Console.WriteLine("sua pontuação é: " + pontuacao);
            Console.WriteLine("-----------------------------------");
            Console.Write("Clique ENTER para prosseguir...");
            Console.ReadLine();



    }

    Console.WriteLine("Deseja continuar? (S/N): ");
    string? opcaoContinuar = Console.ReadLine();

    if (opcaoContinuar?.ToUpper() != "S")
    {
        Console.WriteLine("Programa finalizado!!");
        break;
    }
}



