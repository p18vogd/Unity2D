using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f; 
    [SerializeField] private AudioSource jump; // anafora sto sound effect

    void Start()
    {
        jump = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision) //otan kanei collide me ena platform o paiktis
    {
        if (collision.relativeVelocity.y <= 0f) // elenxos apo poio aksona erxetai o paiktis
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null) // kai oxi null
            {
                jump.Play(); // paikse to sound effect kai auksise to y velocity
                Vector2 velocity = rb.velocity;
                velocity.y =jumpForce;
                rb.velocity = velocity;
            }

        }
    

      
    }
    
}
