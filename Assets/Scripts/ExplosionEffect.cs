using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour {

    public float destroiTime;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, destroiTime);
	}
}
