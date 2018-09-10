using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseType : MonoBehaviour {
    public string type;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Default mouse
    void setInteract()
    {
        type = "Interact";
        Debug.Log("Mouse type: Interact");
    }

    // To look at things
    void setLook()
    {
        type = "Look";
        Debug.Log("Mouse type: Look");
    }

    // To talk to selected target
    void setTalk()
    {
        type = "Talk";
        Debug.Log("Mouse type: Talk");
    }

    // To use an item or a magic pouch item
    void setUse()
    {
        type = "Use";
        Debug.Log("Mouse type: Use");
    }

    // To move
    void setMove()
    {
        type = "Move";
        Debug.Log("Mouse type: Move");
    }
}
