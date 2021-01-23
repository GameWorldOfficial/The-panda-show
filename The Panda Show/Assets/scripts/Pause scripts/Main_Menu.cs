using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Main_Menu : MonoBehaviour
{
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }


    public void PlayNight1()

    {

        SceneManager.LoadScene(1);

    }

    public void QuitGame()

    {

        Debug.Log("QUIT!");

        Application.Quit();

    }
}