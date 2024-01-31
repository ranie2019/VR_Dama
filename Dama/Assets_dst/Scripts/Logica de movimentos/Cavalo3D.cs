using UnityEngine;

/// <summary>
/// Classe que representa o comportamento do Cavalo em um ambiente 3D.
/// </summary>
public class Cavalo3D : MonoBehaviour
{
    /// <summary>
    /// M�todo que representa o movimento espec�fico do Cavalo em 3D.
    /// </summary>
    public void Mover()
    {
        // Exibe uma mensagem indicando o movimento em L do cavalo
        Debug.Log("Cavalo move-se em L em 3D.");
        // L�gica espec�fica de RV aqui
    }
}

/// <summary>
/// Classe principal do programa para o Cavalo.
/// </summary>
public class ProgramCavalo : MonoBehaviour
{
    /// <summary>
    /// M�todo chamado no in�cio do jogo.
    /// </summary>
    void Start()
    {
        // Instancia um objeto da classe Cavalo3D
        Cavalo3D cavalo = new Cavalo3D();
        // Chama o m�todo Mover() para realizar o movimento do cavalo
        cavalo.Mover();
    }
}
