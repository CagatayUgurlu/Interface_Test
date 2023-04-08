using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorTextScript : Singleton<DoorTextScript>
{
    private Text doorTextUI;

    public Text DoorTextUI { get { return (doorTextUI == null) ? doorTextUI = GetComponent<Text>() : doorTextUI; } }

    void Start()
    {
        doorTextUI = GetComponent<Text>();
    }
}
