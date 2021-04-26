using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Columna : MonoBehaviour


{
    public float Speed;
       

    // Start is called before the first frame update
    void Start()
    {
        Speed = 3f;
        StartCoroutine("DestruirColumna");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime *  Speed);
    }
    IEnumerator DestruirColumna()
    {
        while (true)
        {
          
            if (transform.position.z <= -40f)
            {

                Destroy(this.gameObject);

            }
            yield return new WaitForSeconds(3f);
        }


    }
}
