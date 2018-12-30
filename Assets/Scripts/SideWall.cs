using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name != "Ball")
        {
            return;
        }
        var wallName = GetComponent<Transform>().name;
        GameManager.Score(wallName);
        collision.gameObject.SendMessage("resetBall");
    }
}
