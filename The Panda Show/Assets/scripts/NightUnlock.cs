using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NightUnlock : MonoBehaviour
{

    public Text TimeCounter;
    public static NightUnlock Instance;
    public GameObject Night2buttonlocked;
    public GameObject Night2buttonunlocked;
    public bool Night1;
    public bool Night2;
    public bool Night3;
    public bool Night4;
    public bool Night5;
    public bool Night6;
    public bool Night7;
    public bool Night8;
    public bool Night9;
    public bool Night10;


    void Start()
    {
        if(Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        if(TimeCounter.text == "Time 6:00")
        {
            Night1 = true;
        }
        if(Night1 == true)
        {
            Night2buttonlocked.SetActive(false);
            Night2buttonunlocked.SetActive(true);
        }
    }
}
