using UnityEngine;

/// <summary>
/// Classe que representa o comportamento do Bispo em um ambiente 3D.
/// </summary>
public class Bispo3D : MonoBehaviour
{
    /// <summary>
    /// M�todo que representa o movimento espec�fico do Bispo em 3D.
    /// </summary>
    public void Mover()
    {
        // Exibe uma mensagem indicando o movimento diagonal do bispo
        Debug.Log("Bispo move-se diagonalmente em 3D (considerando profundidade).");
        // L�gica espec�fica de RV aqui
    }
}

/// <summary>
/// Classe principal do programa para o Bispo.
/// </summary>
public class ProgramBispo : MonoBehaviour
{
    /// <summary>
    /// M�todo chamado no in�cio do jogo.
    /// </summary>
    void Start()
    {
        // Instancia um objeto da classe Bispo3D
        Bispo3D bispo = new Bispo3D();
        // Chama o m�todo Mover() para realizar o movimento do bispo
        bispo.Mover();
    }
}
