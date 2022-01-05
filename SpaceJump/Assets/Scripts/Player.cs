using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[RequiredComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float movementSpeed = 8f; // taxitita me tin opoia o paiktis kinite
    public float movement = 0f; //
    Rigidbody2D rb; // edw kanoume mia anafora stin sinartisi Rigibody2D(parexete apo unity) gia na tin xrisimopoisoume pio katw
    public Text ScoreText; // metavliti text gia na emfanizei to score
    public float topScore = 0.0f; //metavliti pou tha apothikeuei to max score gia etsi wste to score na auksanete mono
    public Sprite left; //to aristero sprite toy astronauti
    public Sprite right; // to deksi sprite toy astronauti
    public Sprite still; // to default sprite toy astronauti
    private bool issStarted; // bool timi pou tha mas deiksei an o xristis pathse to space gia na ksekinisei to paixnidi
    public Text StartText; // metavliti text pou tha emfanizei minima stin othoni tou paikti prin ksekinisei to paixnidi

    //i parakatw sinartisi Start tha ektelestei prin ektelestei to prwto frame tou paixnidiou prin tin update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //kanoume mia anafora stin rigidbody
        rb.gravityScale = 0; // vazoume timi stin varitita 0 gia na min paisei o paiktis mexri o xristis na dwsei to space
        rb.velocity = Vector3.zero; 
        
    }

    // H update kaleite meta thn start kai ekteleite gia kathe frame toy paixnidiou
    void Update()
    {
        //sto parakatw if kanoume elenxous an o xristis dwsei to space tote to paixnidi ksekinaei 
        if(Input.GetKeyDown(KeyCode.Space) && issStarted == false)
        {
            issStarted = true; // ginetai true gia na min mpei ksana sto block auto
            StartText.gameObject.SetActive(false); // to keimeno "Press space to start" eksafanizetai
            rb.gravityScale = 1; // o paiktis apoktaei varitita kai peftei panw sto prwto platform

        }
        if( issStarted == true)
        {
            // sta parakatw if blocks ginetai i allagi toy Sprite toy astronauti analoga me to input sto pliktrologio
            if(movement < 0)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = left; // allakse to sprite kai vale to left

            }
            else if (movement > 0)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = right; // vale to right 
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = still; // vale to akinito
            }
            
            //edw an h thesi y toy paikri einai megaliteri apo to top score
            if(rb.velocity.y > 0 && transform.position.y > topScore)
            {
                topScore = transform.position.y; // anathese tin thesi y sto topscore
            }
            ScoreText.text = "Score : " + Mathf.Round(topScore).ToString(); // emfanise to score stin othoni
         }
    
    }
    //i fixed update kaleite akrivws meta tin update 
    void FixedUpdate()
    {
        // an exei patisei o paiktis to space
        if(issStarted == true)
        {
            movement = Input.GetAxis("Horizontal"); // ta movements toy paikti
            rb.velocity = new Vector2(movement * movementSpeed , rb.velocity.y); // i taxita me tin opoia tha kineite 
        }
        
    }
  
    
}
