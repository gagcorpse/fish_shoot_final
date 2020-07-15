using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesUI : MonoBehaviour {

	public int coinsTotal;
	public GameObject coinsTotalText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//coinsTotal=?
	}

	public void setUpCoins(){
		
		coinsTotalText.GetComponent<Text> ().text = "" + coinsTotal;
	}
}
