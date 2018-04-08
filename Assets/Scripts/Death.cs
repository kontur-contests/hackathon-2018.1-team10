using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

    public Transform playerSpawn;
    public GameObject explosionPrefub;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Killer")
        {
            GameObject go = (GameObject)Instantiate(explosionPrefub, gameObject.transform.position, gameObject.transform.rotation);
            gameObject.transform.position = playerSpawn.position;
        }
    }
}
