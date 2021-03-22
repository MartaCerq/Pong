using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;
    bool bolafoilancada = false;
    float tempo = 0f;
  




    // Start is called before the first frame update
    void Start()
    {
        /*
                if(Random.value < 0.5f)
                {
                    GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.right;
                }
                else
                {
                    GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.left;
                }
                  */
        //GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitSphere;
    }

    // Update is called once per frame
    void Update()
    {


        if (bolafoilancada == false)
        {
            tempo = tempo + Time.deltaTime;

            if (tempo >= 2)
            {
                GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitCircle;
                bolafoilancada = true;
            }
        }

    }
}    


