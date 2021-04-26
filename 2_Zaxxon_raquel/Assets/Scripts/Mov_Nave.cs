using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Nave : MonoBehaviour
{
    
    float desplX;
    float desplY;
    float moveSpeed; 
    //Variable que determina si estoy en los márgenes
    bool inMarginMoveX = true;
    bool inMarginMoveY = true;



 
    // Start is called before the first frame update
    void Start()
    {
        
        moveSpeed = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        MoverNave(); 
    }

    void MoverNave()
    {
        desplX = Input.GetAxis("Horizontal");
        desplY = Input.GetAxis("Vertical");

        float posX = transform.position.x;
        float posY = transform.position.y;

        if ((posX > -9.5 || desplX > 0) && (posX <9.5 || desplX <0))
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed* desplX);
        }
       
         

       

        if ((posY > 0.5 || desplY > 0) && (posY < 2.5 || desplY < 0))
        {
            transform.Translate(Vector3.up * Time.deltaTime * moveSpeed * desplY);
        }

            
    }

    
}

