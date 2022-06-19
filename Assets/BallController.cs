using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 ballMovement;
    public Vector2 resetPosition;

    public Collider2D paddleKiri;
    public Collider2D paddleKanan;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = ballMovement;
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 1);
    }

    public void ActiveSpeedUp(float magnitude)
    {
        rb.velocity *= magnitude;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == paddleKanan) 
        {
            paddleKanan.GetComponent<PaddleController>().isPaddleHitBall = true;
            paddleKiri.GetComponent<PaddleController>().isPaddleHitBall = false;
        }
        if (collision == paddleKiri)
        {
            paddleKiri.GetComponent<PaddleController>().isPaddleHitBall = true;
            paddleKanan.GetComponent<PaddleController>().isPaddleHitBall = false;
        }
    }
}
