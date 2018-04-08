using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScoreUi : MonoBehaviour {

    public Text player1scoreTxt;
    public Text player2scoreTxt;

	// Use this for initialization
	void Start () {
        player1scoreTxt.text = PlayerPrefs.GetInt("Player1Score").ToString();
        player1scoreTxt.text = PlayerPrefs.GetInt("Player2Score").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
