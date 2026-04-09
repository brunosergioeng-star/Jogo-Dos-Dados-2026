
int linhaChegada = 30;
int casaJogador = 0;
int casaCPU = 0;

Random aleatorio = new Random();

Console.WriteLine("--------------------------");
Console.WriteLine("***** JOGO DOS DADOS *****");
Console.WriteLine("--------------------------");
Console.WriteLine("Pressione ENTER para iniciar o jogo!");
Console.WriteLine("--------------------------");
Console.ReadLine();

while (casaJogador < linhaChegada && casaCPU < linhaChegada)
{
    //usuario
    Console.Clear();
    Console.WriteLine("Vez do USUARIO jogar!");
    Console.WriteLine("Para rolar os dados, pressione ENTER");
    Console.ReadLine();

    int dadosJogador = aleatorio.Next(1, 7);
    Console.WriteLine("--------------------------");
    Console.WriteLine($"Na sua jogada você tirou: {dadosJogador}");
    Console.ReadLine();

    casaJogador += dadosJogador;

    Console.WriteLine($"A casa em que o USUARIO esta é: {casaJogador} de {linhaChegada}");
    Console.WriteLine("--------------------------");


    if (casaJogador >= linhaChegada)
        break;

    while (dadosJogador == 6)
    {
        Console.WriteLine("Sorte, você tirou 6! Pressione ENTER para jogar novamente!");
        Console.ReadLine();

        dadosJogador = aleatorio.Next(1, 7);
        Console.WriteLine($"Na sua nova jogada você tirou: {dadosJogador}");

        casaJogador += dadosJogador;

        Console.WriteLine($"A casa em que o USUARIO esta é: {casaJogador} de {linhaChegada}");
        Console.WriteLine("--------------------------");
    }

    if (casaJogador == 5 || casaJogador == 10 || casaJogador == 15)
    {
        Console.WriteLine("Sorte, pode PULAR mais 3 casas!");
        casaJogador += 3;
    }

    else if (casaJogador == 7 || casaJogador == 13 || casaJogador == 20)
    {
        Console.WriteLine("Que azar, VOLTE duas casas!");
        casaJogador -= 2;
    }

    if (casaJogador >= linhaChegada)
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine("O usuário VENCEU, PARABENS!");
        Console.WriteLine("Preassione ENTES para continuar...");
        Console.ReadLine();
        break;
    }


    // CPU
    Console.WriteLine("--------------------------");
    Console.WriteLine("Agora é a vez da CPU!");

    int dadosCPU = aleatorio.Next(1, 7);
    Console.WriteLine($"CPU tirou: {dadosCPU}");
    Console.ReadLine();

    casaCPU += dadosCPU;

    Console.WriteLine($"A casa em que a CPU esta é: {casaCPU} de {linhaChegada}");
    Console.WriteLine("--------------------------");

    while (dadosCPU == 6)
    {
        Console.WriteLine("A CPU tirou 6, vai jogar novamente!");

        dadosCPU = aleatorio.Next(1, 7);
        Console.WriteLine($"CPU você tirou: {dadosCPU}");

        casaCPU += dadosCPU;

        Console.WriteLine("--------------------------");
        Console.WriteLine($"A casa em que a CPU esta é: {casaCPU} de {linhaChegada}");
        Console.WriteLine("--------------------------");
    }

    if (casaCPU == 5 || casaCPU == 10 || casaCPU == 15)
    {
        Console.WriteLine("Sorte, pode PULAR mais 3 casas!");
        casaCPU += 3;
    }

    else if (casaCPU == 7 || casaCPU == 13 || casaCPU == 20)
    {
        Console.WriteLine("Que azar, VOLTE duas casas!");
        casaCPU -= 2;
    }

    if (casaCPU >= linhaChegada)
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Que pena voce PERDEU, a CPU venceu!");
        Console.WriteLine("Preassione ENTES para continuar...");
        Console.ReadLine();

        break;
    }
}

Console.ReadLine();
