using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party_Room_Camera_2 : MonoBehaviour
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
    public PowerManger PowerManger;
    public void Button_Click()
    {
        WestCamera.SetActive(false);
        EastCamera.SetActive(false);
        MainShowStageCamera.SetActive(false);
        PartsAndServiceCamera1.SetActive(false);
        PartsAndServiceCamera2.SetActive(false);
        PartsAndServiceCamera3.SetActive(false);
        PartyRoomCamera1.SetActive(false);
        PartyRoomCamera2.SetActive(true);
        BathroomCamera.SetActive(false);
        ArcadeCamera.SetActive(false);
        PowerManger.Amount -= 2;
    }

}
