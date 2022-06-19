using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public PowerUpManager manager;

    public Collider2D ball;
    public float acceleration;

    private void Update()
    {
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball)
        {
            ball.GetComponent<BallController>().ActiveSpeedUp(acceleration);
            manager.RemovePowerUp(gameObject);
        }
    }
}
