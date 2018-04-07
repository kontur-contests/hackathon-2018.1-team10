using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostDown : MonoBehaviour {

    public Transform ghostDown;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ghostDown.localPosition += new Vector3(0.01f, 0, 0);
        if (ghostDown.localPosition.x >= 1)
            ghostDown.localPosition = new Vector3(0, ghostDown.localPosition.y, ghostDown.localPosition.z);

	}
}
