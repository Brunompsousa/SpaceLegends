using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPistol : MonoBehaviour
{
    public Vector3 MousePosition;
    public GameObject player;
    public GameObject firepoint;
    int turn = 0;

    // Update is called once per frame
    void Update()
    {
        MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        MousePosition.Normalize();

        float angle = Mathf.Atan2(MousePosition.y, MousePosition.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f,0f,angle-7.5f);

        if (angle < -90 || angle > 90)
        {

            if (gameObject.transform.eulerAngles.y == 0)
            {
                transform.localRotation = Quaternion.Euler(180f, 180f, -angle);
                player.transform.localScale = new Vector3(-1, 1, 1);
                if(turn == 0)
                { firepoint.transform.Rotate(0, 180f, 0); turn = 1; }
            }
        }
        else
        {
            player.transform.localScale = new Vector3(1, 1, 1);
            if (turn == 1)
            { firepoint.transform.Rotate(0, -180f, 0); turn = 0; }
        }
    }
}

/*
 * Travar a rotacao do braço e obrigar o jogador a virar o boneco.*/