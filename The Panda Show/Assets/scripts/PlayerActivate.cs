using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActivate : MonoBehaviour
{
    public GameObject Player;

    void Start()
    {
        Player.SetActive(true);
    }
}
