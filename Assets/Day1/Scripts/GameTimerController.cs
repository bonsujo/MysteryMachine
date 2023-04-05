using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimerController : MonoBehaviour
{

    public Text gmTimerText;
    float gameTimer = 0f;
    // Update is called once per frame
    void Update()
    {
        gameTimer += Time.deltaTime ;

        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer % 60) % 60;
        int hours = (int)(gameTimer / 3600) % 24;

        string timeStr = string.Format("{0:0}:{1:00}:{2:00}", hours, minutes, seconds);

        gmTimerText.text = timeStr;
        
    }
}
