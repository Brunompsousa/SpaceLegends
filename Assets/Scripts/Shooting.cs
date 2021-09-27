using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;

    public GameObject bulletpre;

    public float bulletForce = 25f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //Criaçao do tiro, dando tb a posicao e rotacao do firepoint que criamos.
        GameObject bullet = Instantiate(bulletpre, firePoint.position, firePoint.rotation);
        //Da-se um rigidbody2d ao tiro
        Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        Rigidbody2D realB = bullet.GetComponent<Rigidbody2D>();
        //adicionamos uma força a bala para que esta viage
        realB.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);

    }
}
