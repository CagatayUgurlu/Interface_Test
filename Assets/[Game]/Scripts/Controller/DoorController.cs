using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorController : MonoBehaviour, I_Interactable
{
    private bool isDoorOpened = false;
    private Animator anim;
    public Animator Anim { get { return (anim == null) ? anim = GetComponent<Animator>() : anim; } }
    public void Use()
    {
        DoorSituation();
    }

    public void Waste()
    {
        
    }

    private void DoorSituation()
    {
        if (!isDoorOpened)
        {
            Anim.SetTrigger("Open");
            isDoorOpened = true;
            Debug.Log("You opened the door");
            DoorTextScript.Instance.DoorTextUI.text = "Door is Open";
        }
        else if (isDoorOpened)
        {
            Anim.SetTrigger("Close");
            isDoorOpened = false;
            Debug.Log("You closed the door");
            DoorTextScript.Instance.DoorTextUI.text = "Door is closed";
        }
    }
}
