using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public bool GamePaused = false;
    public GameObject PauseMenu;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (GamePaused == false)
            {
                Time.timeScale = 0;
                GamePaused = true;
                PauseMenu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                GamePaused = false;
                PauseMenu.SetActive(false);
            }
        }
    }
    public void Unpausegame()
    {
        Time.timeScale = 1;
        GamePaused = false;
        PauseMenu.SetActive(false);
    }
}