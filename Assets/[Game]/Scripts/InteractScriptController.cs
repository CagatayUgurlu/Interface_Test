using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InteractScriptController : Singleton<InteractScriptController>
{
    private Text interactScript;
    public Text InteractScript { get { return (interactScript == null) ? interactScript = GetComponent<Text>() : interactScript; } }

    private void Start()
    {
        InteractScript.text = "You can interact with : Nothing";
    }

    public void UpdateText(string objectName)
    {
        InteractScript.text = "You can interact with : " + objectName;
    }
}
    //private TextMeshPro interactScriptUI;

    //public TextMeshPro InteractScriptUI { get { return (interactScriptUI == null) ? interactScriptUI = GetComponent<TextMeshPro>() : interactScriptUI; } }

    //private void Start()
    //{
    //    InteractScriptUI.text = "You can interact with: Nothing";
    //}

    //public void UpdateText(string objectName)
    //{
    //    InteractScriptUI.text = "You can interact with: " + objectName;
    //}
//}
