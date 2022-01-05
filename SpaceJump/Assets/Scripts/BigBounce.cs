using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBounce : MonoBehaviour
{
    [SerializeField] private AudioSource sound; // auti i metavilti anaferete ston sound effect pou tha paizei otan o xristis pesei panw sto special platform
    
    
    void Start()
    {
        sound = GetComponent<AudioSource>(); 
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision) //kathe fora pou kanei collide me special platforms
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
           sound.Play(); // paikse to sound effect 
           collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 900); // auksise to velicity (*900)

        }
    }
}
