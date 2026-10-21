
using UnityEngine;

public class GhostAbility : MonoBehaviour
{
    [Header("Configurações")]
    public KeyCode teclaHabilidade = KeyCode.K;

    [Header("Aparência")]
    public SpriteRenderer spriteRenderer;
    public Color corNormal = Color.white;
    public Color corIntangivel = Color.blue;

    private bool habilidadeAtiva = false;

    void Update()
    {
        if (Input.GetKeyDown(teclaHabilidade))
        {
            habilidadeAtiva = !habilidadeAtiva;

            AtualizarHabilidade();
        }
    }

    void AtualizarHabilidade()
    {
        // Altera a cor do fantasma
        spriteRenderer.color = habilidadeAtiva
            ? corIntangivel
            : corNormal;

        // Ignora a colisão com paredes
        Physics2D.IgnoreLayerCollision(
            LayerMask.NameToLayer("Player"),
            LayerMask.NameToLayer("Wall"),
            habilidadeAtiva
        );
    }
}

