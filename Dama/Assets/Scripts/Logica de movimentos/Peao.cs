using UnityEngine;

public class Peao : MonoBehaviour
{
    // Representa o estado atual do tabuleiro de xadrez
    private char[,] tabuleiro = new char[,]
    {
        {'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R'},
        {'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P'},
        {'.', '.', '.', '.', '.', '.', '.', '.'},
        {'.', '.', '.', '.', '.', '.', '.', '.'},
        {'.', '.', '.', '.', '.', '.', '.', '.'},
        {'.', '.', '.', '.', '.', '.', '.', '.'},
        {'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p'},
        {'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r'}
    };

    // M�todo chamado na inicializa��o do script
    void Start()
    {
        ImprimirTabuleiro();
    }

    // M�todo para imprimir o estado atual do tabuleiro
    void ImprimirTabuleiro()
    {
        for (int linha = 0; linha < 8; linha++)
        {
            for (int coluna = 0; coluna < 8; coluna++)
            {
                Debug.Log(tabuleiro[linha, coluna] + " ");
            }
            Debug.Log("\n");
        }
    }

    // Verifica se o movimento do pe�o � v�lido
    bool MovimentoPeaoValido(Vector2 origem, Vector2 destino)
    {
        int origemColuna = (int)origem.x;
        int origemLinha = (int)origem.y;
        int destinoColuna = (int)destino.x;
        int destinoLinha = (int)destino.y;

        // Verifica se o movimento � na mesma coluna
        if (origemColuna != destinoColuna)
        {
            Debug.Log("Movimento inv�lido: Movimento deve ser na mesma coluna.");
            return false;
        }

        // Movimento simples para frente
        if (tabuleiro[origemLinha, origemColuna] == 'P' && origemLinha - destinoLinha == 1)
        {
            return true;
        }
        else if (tabuleiro[origemLinha, origemColuna] == 'p' && destinoLinha - origemLinha == 1)
        {
            return true;
        }

        // Movimento duplo inicial
        if (tabuleiro[origemLinha, origemColuna] == 'P' && origemLinha == 6 && origemLinha - destinoLinha == 2)
        {
            return true;
        }
        else if (tabuleiro[origemLinha, origemColuna] == 'p' && origemLinha == 1 && destinoLinha - origemLinha == 2)
        {
            return true;
        }

        Debug.Log("Movimento inv�lido: Condi��es n�o atendidas.");
        return false;
    }

    // Executa o movimento do pe�o se for v�lido
    bool MoverPeao(Vector2 origem, Vector2 destino)
    {
        int origemColuna = (int)origem.x;
        int origemLinha = (int)origem.y;
        int destinoColuna = (int)destino.x;
        int destinoLinha = (int)destino.y;

        if (MovimentoPeaoValido(origem, destino))
        {
            // Atualiza o tabuleiro com o novo estado ap�s o movimento
            tabuleiro[destinoLinha, destinoColuna] = tabuleiro[origemLinha, origemColuna];
            tabuleiro[origemLinha, origemColuna] = '.';

            Debug.Log("Movimento do pe�o executado com sucesso!");
            return true;
        }
        else
        {
            Debug.Log("Movimento do pe�o n�o executado: Movimento inv�lido.");
            return false;
        }
    }

    // M�todo chamado a cada quadro (frame) do jogo
    void Update()
    {
        // Exemplo de uso: Movimento inv�lido
        MoverPeao(new Vector2(4, 1), new Vector2(4, 3));

        // Exemplo de uso: Movimento v�lido
        MoverPeao(new Vector2(4, 1), new Vector2(4, 2));

        // Exibe o estado atual do tabuleiro
        ImprimirTabuleiro();
    }
}
