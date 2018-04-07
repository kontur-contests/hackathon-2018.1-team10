using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour {

    public string player1WinSceneName;
    public string player2WinSceneName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player1")
            SceneManager.LoadScene(player1WinSceneName);

        if (coll.gameObject.tag == "Player2")
            SceneManager.LoadScene(player2WinSceneName);
    }
}
