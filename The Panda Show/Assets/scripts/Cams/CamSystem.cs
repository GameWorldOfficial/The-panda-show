using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSystem : MonoBehaviour
{

    public GameObject SecurityCanvas;
    public GameObject CamButtonsPanel;
    public GameObject CamControles;
    public GameObject CamSystemCamera;
    public GameObject player;
    public bool Interact;

    void OnTriggerEnter(Collider other)
    {
        SecurityCanvas.SetActive(true);
        Interact = true;
    }

    void Start()
    {
        Interact = false;
    }

    void OnTriggerExit(Collider other)
    {
        SecurityCanvas.SetActive(false);
        Interact = false;
    }

    void Update()
    {
        if(Interact == true)
        {
            if (Input.GetKeyDown("e"))
            {
                CamControles.SetActive(false);
                SecurityCanvas.SetActive(true);
                CamSystemCamera.SetActive(true);
                player.SetActive(false);
                CamButtonsPanel.SetActive(true);
            }
        }
    }






}
