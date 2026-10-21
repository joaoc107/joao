using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movimentação")]
    public float velocidade = 5f;
    public float forcaPulo = 7f;

    private Rigidbody2D rb;
    private bool noChao;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movimento = Input.GetAxisRaw("Horizontal");

        // Movimentação horizontal
        rb.linearVelocity = new Vector2(
            movimento * velocidade,
            rb.linearVelocity.y
        );

        // Virar o personagem
        // O sprite original está virado para a esquerda
        if (movimento > 0)
        {
            // Direita
            transform.localScale = new Vector3(
                -Mathf.Abs(transform.localScale.x),
                transform.localScale.y,
                transform.localScale.z
            );
        }
        else if (movimento < 0)
        {
            // Esquerda
            transform.localScale = new Vector3(
                Mathf.Abs(transform.localScale.x),
                transform.localScale.y,
                transform.localScale.z
            );
        }

        // Pulo
        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                forcaPulo
            );
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            noChao = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            noChao = false;
        }
    }
}



