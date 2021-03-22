using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    float velocidade = 0.5f;

    [SerializeField]
    float paddleHeight = 1f;

    [SerializeField]
    KeyCode upKey = KeyCode.UpArrow;
    [SerializeField]
    KeyCode downKey = KeyCode.DownArrow;



    // Update is called once per frame
    void Update()
    {
    

        /*
         *  se tecla para cima permida
         *  então subir
         *  senão se tecla para baixo premida 
         *  então descer
         * 
         * 
         */

        /* 
         * mover a raquete
         */

        if (Input.GetKey(upKey))
        {

            transform.position += velocidade * Vector3.up * Time.deltaTime;

            // sobe 
        }

        else if (Input.GetKey(downKey))

        {
            transform.position += velocidade * Vector3.down * Time.deltaTime;

            // desce 
        }

        /*
         * verificar os limites ( com ifs)
         *

        float cameraHeight = Camera.main.orthographicSize;


        if(transform.position.y >= cameraHeight - 0.5f )
        {
            // variável para poder alterar o valor de .y no transform.position

            Vector3 positionAux = transform.position;
            positionAux.y = cameraHeight - 0.5f;
            transform.position = positionAux;

        }

        if ( transform.position.y <= -cameraHeight + 0.5f)
        {
            Vector3 positionAux = transform.position;
            positionAux.y = -cameraHeight + 0.5f;
            transform.position = positionAux;

        }
        
        /*
        *verificar os clips mas com (clamp)
        */

        float cameraHeight = Camera.main.orthographicSize;
        Vector3 positionAux = transform.position;
        positionAux.y = Mathf.Clamp (positionAux.y, -cameraHeight + (paddleHeight * 0.5f ), cameraHeight - (paddleHeight * 0.5f));
        transform.position = positionAux;

  
    }
}
