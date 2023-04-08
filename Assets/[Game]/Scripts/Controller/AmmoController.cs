using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AmmoController : MonoBehaviour, I_Interactable
{
    public void Use()
    {
        AmmoSituation();
    }

    private void AmmoSituation()
    {
        AmmoTextScript.Instance.ammoAmount += 2;
        Debug.Log("You earned +2 ammo");
        Waste();
        UpdateText();
    }

    public void Waste()
    {
        AmmoTextScript.Instance.ammoAmount -- ;
        Debug.Log("You lost 1 ammo");
    }

    void UpdateText()
    {
        AmmoTextScript.Instance.AmmoTextUI.text = "Ammo:" + AmmoTextScript.Instance.ammoAmount;
    }


}
