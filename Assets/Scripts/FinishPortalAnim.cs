using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPortalAnim : MonoBehaviour {

    public Transform transform;

    public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localEulerAngles += new Vector3(0, 0, rotationSpeed);
	}
}
