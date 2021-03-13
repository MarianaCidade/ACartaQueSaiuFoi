using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACartaQueSaiu : MonoBehaviour
{
    int numeroDaCarta;
    int numeroDoNaipe;
    string nomeDoNaipe;
    string nomeDaFigura;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Olá, clica no espaço para eu te sortear uma carta");
    }

    // Update is called once per frame
    void Update()
    {

      if (Input.GetKeyDown(KeyCode.Space))
        { numeroDaCarta = Random.Range(1, 15);
            numeroDoNaipe = Random.Range(1, 5);


           

            if (numeroDoNaipe == 1)

            {
                nomeDoNaipe = "Espadas";
            }


            if (numeroDoNaipe == 2)

            {
                nomeDoNaipe = "Ouros";
            }


            if (numeroDoNaipe == 3)

            {
                nomeDoNaipe = "Paus";
            }


            if (numeroDoNaipe == 4)

            {
                nomeDoNaipe = "Copas";
            }


            if (numeroDaCarta == 11)

            {
                nomeDaFigura = "Dama";
            }


            if (numeroDaCarta == 12)

            {
                nomeDaFigura = "Valete";
            }


            if (numeroDaCarta == 13)

            {
                nomeDaFigura = "Rei";
            }


            if (numeroDaCarta == 14)

            {
                nomeDaFigura = "Ás";
            }


            if (numeroDaCarta <= 10)

            {
                Debug.Log("A carta que saiu é " + numeroDaCarta + " de " + nomeDoNaipe);
            }

            if (numeroDaCarta > 10)

            {
                Debug.Log("A carta que saiu é " + nomeDaFigura + " de " + nomeDoNaipe);
            }
        }


    }
}
