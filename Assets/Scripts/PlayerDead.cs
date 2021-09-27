using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{

    Vector3 InicialPosition = new Vector3(-4.76f, -1.29f, 0f);

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -3.6f)
        {
            transform.position = InicialPosition;

            //player morre
            /*
             * 
             * Se o jogador tiver vidas, desconta uma e mete o player na posicao inicial
             * senao e gameover
             * 
             */

        }
    }
}
