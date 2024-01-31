using UnityEngine;

public class ChessManager : MonoBehaviour
{
    public enum PlayerTurn
    {
        Player1,
        Player2
    }

    public PlayerTurn currentPlayerTurn = PlayerTurn.Player1;

    // Adicione refer�ncias �s pe�as e outros elementos necess�rios
    public GameObject[] player1Pieces;
    public GameObject[] player2Pieces;

    private void Start()
    {
        // Inicie o jogo com o turno do Jogador 1
        SwitchTurn(PlayerTurn.Player1);
    }

    private void Update()
    {
        // Aqui voc� pode adicionar l�gica para o input do jogador, movimenta��o de pe�as, etc.
        // Certifique-se de verificar o turno atual antes de permitir movimentos.
        if (Input.GetMouseButtonDown(0))
        {
            // Adicione l�gica de sele��o/movimento de pe�as aqui
            // Certifique-se de verificar o turno antes de permitir que o jogador mova suas pe�as.
            MovePiece();
        }
    }

    private void MovePiece()
    {
        // Adicione l�gica para mover a pe�a
        // Aqui voc� pode verificar se a pe�a selecionada pertence ao jogador cujo turno � atual.
        // Certifique-se de desativar ou bloquear as pe�as do jogador advers�rio durante este turno.

        // Exemplo (certifique-se de substituir pelos seus pr�prios scripts/l�gica):
        // Se for o turno do Jogador 1, mova as pe�as do Jogador 1 e bloqueie as do Jogador 2.
        if (currentPlayerTurn == PlayerTurn.Player1)
        {
            MovePlayerPieces(player1Pieces);
            BlockPlayerPieces(player2Pieces);
        }
        // Se for o turno do Jogador 2, mova as pe�as do Jogador 2 e bloqueie as do Jogador 1.
        else if (currentPlayerTurn == PlayerTurn.Player2)
        {
            MovePlayerPieces(player2Pieces);
            BlockPlayerPieces(player1Pieces);
        }

        // Ap�s o movimento, troque o turno.
        SwitchTurn((currentPlayerTurn == PlayerTurn.Player1) ? PlayerTurn.Player2 : PlayerTurn.Player1);
    }

    private void MovePlayerPieces(GameObject[] pieces)
    {
        // Adicione l�gica para mover as pe�as do jogador atual.
        foreach (var piece in pieces)
        {
            // Simplesmente mova a pe�a no eixo Y (altura) como exemplo.
            piece.transform.Translate(Vector3.up * 2.0f, Space.World);
        }
    }

    private void BlockPlayerPieces(GameObject[] pieces)
    {
        // Adicione l�gica para bloquear as pe�as do jogador advers�rio.
        foreach (var piece in pieces)
        {
            // Adicione l�gica espec�fica para bloquear/desativar as pe�as (por exemplo, desativando os colliders).
            piece.GetComponent<Collider>().enabled = false;
        }
    }

    private void SwitchTurn(PlayerTurn newTurn)
    {
        // Troque o turno e fa�a outras atualiza��es necess�rias.
        currentPlayerTurn = newTurn;

        // Exemplo: Atualize a interface do usu�rio, exiba mensagens de turno, etc.
        Debug.Log("� o turno do Jogador " + ((currentPlayerTurn == PlayerTurn.Player1) ? "1" : "2"));
    }
}
