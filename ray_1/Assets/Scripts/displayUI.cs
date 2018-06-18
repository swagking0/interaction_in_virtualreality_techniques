using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayUI : MonoBehaviour {
	//butterbox
	public string myString;
	private Text myText;
	public float fadeTime;
	public bool displayInfo;
	//bananabox
	public string myString_1;
	private Text myText_1;
	public float fadeTime_1;
	public bool displayInfo_1;

	private bool infoman;
	private bool infoman_1;

	public RayCasting_test _scriptB;

	[SerializeField] private Image customImage;
	[SerializeField] private Image customImage_1;



	// Use this for initialization
	void Start () {
		myText = GameObject.Find ("Text").GetComponent<Text> ();
		myText.color = Color.clear;

		myText_1 = GameObject.Find ("Text").GetComponent<Text> ();
		myText_1.color = Color.clear;


	}
	
	// Update is called once per frame
	void Update () {
		FadeText ();
		infoman = _scriptB.displayplayer;
		infoman_1 = _scriptB.displayplayer_1;

		//Debug.Log (infoman);

		if (infoman == true) {
			displayInfo = true;
		} else if(infoman_1 == true){
			displayInfo_1 = true;
		}
		else {
			displayInfo = false;
			displayInfo_1 = false;
		}
	}

	void FadeText () {

		if (displayInfo) {

			myText.text = myString;
			myText.color = Color.Lerp (myText.color, Color.white, fadeTime * Time.deltaTime);
			customImage.enabled = true;
			//Debug.Log ("the object is hit. please look at your display for more information");
		} else if (displayInfo_1) {
			myText_1.text = myString_1;
			myText_1.color = Color.Lerp (myText_1.color, Color.white, fadeTime_1 * Time.deltaTime);
			customImage_1.enabled = true;
			//Debug.Log ("the object is hit. please look at your display for more information");
		}

		else {
			myText.color = Color.Lerp (myText.color, Color.clear, fadeTime * Time.deltaTime);
			myText_1.color = Color.Lerp (myText_1.color, Color.clear, fadeTime_1 * Time.deltaTime);
			customImage.enabled = false;
			customImage_1.enabled = false;
			Debug.Log ("there is no object selected. place the ray on object to know more about the objects");
		}
		
	}

}
