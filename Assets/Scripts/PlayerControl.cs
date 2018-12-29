using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 10;
    public KeyCode MoveUp;
    public KeyCode MoveDown;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody2D = GetComponent<Rigidbody2D>();
        if (Input.GetKey(MoveUp))
        {
            rigidbody2D.velocity = new Vector2(0f, speed);
        }
        else if (Input.GetKey(MoveDown))
        {
            rigidbody2D.velocity = new Vector2(0f, -speed);
        }
        else
        {
            rigidbody2D.velocity = new Vector2(0f, 0f);
        }
    }
}
