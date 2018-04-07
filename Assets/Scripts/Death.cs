using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

    public Transform player1Spawn;
    public Transform player2Spawn;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Player1")
            coll.gameObject.transform.position = player1Spawn.position;

        if (coll.gameObject.name == "Player2")
            coll.gameObject.transform.position = player2Spawn.position;
    }
}
