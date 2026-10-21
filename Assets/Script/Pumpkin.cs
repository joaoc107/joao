
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.ColetarAbobora();

            Destroy(gameObject);
        }
    }
}
