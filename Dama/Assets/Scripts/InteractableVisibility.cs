using UnityEngine;

public class InteractableVisibility : MonoBehaviour
{
    [Header("Configura��es")]
    public GameObject plane;  // O plano que voc� deseja tornar vis�vel
    public LayerMask interactableLayer;  // Camada do objeto interag�vel
    public float displayDuration = 3f;  // Dura��o em segundos para exibir o plano

    private bool isVisible = false;

    private void Start()
    {
        InicializarVisibilidade();  // Configura a visibilidade inicial
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifique se o objeto interag�vel entrou na zona de intera��o
        if (InteragivelEntrouNaZona(other.gameObject))
        {
            ExibirPlanoPorDuracao(displayDuration);  // Exiba o plano por um determinado tempo
            Debug.Log("Objeto detectado");
        }
    }

    private bool InteragivelEntrouNaZona(GameObject otherObject)
    {
        // Verifica se o objeto est� na camada correta
        return otherObject.layer == interactableLayer;
    }

    private void ExibirPlanoPorDuracao(float duracao)
    {
        if (PodeExibirPlano() && !isVisible)
        {
            ConfigurarVisibilidadeDoPlano(true);

            // Use uma coroutine para aguardar um determinado tempo antes de tornar o plano invis�vel novamente
            StartCoroutine(EsconderAposAtraso(duracao));
        }
    }

    private System.Collections.IEnumerator EsconderAposAtraso(float atraso)
    {
        yield return new WaitForSeconds(atraso);

        // Torna o plano invis�vel ap�s o tempo especificado
        if (PodeExibirPlano() && isVisible)
        {
            ConfigurarVisibilidadeDoPlano(false);
        }
    }

    private void InicializarVisibilidade()
    {
        ConfigurarVisibilidadeDoPlano(false);
    }

    private bool PodeExibirPlano()
    {
        return plane != null && !isVisible;
    }

    private void ConfigurarVisibilidadeDoPlano(bool visivel)
    {
        if (plane != null)
        {
            plane.SetActive(visivel);
            isVisible = visivel;
        }
    }
}
