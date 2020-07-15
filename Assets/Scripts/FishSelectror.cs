using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishSelectror : MonoBehaviour {

	public int currentFishNum;
	public GameObject fish1,fish2,fish3,fish4,fish5;
	public Text namelabel, descr;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		FishChanger ();
	}

	public void SwitchRightBtn(){
		switch (currentFishNum){
		case 1:
			currentFishNum = 2;
			break;
		case 2:
			currentFishNum = 3;
			break;
		case 3:
			currentFishNum = 4;
			break;
		case 4:
			currentFishNum = 5;
			break;
		case 5:
			currentFishNum = 1;
			break;
		}
	}

	public void SwitchLeftBtn(){
		switch (currentFishNum) {
		case 1:
			currentFishNum = 5;
			break;
		case 2:
			currentFishNum = 1;
			break;
		case 3:
			currentFishNum = 2;
			break;
		case 4:
			currentFishNum = 3;
			break;
		case 5:
			currentFishNum = 4;
			break;
		}
	}

	public void FishChanger(){
		switch (currentFishNum) {
		case 1:
			fish1.SetActive (true);
			fish2.SetActive (false);
			fish3.SetActive (false);
			fish4.SetActive (false);
			fish5.SetActive (false);

			namelabel.text="Roundfish Bob";
			descr.text="Round red and hungry!";
			break;
		case 2:
			fish1.SetActive (false);
			fish2.SetActive (true);
			fish3.SetActive (false);
			fish4.SetActive (false);
			fish5.SetActive (false);

			namelabel.text="Fish 2 name";
			descr.text="Fish 2 description";
			break;
		case 3:
			fish1.SetActive (false);
			fish2.SetActive (false);
			fish3.SetActive (true);
			fish4.SetActive (false);
			fish5.SetActive (false);

			namelabel.text="Fish 3 name";
			descr.text="Fish 3 description";
			break;
		case 4:
			fish1.SetActive (false);
			fish2.SetActive (false);
			fish3.SetActive (false);
			fish4.SetActive (true);
			fish5.SetActive (false);

			namelabel.text="Fish 4 name";
			descr.text="Fish 4 description";
			break;
		case 5:
			fish1.SetActive (false);
			fish2.SetActive (false);
			fish3.SetActive (false);
			fish4.SetActive (false);
			fish5.SetActive (true);

			namelabel.text="Fish 5 name";
			descr.text="Fish 5 description";
			break;
		}
	}
}
