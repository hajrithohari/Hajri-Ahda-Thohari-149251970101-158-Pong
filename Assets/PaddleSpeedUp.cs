using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSpeedUp : MonoBehaviour
{
    public PowerUpManager manager;

    public GameObject paddleKiri;
    public GameObject paddleKanan;

    public int accel;

    public Collider2D ball;

    private void Update()
    {
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball)
        {
            if (paddleKiri.GetComponent<PaddleController>().isPaddleHitBall)
            {
                paddleKiri.GetComponent<PaddleController>().PaddleAddSpeed(accel);
            }
            if (paddleKanan.GetComponent<PaddleController>().isPaddleHitBall)
            {
                paddleKanan.GetComponent<PaddleController>().PaddleAddSpeed(accel);
            }

            manager.RemovePowerUp(gameObject);
        }
    }
}
