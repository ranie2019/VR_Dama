using UnityEngine;

public class ColisaoTrigger : MonoBehaviour
{
    // Este m�todo � chamado quando o objeto entra em um trigger
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou no trigger est� na camada "Interactable"
        if (other.gameObject.layer == LayerMask.NameToLayer("Interactable"))
        {
            // Exibe uma mensagem no console confirmando a colis�o
            Debug.Log("Colis�o detectada com o objeto Interactable: " + other.gameObject.name);
        }
    }
}
