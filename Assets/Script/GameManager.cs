
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Abóboras")]
    public int totalAboboras = 15;
    private int aboborasColetadas = 0;

    [Header("Interface")]
    public TMP_Text textoContador;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        AtualizarContador();
    }

    public void ColetarAbobora()
    {
        aboborasColetadas++;

        AtualizarContador();
    }

    void AtualizarContador()
    {
        textoContador.text = "Abóboras: " +
            aboborasColetadas + "/" + totalAboboras;
    }

    public bool TodasAboborasColetadas()
    {
        return aboborasColetadas >= totalAboboras;
    }
}


