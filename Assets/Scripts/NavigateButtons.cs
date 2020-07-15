using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavigateButtons : MonoBehaviour {

	[Header("Buttons")]
	public GameObject main;
	public GameObject powerups;
	public GameObject shop;
	public GameObject highscores;

	public Sprite btnUP;
	public Sprite btnDOWN;

	[Header("Windows")]
	public GameObject mainWindow;
	public GameObject powerupsWindow;
	public GameObject shopWindow;
	public GameObject highscoresWindow;


	// Use this for initialization
	void Start () {
		//MainWindowButton ();
	}
	
	// Update is called once per frame
	void Update () {
		WindowActiveCheck ();
	}

	public void WindowActiveCheck(){
		if (mainWindow.activeSelf) 
		{
			main.GetComponent<Image> ().sprite = btnDOWN;
			main.GetComponent<Button> ().interactable = false;
		}
	}

	public void MainWindowButton(){
		main.GetComponent<Button> ().interactable = false;
		main.GetComponent<Image> ().sprite = btnDOWN;

		powerups.GetComponent<Button> ().interactable = true;
		shop.GetComponent<Button> ().interactable = true;
		highscores.GetComponent<Button> ().interactable = true;

		powerups.GetComponent<Image> ().sprite = btnUP;
		shop.GetComponent<Image> ().sprite = btnUP;
		highscores.GetComponent<Image> ().sprite = btnUP;

		mainWindow.SetActive (true);
		powerupsWindow.SetActive (false);
		shopWindow.SetActive (false);
		highscoresWindow.SetActive (false);

	}

	public void PowerUpsWindowButton(){
		powerups.GetComponent<Button> ().interactable = false;
		powerups.GetComponent<Image> ().sprite = btnDOWN;

		main.GetComponent<Button> ().interactable = true;
		shop.GetComponent<Button> ().interactable = true;
		highscores.GetComponent<Button> ().interactable = true;

		main.GetComponent<Image> ().sprite = btnUP;
		shop.GetComponent<Image> ().sprite = btnUP;
		highscores.GetComponent<Image> ().sprite = btnUP;

		mainWindow.SetActive (false);
		powerupsWindow.SetActive (true);
		shopWindow.SetActive (false);
		highscoresWindow.SetActive (false);
	}

	public void ShopWindowButton(){
		shop.GetComponent<Button> ().interactable = false;
		shop.GetComponent<Image> ().sprite = btnDOWN;

		main.GetComponent<Button> ().interactable = true;
		powerups.GetComponent<Button> ().interactable = true;
		highscores.GetComponent<Button> ().interactable = true;

		main.GetComponent<Image> ().sprite = btnUP;
		powerups.GetComponent<Image> ().sprite = btnUP;
		highscores.GetComponent<Image> ().sprite = btnUP;

		mainWindow.SetActive (false);
		powerupsWindow.SetActive (false);
		shopWindow.SetActive (true);
		highscoresWindow.SetActive (false);
	}

	public void HighScoresWindowButton(){
		highscores.GetComponent<Button> ().interactable = false;
		highscores.GetComponent<Image> ().sprite = btnDOWN;

		main.GetComponent<Button> ().interactable = true;
		powerups.GetComponent<Button> ().interactable = true;
		shop.GetComponent<Button> ().interactable = true;

		main.GetComponent<Image> ().sprite = btnUP;
		powerups.GetComponent<Image> ().sprite = btnUP;
		shop.GetComponent<Image> ().sprite = btnUP;

		mainWindow.SetActive (false);
		powerupsWindow.SetActive (false);
		shopWindow.SetActive (false);
		highscoresWindow.SetActive (true);
	}


}
