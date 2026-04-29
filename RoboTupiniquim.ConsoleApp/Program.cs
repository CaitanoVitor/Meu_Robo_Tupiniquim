
int x = 1;
int y = 2;
char direcao = 'N';

string comandos = "EMEMEMEMM";

char[] instrucoes = comandos.ToCharArray();

for (int i = 0; i < instrucoes.Length; i++)
{

    char acao = instrucoes[i];


    if (acao == 'E')
    {
        if (direcao == 'N')
        {
            direcao = 'O';
        }
        else if (direcao == 'O')
        {
            direcao = 'S';
        }
        else if (direcao == 'S')
        {
            direcao = 'L';
        }
        else if (direcao == 'L')
        {
            direcao = 'N';
        }
    }
    else if (acao == 'D')
    {
        if (direcao == 'N')
        {
            direcao = 'L';
        }
        else if (direcao == 'L')
        {
            direcao = 'S';
        }
        else if (direcao == 'S')
        {
            direcao = 'O';
        }
        else if (direcao == 'O')
        {
            direcao = 'N';
        }
    }

    else if (acao == 'M')
    {
        if (direcao == 'N')
        {
            y = y + 1;
        }
        else if (direcao == 'S')
        {
            y = y - 1;
        }
        else if (direcao == 'L')
        {
            x = x + 1;
        }
        else if (direcao == 'O')
        {
            x = x - 1;
        }
    }
}

Console.WriteLine("Posição alcançada: " + x + " " + y + " " + direcao);
