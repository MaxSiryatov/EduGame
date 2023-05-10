using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Animator animator;
    public Vector2 movement;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        rb.velocity = new Vector2(movement.x, movement.y) * speed;
        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical",movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
}
