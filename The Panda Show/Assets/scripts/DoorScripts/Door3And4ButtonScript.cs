using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3And4ButtonScript : MonoBehaviour
{
    
    public GameObject SecurityDoor2;
    public GameObject Button3and4;
    public bool Interact;
    public PowerManger PowerManger;
    

    void OnTriggerEnter(Collider other)
    {
        Interact = true;
        if(Interact == true)
        {
            SecurityDoor2.GetComponent<Animation>().Play("OpenSecurityDoor2");
            Button3and4.GetComponent<Animation>().Play("ButtonPress");
            PowerManger.Amount -= 1;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Interact = false;
        SecurityDoor2.GetComponent<Animation>().Play("CloseSecurityDoor2");
    }

    void start()
    {
        Interact = false;
    }
}
