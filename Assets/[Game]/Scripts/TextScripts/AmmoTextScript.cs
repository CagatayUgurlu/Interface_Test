using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class AmmoTextScript : Singleton<AmmoTextScript>
{
    public int ammoAmount = 0;
    private Text ammoTextUI;

    public Text AmmoTextUI { get { return (ammoTextUI == null) ? ammoTextUI = GetComponent<Text>() : ammoTextUI; } }

    void Start()
    {
        AmmoTextUI.text = "Ammo: " + ammoAmount;
    }
}
