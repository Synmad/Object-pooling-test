using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float jumpForce;
    
    bool isGrounded;

    Rigidbody2D rb;

    public static Action onPlayerDie;

    private void Awake() { rb = GetComponent<Rigidbody2D>(); }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { Jump(); }
    }

    void Jump()
    {
        if (!isGrounded) { return; }

        rb.AddForce(Vector2.up * jumpForce);
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) { isGrounded = true; }

        if (collision.gameObject.CompareTag("Obstacle")) { Debug.Log("colision"); onPlayerDie?.Invoke(); }
    }
}
