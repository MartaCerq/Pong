using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;
    bool bolafoilancada = false;
    float tempo = 0f;
    float cameraHeight ;
    int pontosesquerda = 0;
    int pontosdireita = 0;




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
        esperar2s();



       // Debug.Log(tempo);


        cameraHeight = 7.5f;


        if (transform.position.x >= cameraHeight) //bola toca parede da direita 
        {
            pontosesquerda += 1; //somar um ponto a pontuação atual do jogador 1
            Debug.Log("A pontuação é:");
            Debug.Log("1º Jogador " + pontosesquerda + "-" + pontosdireita + " 2º Jogador"); //imrpimir na consola pontuação
            bolafoilancada = false; //para voltar a lançar a bola


            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            tempo = 0f;
            esperar2s();

        }
        else if (transform.position.x <= -cameraHeight) //bola toca parede da esquerda
        {
            pontosdireita += 1; //somar um ponto a pontuação atual do jogador 2
            Debug.Log("O resultado é");
            Debug.Log("1º Jogador " + pontosesquerda + "-" + pontosdireita + " 2º Jogador"); //imrpimir na consola pontuação
            bolafoilancada = false; //para voltar a lançar a bola

            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            tempo = 0f;
            esperar2s();
        }

    }

    void esperar2s ()
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


