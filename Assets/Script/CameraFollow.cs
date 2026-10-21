
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Configurações")]
    public Transform jogador;
    public float velocidade = 5f;

    [Header("Posição")]
    public Vector3 deslocamento = new Vector3(0, 0, -10);

    void LateUpdate()
    {
        if (jogador == null)
            return;

        Vector3 posicaoDesejada = jogador.position + deslocamento;

        transform.position = Vector3.Lerp(
            transform.position,
            posicaoDesejada,
            velocidade * Time.deltaTime
        );
    }
}

