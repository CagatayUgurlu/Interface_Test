using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour, I_Interactable
{
    public void Use()
    {
        HealSituation();
    }
    public void Waste()
    {
        WasteHealSituation();
    }

    private static void WasteHealSituation()
    {
        HealthTextScript.Instance.healthPoints -= 2;
        Debug.Log("You lost 2 health points");
    }

    private void HealSituation()
    {
        HealthTextScript.Instance.healthPoints += 3;
        Debug.Log("You earned 3 health points");
        Waste();
        UpdateText();
    }
    private void UpdateText()
    {
        HealthTextScript.Instance.HealthTextUI.text = "Health :" + HealthTextScript.Instance.healthPoints;
    }
}
