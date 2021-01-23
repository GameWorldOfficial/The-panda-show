﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject WestCamera;
    public GameObject EastCamera;
    public GameObject MainShowStageCamera;
    public GameObject PartsAndServiceCamera1;
    public GameObject PartsAndServiceCamera2;
    public GameObject PartsAndServiceCamera3;
    public GameObject PartyRoomCamera1;
    public GameObject PartyRoomCamera2;
    public GameObject BathroomCamera;
    public GameObject ArcadeCamera;
    public GameObject player;
    public GameObject CamSystemCamera;
    public GameObject CamButtonsPanel;
    public GameObject CamControles;
    public GameObject SecurityCanvas;
    public void Button_Click()
    {
        MainShowStageCamera.SetActive(false);
        WestCamera.SetActive(false);
        EastCamera.SetActive(false);
        PartsAndServiceCamera1.SetActive(false);
        PartsAndServiceCamera2.SetActive(false);
        PartsAndServiceCamera3.SetActive(false);
        PartyRoomCamera1.SetActive(false);
        PartyRoomCamera2.SetActive(false);
        BathroomCamera.SetActive(false);
        ArcadeCamera.SetActive(false);
        player.SetActive(true);
        CamSystemCamera.SetActive(false);
        CamButtonsPanel.SetActive(false);
        CamControles.SetActive(false);
        SecurityCanvas.SetActive(false);
    }
}
