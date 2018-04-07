using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour {

    public bool hasObjectForGrab;
    public KeyCode grabKey;
    public GameObject objectForGrab;

    public Transform grabObjectPos;

    public GameObject heands;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKeyDown(grabKey))
        {
            if (hasObjectForGrab)
            {
                objectForGrab.transform.position = grabObjectPos.position;
                objectForGrab.transform.parent = gameObject.transform;
                objectForGrab.GetComponent<Rigidbody2D>().isKinematic = true;
            }
            else
            {
                objectForGrab.transform.parent = null;
                objectForGrab.GetComponent<Rigidbody2D>().isKinematic = false;
                objectForGrab = null;
            }
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        hasObjectForGrab = true;
        objectForGrab = coll.gameObject;
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        hasObjectForGrab = false;
    }
}
