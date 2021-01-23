using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerManger : MonoBehaviour
{
    public int Missingfuses;
    public float Amount = 100;
    public Text Power;
    public Text TimeCounter;
    public Text Missingfuse;
    public bool missingfuse1;
    public bool missingfuse2;
    public bool missingfuse3;
    public bool nomissingfuse;
    public string Missingfuse1;
    public float missingfuse01 = 0;

    // Use this for initialization
    void Start()
    {
        Power.text = Amount.ToString();
        Missingfuses = Random.Range(1, 5);

    }
    // Update is called once per frame
    void Update()
    {
        Power.text = Amount.ToString();
        if (Amount == -1)
        {
            Amount = 0;
        }
        if (Amount == -2)
        {
            Amount = 0;
        }
        if(Missingfuses == 1)
        {
            if (TimeCounter.text == "Time 3:00")
            {
                missingfuse1 = true;
            }
            if (missingfuse1 == true)
            {
                Power.text = missingfuse01.ToString();
                Missingfuse.text = Missingfuse1.ToString();
            }
        }
    }
}