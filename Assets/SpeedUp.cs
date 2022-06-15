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
        Debug.Log("ada speed up");
        Destroy(gameObject, 6f);
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
