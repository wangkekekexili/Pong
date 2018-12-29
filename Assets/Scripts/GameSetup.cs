using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    public Camera mainCamera;
    public BoxCollider2D topWall;
    public BoxCollider2D bottomWall;
    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;

    public Transform player1;
    public Transform player2;

    // Start is called before the first frame update
    void Start()
    {
        topWall.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x * 2, 1f);
        topWall.offset = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y + 0.5f);

        bottomWall.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x * 2, 1f);
        bottomWall.offset = new Vector2(0f, -mainCamera.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y - 0.5f);

        leftWall.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y * 2);
        leftWall.offset = new Vector2(-mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x - 0.5f, 0f);

        rightWall.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y * 2);
        rightWall.offset = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x + 0.5f, 0f);

        player1.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(75, 0, 0)).x, 0f);
        player2.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width - 75, 0, 0)).x, 0f);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
