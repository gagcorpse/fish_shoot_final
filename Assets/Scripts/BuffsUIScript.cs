using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BuffsUIScript : MonoBehaviour {

	public SceneManagerScript sceneManagerScript;

	[Header("Counters")]
	public GameObject goldFishSec;
	public GameObject goldenRainSec;
	public GameObject magnetSec;
	public GameObject magnetFishSec;

	[Header("UIPlanes")]
	public GameObject goldFishPlane;
	public GameObject goldenRainPlane;
	public GameObject magnetPlane;
	public GameObject magnetFishPlane;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (sceneManagerScript.goldFishTime != 0) {	
			goldFishPlane.SetActive (true);
			goldFishSec.GetComponent<Text> ().text = String.Format ("{0:0.00}", sceneManagerScript.goldFishTime);
		} else 
			goldFishPlane.SetActive (false);

		if (sceneManagerScript.goldenRainTime != 0) {	
			goldenRainPlane.SetActive (true);
			goldenRainSec.GetComponent<Text> ().text = String.Format ("{0:0.00}", sceneManagerScript.goldenRainTime);
		} else
			goldenRainPlane.SetActive (false);

		if (sceneManagerScript.magnetTime != 0) {
			magnetPlane.SetActive (true);
			magnetSec.GetComponent<Text> ().text = String.Format ("{0:0.00}", sceneManagerScript.magnetTime);
		} else magnetPlane.SetActive (false);

		if (sceneManagerScript.fishMagnetTime != 0) {
			magnetFishPlane.SetActive (true);
			magnetFishSec.GetComponent<Text> ().text = String.Format ("{0:0.00}", sceneManagerScript.fishMagnetTime);
		} else magnetFishPlane.SetActive (false);

	}
}
