using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyUpdateScript : MonoBehaviour {

	public int updateState;
	public GameObject up1,up2,up3,up4,up5;
	public int up1cost,up2cost,up3cost,up4cost,up5cost;
	public GameObject priceButton;
	public GameObject button_1;
	public GameObject description;
	public DataStorageScript dataStorageScript;
	public int coinsTotal;
	public string disc1;
	public string disc2;
	public int boostInt;
	public string upgradeType;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		FindCurrency ();

		coinsTotal = dataStorageScript.coinsTotal;

		//MAGNET
		if (upgradeType=="PMagnetUp")
		{
			switch (updateState) {
			case 0:
				up1.SetActive (false);
				up2.SetActive (false);
				up3.SetActive (false);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up1cost;

				if (coinsTotal < up1cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.magnetTime = 5;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 1:
				up1.SetActive (true);
				up2.SetActive (false);
				up3.SetActive (false);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up2cost;

				if (coinsTotal < up2cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.magnetTime = 7;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 2:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (false);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up3cost;

				if (coinsTotal < up3cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.magnetTime = 9;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 3:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (true);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up4cost;

				if (coinsTotal < up4cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.magnetTime = 11;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 4:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (true);
				up4.SetActive (true);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up5cost;

				if (coinsTotal < up5cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.magnetTime = 13;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 5:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (true);
				up4.SetActive (true);
				up5.SetActive (true);
				priceButton.GetComponent<Text> ().text = "MAX";

				dataStorageScript.magnetTime = 15;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;
			}

		}

		//FISHMAGNET
		if (upgradeType=="FMagnetUp")
		{
			switch (updateState) {
			case 0:
				up1.SetActive (false);
				up2.SetActive (false);
				up3.SetActive (false);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up1cost;

				if (coinsTotal < up1cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.fishMagnetTime = 5;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 1:
				up1.SetActive (true);
				up2.SetActive (false);
				up3.SetActive (false);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up2cost;

				if (coinsTotal < up2cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.fishMagnetTime = 7;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 2:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (false);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up3cost;

				if (coinsTotal < up3cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.fishMagnetTime = 9;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 3:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (true);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up4cost;

				if (coinsTotal < up4cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.fishMagnetTime = 11;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 4:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (true);
				up4.SetActive (true);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up5cost;

				if (coinsTotal < up5cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.fishMagnetTime = 13;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 5:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (true);
				up4.SetActive (true);
				up5.SetActive (true);
				priceButton.GetComponent<Text> ().text = "MAX";

				dataStorageScript.fishMagnetTime = 15;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;
			}
		}

		//AMMOAMOUNTINDROP
		if (upgradeType=="AmmoAmUp")
		{
			switch (updateState) {
			case 0:
				up1.SetActive (false);
				up2.SetActive (false);
				up3.SetActive (false);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up1cost;

				if (coinsTotal < up1cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.ammoDropAmount = 5;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 1:
				up1.SetActive (true);
				up2.SetActive (false);
				up3.SetActive (false);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up2cost;

				if (coinsTotal < up2cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.ammoDropAmount = 7;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 2:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (false);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up3cost;

				if (coinsTotal < up3cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.ammoDropAmount = 9;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 3:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (true);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up4cost;

				if (coinsTotal < up4cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.ammoDropAmount = 11;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 4:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (true);
				up4.SetActive (true);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up5cost;

				if (coinsTotal < up5cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.ammoDropAmount = 13;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 5:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (true);
				up4.SetActive (true);
				up5.SetActive (true);
				priceButton.GetComponent<Text> ().text = "MAX";

				dataStorageScript.ammoDropAmount = 15;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;
			}
		}

		//GOLDENRAIN
		if (upgradeType=="GRainUp")
		{
			switch (updateState) {
			case 0:
				up1.SetActive (false);
				up2.SetActive (false);
				up3.SetActive (false);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up1cost;

				if (coinsTotal < up1cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.goldenRainTime = 5;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 1:
				up1.SetActive (true);
				up2.SetActive (false);
				up3.SetActive (false);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up2cost;

				if (coinsTotal < up2cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.goldenRainTime = 7;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 2:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (false);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up3cost;

				if (coinsTotal < up3cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.goldenRainTime = 9;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 3:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (true);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up4cost;

				if (coinsTotal < up4cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.goldenRainTime = 11;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 4:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (true);
				up4.SetActive (true);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up5cost;

				if (coinsTotal < up5cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.goldenRainTime = 13;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 5:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (true);
				up4.SetActive (true);
				up5.SetActive (true);
				priceButton.GetComponent<Text> ().text = "MAX";

				dataStorageScript.goldenRainTime = 15;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;
			}
		}

		//GOLDENFISH
		if (upgradeType=="GFishUp")
		{
			switch (updateState) {
			case 0:
				up1.SetActive (false);
				up2.SetActive (false);
				up3.SetActive (false);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up1cost;

				if (coinsTotal < up1cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.goldFishTime = 5;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 1:
				up1.SetActive (true);
				up2.SetActive (false);
				up3.SetActive (false);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up2cost;

				if (coinsTotal < up2cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.goldFishTime = 7;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 2:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (false);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up3cost;

				if (coinsTotal < up3cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.goldFishTime = 9;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 3:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (true);
				up4.SetActive (false);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up4cost;

				if (coinsTotal < up4cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.goldFishTime = 11;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 4:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (true);
				up4.SetActive (true);
				up5.SetActive (false);
				priceButton.GetComponent<Text> ().text = "" + up5cost;

				if (coinsTotal < up5cost)
					button_1.GetComponent<Button> ().interactable = false;
				else
					button_1.GetComponent<Button> ().interactable = true;

				dataStorageScript.goldFishTime = 13;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;

			case 5:
				up1.SetActive (true);
				up2.SetActive (true);
				up3.SetActive (true);
				up4.SetActive (true);
				up5.SetActive (true);
				priceButton.GetComponent<Text> ().text = "MAX";

				dataStorageScript.goldFishTime = 15;
				description.GetComponent<Text> ().text = disc1 + boostInt + disc2;

				break;
			}
		}


	}

	public void BuyUpdate(){

		switch (updateState)
		{
		case 0:
			dataStorageScript.coinsTotal = dataStorageScript.coinsTotal - up1cost;
			break;
		case 1:
			dataStorageScript.coinsTotal = dataStorageScript.coinsTotal - up2cost;			
			break;
		case 2:
			dataStorageScript.coinsTotal = dataStorageScript.coinsTotal - up3cost;			
			break;
		case 3:
			dataStorageScript.coinsTotal = dataStorageScript.coinsTotal - up4cost;			
			break;
		case 4:
			dataStorageScript.coinsTotal = dataStorageScript.coinsTotal - up5cost;
			break;
		}

		if (updateState != 5)
			updateState++;
	}

	public void FindCurrency(){
		switch (upgradeType)
		{
		case "PMagnetUp":
			boostInt=dataStorageScript.magnetTime;
			break;

		case "FMagnetUp":
			boostInt=dataStorageScript.fishMagnetTime;
			break;

		case "AmmoAmUp":
			boostInt=dataStorageScript.ammoDropAmount;
			break;

		case "GRainUp":
			boostInt=dataStorageScript.goldenRainTime;
			break;

		case "GFishUp":
			boostInt=dataStorageScript.goldFishTime;
			break;
		}
	}

}
