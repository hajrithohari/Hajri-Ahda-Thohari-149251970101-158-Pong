using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public Collider2D ball;
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    public bool isPaddleHitBall;

    private Vector3 scale;
    
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePaddle(PlayerInput());
    }

    private Vector2 PlayerInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MovePaddle(Vector2 movement)
    {
        Debug.Log("Test: " + movement);
        rb.velocity = movement;
    }

    public void PaddleAddSize(float size)
    {
        scale = new Vector3(0, size, 0);
        transform.localScale += scale;
    }

    public void PaddleAddSpeed(int accel)
    {
        speed *= accel;
    }
}
