/*Objetivo do Jogo: O jogador e o computador competem em uma corrida virtual. Cada um rola um dado virtua
(geração de números aleatórios) para avançar em uma pista. O primeiro a alcançar ou ultrapassar a linha d
chegada vence.

Regras e Funcionalidades:
    1. Pista:
    ○ A pista é representada por uma linha numérica (ex.: de 0 a 30).
    ○ O jogador e o computador começam na posição 0.
    2. Turnos:
    ○ O jogador e o computador alternam turnos para rolar um dado (gerar um número aleatório
    entre 1 e 6).
    ○ O número gerado é somado à posição atual do competidor.
    ○ O jogo exibe a posição atual do jogador e do computador após cada rodada.
    3. Condição de Vitória:
    ○ O primeiro competidor a alcançar ou ultrapassar a posição final (ex.: 30) vence o jogo.
    4. Interação:
    ○ O jogador rola o dado pressionando uma tecla (ex.: Enter).
    ○ O computador rola o dado automaticamente no seu turno.

Dificuldades e Conceitos Envolvidos:
● Geração de números aleatórios: Para simular o lançamento do dado.
● Estruturas de repetição: Para controlar os turnos dos competidores.
● Condicionais: Para verificar eventos especiais e a condição de vitória.
● Interação com o usuário: Para permitir que o jogador role o dado.
● Lógica de turnos: Alternar entre o jogador e o computador.

Eventos Especiais:
5. Para tornar o jogo mais interessante, algumas posições na pista podem ter eventos especiais:
○ Avanço extra: Se o competidor parar em uma posição específica (ex.: 5, 10, 15), ele avança +3
casas.
○ Recuo: Se o competidor parar em outra posição específica (ex.: 7, 13, 20), ele recua -2 casas.
○ Rodada extra: Se o competidor tirar 6 no dado, ele ganha uma rodada extra.
*/

int linhaChegada = 30;
int casaJogador = 0;
int casaCPU = 0;

Random aleatorio = new Random();

Console.WriteLine("--------------------------");
Console.WriteLine("***** JOGO DOS DADOS *****");
Console.WriteLine("--------------------------");
Console.ReadLine();

while (casaJogador < linhaChegada && casaCPU < linhaChegada)
{
    //usuario

    Console.WriteLine("Sua vez do USUARIO jogar!");
    Console.WriteLine("Para rolar os dados, pressione ENTER");
    Console.ReadLine();

    int dadosJogador = aleatorio.Next(1, 7);
    Console.WriteLine("--------------------------");
    Console.WriteLine($"Na sua jogada você tirou: {dadosJogador}");
    Console.ReadLine();

    casaJogador += dadosJogador;

    Console.WriteLine($"A casa em que o USUARIO esta é: {casaJogador}");
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

        Console.WriteLine($"A casa em que o USUARIO esta é: {casaJogador}");
        Console.WriteLine("--------------------------");
    }

    if (casaJogador == 5 || casaJogador == 10 || casaJogador == 15)
    {
        Console.WriteLine("Sorte, pode PULE mais 3 casas!");
        casaJogador += 3;
    }

    else if (casaJogador == 7 || casaJogador == 13 || casaJogador == 20)
    {
        Console.WriteLine("Que azar, VOLTE duas casas!");
        casaJogador -= 2;
    }

    if (casaJogador >= linhaChegada)
        break;

    // CPU
    Console.WriteLine("--------------------------");
    Console.WriteLine("Agora é a vez da CPU!");

    int dadosCPU = aleatorio.Next(1, 7);
    Console.WriteLine($"CPU tirou: {dadosCPU}");
    Console.ReadLine();

    casaCPU += dadosCPU;

    Console.WriteLine($"A casa em que a CPU esta é: {casaCPU}");
    Console.WriteLine("--------------------------");

    while (dadosCPU == 6)
    {
        Console.WriteLine("A CPU tirou 6, vai jogar novamente!");

        dadosCPU = aleatorio.Next(1, 7);
        Console.WriteLine($"CPU você tirou: {dadosCPU}");

        casaCPU += dadosCPU;

        Console.WriteLine($"A casa em que a CPU esta é: {casaCPU}");
        Console.WriteLine("--------------------------");
    }

    if (casaCPU == 5 || casaCPU == 10 || casaCPU == 15)
    {
        Console.WriteLine("Sorte, pode PULE mais 3 casas!");
        casaCPU += 3;
    }

    else if (casaCPU == 7 || casaCPU == 13 || casaCPU == 20)
    {
        Console.WriteLine("Que azar, VOLTE duas casas!");
        casaCPU -= 2;
    }

    if (casaCPU >= linhaChegada)
        break;
}

if (casaJogador >= linhaChegada)
{
    Console.WriteLine("O usuário VENCEU, PARABENS!");
}
else if (casaCPU >= linhaChegada)
{
    Console.WriteLine("Que pena voce PERDEU, a CPU venceu!");
}

Console.ReadLine();
return;

