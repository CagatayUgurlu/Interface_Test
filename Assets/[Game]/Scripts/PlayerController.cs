using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject GameObject = null;
    private int movementSpeed = 300;
    private Rigidbody rigidbody;
    public Rigidbody Rigidbody { get { return (rigidbody == null) ? rigidbody = GetComponent<Rigidbody>() : rigidbody; } }

    private void FixedUpdate()
    {
        MovementControl();
    }
    private void Update()
    {
        InputControl();
    }

    private void MovementControl()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), Rigidbody.velocity.y, Input.GetAxisRaw("Vertical"));
        Rigidbody.velocity = input * movementSpeed * Time.fixedDeltaTime;
    }
    private void InputControl()
    {
        if (GameObject == null)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            I_Interactable i_interactScript = GameObject.GetComponentInChildren<I_Interactable>();
            if (i_interactScript != null)
            {
                i_interactScript.Use();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    { 
        GameObject = other.gameObject;
        InteractScriptController.Instance.UpdateText(other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject = null;
        InteractScriptController.Instance.UpdateText("Nothing");
    }
}
