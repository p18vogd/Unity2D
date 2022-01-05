using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    // Se auto to script otan o paikths akoumpisei ton box collider pou valame na akolouthei tin kamera tote paei apeutheias
    // sto game over scene auto ginetai me tin parakatw sinartisi pou kaleite kathe fora pou ginetai collide tou paikti me ton box
    // collider kai me ton scene manager pou mas epitepei na allaksei to scene.
   void OnCollisionEnter2D(Collision2D collision)
   {
        
        SceneManager.LoadScene("DeathScene");
          
    }

}

