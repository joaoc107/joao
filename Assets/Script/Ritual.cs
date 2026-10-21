
using UnityEngine;
using TMPro;

public class Ritual : MonoBehaviour
{
    [Header("Configurações")]
    public GameObject mensagemRitual;

    [Header("Transformação")]
    public SpriteRenderer spriteFantasma;
    public Sprite spriteSerVivo;

    private bool ritualConcluido = false;

    void Start()
    {
        mensagemRitual.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.Instance.TodasAboborasColetadas())
            {
                RealizarRitual();
            }
            else
            {
                mensagemRitual.SetActive(true);
                mensagemRitual.GetComponent<TMP_Text>().text =
                    "Você precisa coletar as 15 abóboras!";
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            mensagemRitual.SetActive(false);
        }
    }

    void RealizarRitual()
    {
        if (ritualConcluido) return;

        ritualConcluido = true;

        // Transforma o fantasma em um ser vivo
        spriteFantasma.sprite = spriteSerVivo;

        // Exibe mensagem de vitória
        mensagemRitual.SetActive(true);
        mensagemRitual.GetComponent<TMP_Text>().text =
            "Ritual realizado! Você voltou à vida!";

        Debug.Log("Pumpkin Quest concluído!");
    }
}

