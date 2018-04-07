using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPosCalculation : MonoBehaviour {

    public Transform player1Pos;
    public Transform player2Pos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {

        transform.position = new Vector3((player1Pos.position.x + player2Pos.position.x) / 2, 0);
    }
}
