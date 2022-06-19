using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScale : MonoBehaviour
{
    public PowerUpManager manager;

    public GameObject paddleKiri;
    public GameObject paddleKanan;
   
    public Collider2D ball;
    public float paddleSize;

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
                paddleKiri.GetComponent<PaddleController>().PaddleAddSize(paddleSize);
            }
            if (paddleKanan.GetComponent<PaddleController>().isPaddleHitBall)
            {
                paddleKanan.GetComponent<PaddleController>().PaddleAddSize(paddleSize);
            }
            manager.RemovePowerUp(gameObject);
        }
    }
}
