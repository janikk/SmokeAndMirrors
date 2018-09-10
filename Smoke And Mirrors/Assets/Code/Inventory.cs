using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    public IList<GameObject> items = new List<GameObject>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // When player gets a new item
    void NewItem(GameObject item)
    {
        items.Add(item);
        //text for acquiring an item
    }

    // When player uses an item
    void UseItem(GameObject item)
    {
        items.Remove(item);
        //text for using item?
    }
}
