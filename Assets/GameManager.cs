using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;
    
    public GUISkin layout;
    
    GameObject Ball;

    void Start() {
        Ball = GameObject.FindGameObjectWithTag("Ball");
    }

    void Score(string wallId) {
            if (wallId == "RightWall")
            {
                PlayerScore1++;
            } else
            {
                PlayerScore2++;
            }
        }
    

    void OnGUI() {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + PlayerScore1);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + PlayerScore2);

        if (GUI.Button(new Rect(Screen.width / 2 - 60, 35, 120, 53), "RESTART"))
        {
            PlayerScore1 = 0;
            PlayerScore2 = 0;
            Ball.SendMessage("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
        }
    }
}

