using UnityEngine;

/// <summary>
/// Classe que representa o comportamento da Torre em um ambiente 3D.
/// </summary>
public class Torre3D : MonoBehaviour
{
    /// <summary>
    /// M�todo que representa o movimento espec�fico da Torre em 3D.
    /// </summary>
    public void Mover()
    {
        // Exibe uma mensagem indicando o movimento vertical ou horizontal da torre
        Debug.Log("Torre move-se vertical ou horizontalmente em 3D.");
        // L�gica espec�fica de RV aqui
    }
}

/// <summary>
/// Classe principal do programa para a Torre.
/// </summary>
public class ProgramTorre : MonoBehaviour
{
    /// <summary>
    /// M�todo chamado no in�cio do jogo.
    /// </summary>
    void Start()
    {
        // Instancia um objeto da classe Torre3D
        Torre3D torre = new Torre3D();
        // Chama o m�todo Mover() para realizar o movimento da torre
        torre.Mover();
    }
}
