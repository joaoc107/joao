
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Configurações")]
    public string nomeDaFase = "Pumpkin Quest";

    public void IniciarJogo()
    {
        SceneManager.LoadScene(nomeDaFase);
    }
}
