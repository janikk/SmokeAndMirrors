using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This is a superclass for all features that interactable objects will share
public class InteractableObjects : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // What happens when player clicks on something interactable
    void OnMouseDown()
    {
        if (MouseType.type == "Interact")
        {
            Debug.Log("Interact with object");
            InteractClick();
            //else statement for "theres nothing there"
        }
        else if (MouseType.type == "Look")
        {
            Debug.Log("Look at object");
            LookClick();
            //else statement for "theres nothing there"
        }else if (MouseType.type == "Talk")
        {
            Debug.Log("Talk to subject");
            TalkClick();
            //else statement for "there's no one to talk to"
        }else if (MouseType.type == "Use")
        {
            Debug.Log("Use item on object");
            UseClick();
            //else statement for "there's nothing to use that on"
        }else if (MouseType.type == "Move")
        {
            Debug.Log("Move to location");
            MoveClick();
        }
        //Else do nothing
    }

    // When the player is in interact mode
    bool InteractClick()
    {
        //if(something to click on){
        //    do interaction
        //    return true
        //}
        return false;
    }

    // When the player is in look mode
    bool LookClick()
    {
        //if(something to click on){
        //    text for looking
        //    return true
        //}
        return false;
    }

    // When the player is in talk mode
    bool TalkClick()
    {
        //if(something to click on){
        //    if(type to talk to){
        //        text for talking
        //    } else {
        //        text for there's nothing there
        //    }
        //    return true
        //}
        return false;
    }

    // When the player is in use mode
    bool UseClick()
    {
        //if(item is something that can be used){
        //    use item
        //    return true;
        //} else {
        //    text to not use that item
        //    return true;
        //}
        return false;
    }

    // When the player is in move mode
    bool MoveClick()
    {
        //move as far along the linear path as you can until either
        //there is a collision or youre there
        //if you cant move from where you are then
        return false;
    }
}
