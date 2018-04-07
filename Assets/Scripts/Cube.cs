using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public Transform cubeSpawnPos;

    public GameObject explosionPrefub;

    public Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Killer")
        {
            GameObject go = (GameObject)Instantiate(explosionPrefub, gameObject.transform.position, explosionPrefub.transform.rotation);

            gameObject.transform.position = cubeSpawnPos.position;

            anim.Play("SpawnCube");
        }
    }
}
