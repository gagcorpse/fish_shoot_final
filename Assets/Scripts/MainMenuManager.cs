using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour {

	public DataStorageScript dataStorageScript;
	public Text coinsMainmenu;
	public Text highScoreMainmenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		coinsMainmenu.text = ""+dataStorageScript.coinsTotal;
		highScoreMainmenu.text = ""+dataStorageScript.highScore;
	}
}
