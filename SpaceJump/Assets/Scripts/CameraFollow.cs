using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se auto to script theloyme i kamera na akolouthei ton paikti mono otan anevenei pros ta panw
//Ayto tha to petixoyme ftiaxnontas mia metavliti target i opoia tha koitaei ton paikti otan anevainei pros ta panw 
//Episis gia na ginei swsto targeting toy paikti i kamera tha prepei na metakineite pros ta panw mono 
//Gia na ginei auto tha elexnoume kathe fora mesw tis update an to y toy paikti einai megalitero apo to y tis kameras
//Me ayto ton tropo i kamera tha metakineite mono pros ta panw
public class CameraFollow : MonoBehaviour
{
    public Transform target; //edw ginete reference ston paikti
    public float smoothness = 3f;
    private Vector4 currentVelocity;
    void LateUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            Vector4 newPosition = new Vector4(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPosition;
            
        }
        
    }
}
