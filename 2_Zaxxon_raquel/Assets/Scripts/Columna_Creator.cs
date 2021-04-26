using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columna_Creator : MonoBehaviour
{


    //Variable que contendré el prefab con el obstáculo
    [SerializeField] GameObject Columna;

    //Variable que tiene la posición del objeto de referencia
      Vector3 InitPos;

    //Variables para generar columnas de forma random
    private float randomNumber;
    Vector3 RandomPos;

    // Start is called before the first frame update
    void Start()
    {
        InitPos = transform.position;

        int n;
        float dist = 0f;

        for ( n=0; n <10; n ++)
        {
            dist = dist - 5f;
            CrearColumna(dist);
        }
       
        StartCoroutine("CorrutinaColumna");

         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CrearColumna(float z=0)
    {
        randomNumber = Random.Range(0f, 10f);
        Vector3 despl = new Vector3(randomNumber, 0, z);


        Instantiate(Columna, InitPos +despl, Quaternion.identity);
    }
    IEnumerator CorrutinaColumna()
    {
        for (; ; )
        {
            CrearColumna();
            
            yield return new WaitForSeconds(2f);
        }
    }
}

