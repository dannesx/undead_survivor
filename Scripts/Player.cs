using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 moveInput;
    public float speed;
    
    Rigidbody2D rb;
    SpriteRenderer sprite;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate(){
        Vector2 movement = moveInput.normalized * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);
    }
}
