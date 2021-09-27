using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        // Guarda o inimigo que foi atingido na variavel 
        //Enemy target = hitInfo.GetComponent<Enemy>();

        // Caso o target nao seja null vai chamar a funcao para dar dano ao inimigo e dps destroi a bala
        /*if (target != null)
        {
            target.takeDamage(1);
        }*/
        Destroy(gameObject,3f);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Player" && collision.gameObject.tag != "Plataform")
            Destroy(gameObject);
    }

}
