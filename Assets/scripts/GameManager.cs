using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;

    public GameObject startPage;
    public GameObject gameOverPage;
    public GameObject countdownPage;
    public Text scoreText;

    enum PageState {
            None,
            Start,
            GameOver,
            Countdown
    }

    int csore = 0;
    bool gameOver = false;

    public bool GameOver { get { return gameOver; } }

    void Awake()
    {
        Instance = this;
    }


}
