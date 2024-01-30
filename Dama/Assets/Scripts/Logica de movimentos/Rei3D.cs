using UnityEngine;

/// <summary>
/// Classe que representa o comportamento do Rei em um ambiente 3D.
/// </summary>
public class Rei3D : MonoBehaviour
{
    /// <summary>
    /// M�todo que representa o movimento espec�fico do Rei em 3D.
    /// </summary>
    public void Mover()
    {
        // Exibe uma mensagem indicando o movimento do rei em qualquer dire��o, mas apenas uma casa por vez
        Debug.Log("Rei move-se para qualquer dire��o, mas apenas uma casa por vez em 3D.");
        // L�gica espec�fica de RV aqui
    }
}

/// <summary>
/// Classe principal do programa para o Rei.
/// </summary>
public class ProgramRei : MonoBehaviour
{
    /// <summary>
    /// M�todo chamado no in�cio do jogo.
    /// </summary>
    void Start()
    {
        // Instancia um objeto da classe Rei3D
        Rei3D rei = new Rei3D();
        // Chama o m�todo Mover() para realizar o movimento do rei
        rei.Mover();
    }
}
