using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed; // How fast Horizontal Movement is
    public float jumpSpeed; // How fast the Short Jump is

    enum jumpState {Grounded, hasJumped, hasDoubled};

    private jumpState state;
    private Rigidbody2D rb; // The player's rigidbody

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        state = jumpState.Grounded;
    }

    private void Update() {

        move(); 
        jump();
    }

    private void FixedUpdate() {

       
        
    }

    private void move() {

        float move = Input.GetAxis("Horizontal");

        Vector2 velocity = rb.velocity;
        velocity.x = move * moveSpeed;
        rb.velocity = velocity;

    }

    private void jump() {

        if (Input.GetKeyDown("up"))
        {
            print(state);
            if (state == jumpState.Grounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
                state = jumpState.hasJumped;

                
            }
            else if (state == jumpState.hasJumped)
            {
                print("works");
                rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
                state = jumpState.hasDoubled;
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        state = jumpState.Grounded;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
