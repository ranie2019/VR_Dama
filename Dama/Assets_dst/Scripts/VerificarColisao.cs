using UnityEngine;

public class VerificarColisao : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private bool colisaoDetectada = false;
    public float tempoAtivacao = 3f; // Tempo em segundos

    void Start()
    {
        // Obt�m o componente MeshRenderer do objeto associado a este script
        meshRenderer = GetComponent<MeshRenderer>();

        // Desativa o MeshRenderer no in�cio
        meshRenderer.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto com o qual estamos colidindo tem a tag "Black"
        if (other.gameObject.CompareTag("Black"))
        {
            Debug.Log("Colis�o detectada com um objeto Black!" + other.gameObject.name);

            // Ativa o MeshRenderer
            meshRenderer.enabled = true;
            colisaoDetectada = true;

            // Inicia a contagem regressiva para desativar o MeshRenderer ap�s o tempo especificado
            Invoke("DesativarMeshRenderer", tempoAtivacao);
        }
    }

    private void DesativarMeshRenderer()
    {
        // Desativa o MeshRenderer ap�s o tempo especificado
        meshRenderer.enabled = false;
        colisaoDetectada = false;
    }
}
