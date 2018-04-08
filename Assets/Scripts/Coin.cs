using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour {

    public string player1sceneName;
    public string player2sceneName;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "Player1" || coll.gameObject.name == "Player2")
        {
            if (coll.gameObject.name == "Player1")
                SceneManager.LoadScene(player1sceneName);

            if (coll.gameObject.name == "Player2")
                SceneManager.LoadScene(player2sceneName);
        }
    }
}
