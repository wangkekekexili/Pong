using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private AudioSource _audio;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _audio = GetComponent<AudioSource>();
        Random.InitState(System.DateTimeOffset.Now.Millisecond);
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("goBall", 2);
    }

    private void resetBall()
    {
        _rigidbody2D.velocity = new Vector2(0, 0);
        var t = GetComponent<Transform>();
        t.position = new Vector3(0, 0, 0);
        Invoke("goBall", 0.5f);
    }

    private void goBall()
    {
        var randomNumber = Random.Range(0f, 1f);
        if (randomNumber <= 0.5)
        {
            Debug.Log("right");
            _rigidbody2D.AddForce(new Vector2(80, 10));
        }
        else
        {
            Debug.Log("left");
            _rigidbody2D.AddForce(new Vector2(-80, -10));
        }
    }


    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            //var velY = _rigidbody2D.velocity.y;
            //velY = velY / 2 + collision.collider.attachedRigidbody.velocity.y / 3;
            //_rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, velY);

            _audio.pitch = Random.Range(0.75f, 1f);
            _audio.Play();
        }
    }
}
