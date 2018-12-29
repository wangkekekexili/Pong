using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int player1Score;
    private static int player2Score;
    public static int Player1Score
    {
        get
        {
            return player1Score;
        }
    }
    public static int Player2Score
    {
        get
        {
            return player2Score;
        }
    }

    public static void Score(string wall)
    {
        switch (wall)
        {
            case "LeftWall":
                player2Score += 1;
                break;
            case "RightWall":
                player1Score += 1;
                break;
        }
        Debug.Log("player1 score " + player1Score);
        Debug.Log("player2 score " + player2Score);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width/2-2, 20, 100, 100), $"{player1Score}:{player2Score}");
    }
}
