using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1And2ButtonScript : MonoBehaviour
{
    
    public GameObject SecurityDoor1;
    public GameObject Button1and2;
    public bool Interact;
    public PowerManger PowerManger;

    void OnTriggerEnter(Collider other)
    {
        Interact = true;
        if(Interact == true)
        {
            SecurityDoor1.GetComponent<Animation>().Play("OpenSecurityDoor");
            Button1and2.GetComponent<Animation>().Play("ButtonPress");
            PowerManger.Amount -= 1;
        }

    }

    void OnTriggerExit(Collider other)
    {
        Interact = false;
        SecurityDoor1.GetComponent<Animation>().Play("CloseSecurityDoor");
    }

    void start()
    {
        Interact = false;
    }
}
