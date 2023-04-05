using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool gameWin;
    public GameObject gameOverDisplay;
    public GameObject gameWinDisplay;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        gameWin = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverDisplay.SetActive(true);
        }
        if (gameWin)
        {
            Time.timeScale = 0;
            gameWinDisplay.SetActive(true);
        }
    }
}
