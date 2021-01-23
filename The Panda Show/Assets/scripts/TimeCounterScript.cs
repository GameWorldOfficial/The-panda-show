using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounterScript : MonoBehaviour
{

    public Text TimeCounter;

    void Start()
    {
        StartCoroutine(Timecounter());
    }
    IEnumerator Timecounter()
    {
        yield return new WaitForSeconds(86);
        TimeCounter.text = "Time 1:00";
        yield return new WaitForSeconds(86);
        TimeCounter.text = "Time 2:00";
        yield return new WaitForSeconds(86);
        TimeCounter.text = "Time 3:00";
        yield return new WaitForSeconds(86);
        TimeCounter.text = "Time 4:00";
        yield return new WaitForSeconds(86);
        TimeCounter.text = "Time 5:00";
        yield return new WaitForSeconds(86);
        TimeCounter.text = "Time 6:00";

    }
    

    
    
    void Update()
    {
       
    }
}
