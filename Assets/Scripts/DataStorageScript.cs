using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataStorageScript : MonoBehaviour {
	public int coinsTotal,highScore, goldFishTime, fishMagnetTime, magnetTime, goldenRainTime, ammoDropAmount, startAmmo;

	[Header("SetInCountsUI")]
	public UpgradesUI upgradesUI;  

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		upgradesUI.coinsTotal = coinsTotal;
		upgradesUI.setUpCoins ();
	}

	public void highScoreSet(int hscore){
		int hiscore = hscore;

		if (hiscore > highScore)
			highScore = hiscore;
	}
}
