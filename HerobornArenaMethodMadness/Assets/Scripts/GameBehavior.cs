using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CustomExtensions;

public class GameBehavior : MonoBehaviour, IManager
{
    private string _state;

    public static bool showWinScreen = false;
    public static bool showLoseScreen = false;
    public static int staminaText;
    public static string detected = "HIDDEN";
    public static int bullets = 10;

    public string State
    {
        get { return _state; }
        set { _state = value; }
    }

    void OnGUI()
    { 

        GUI.Box(new Rect(20, 20, 150, 25), "Stamina: " +
           staminaText);

        GUI.Box(new Rect(20, 50, 150, 25), "Status: " +
           detected);

        GUI.Box(new Rect(20, 80, 150, 25), "Bullets: " +
           bullets);

        if (showWinScreen == true)
        {
            Time.timeScale = 0f;
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "YOU WON!"))
            {
                showWinScreen = false;
                Utilities.RestartLevel(0);
            }
        }

        if (showLoseScreen == true)
        {
            Time.timeScale = 0f;
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "YOU LOSE!"))
            {
                showLoseScreen = false;
                Utilities.RestartLevel(0);
            }
        }
    }

    public void Initialize()
    {
        _state = "Manager initialized..";
        _state.FancyDebug();
        Debug.Log(_state);
    }

    void Start()
    {
        Initialize();
    }

    void Update()
    {
        
    }
}
