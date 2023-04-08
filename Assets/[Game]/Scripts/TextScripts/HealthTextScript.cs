using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthTextScript : Singleton<HealthTextScript>
{
    public int healthPoints = 0;
    private Text healthTextUI;

    public Text HealthTextUI { get { return (healthTextUI == null) ? healthTextUI = GetComponent<Text>() : healthTextUI; } }

    void Start()
    {
        HealthTextUI.text = "Health: " + healthPoints;
    }
}
