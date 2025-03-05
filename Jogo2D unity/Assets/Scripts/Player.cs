using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour

{
    public float speed = 5;
    public int jumpForce = 10;
    private Rigidbody2D rb;
   [SerializeField] Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Move();
        Jump();
    }
    void Move()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector3(1.882289f, 2.346054f, 0);
            animator.SetBool("Andar", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector3(-1.882289f, 2.346054f, 0);
            animator.SetBool("Andar", true);
        }

        else
        {
            animator.SetBool("Andar", false);
        }
        float moveInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

       

    }

    void Jump()

    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
   }
}

