using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayUI : MonoBehaviour {

	public float fadeTime;
	public float speed;
	//butterbox
	public string myString;
	private Text myText;
	public bool displayInfo;
	private bool infoman;
	//bananabox
	public string myString_1;
	private Text myText_1;
	public bool displayInfo_1;
	private bool infoman_1;

	private GameObject hello;
	private GameObject t;
	private GameObject hello1;
	private GameObject t1;

	public RayCasting_test _scriptB;

	[SerializeField] private Image customImage;
	[SerializeField] private Image customImage_1;
	[SerializeField] private Transform spawnPoint;


	// Use this for initialization
	void Start () {
		myText = GameObject.Find ("Text").GetComponent<Text> ();
		myText.color = Color.clear;

		myText_1 = GameObject.Find ("Text").GetComponent<Text> ();
		myText_1.color = Color.clear;

		hello = GameObject.Find("box_example_1");
		hello1 = GameObject.Find("box_example_2");
	}
	
	// Update is called once per frame
	void Update () {
		FadeText ();
		changepostion ();
		letmetry ();
		infoman = _scriptB.displayplayer;
		infoman_1 = _scriptB.displayplayer_1;

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
		} else if (displayInfo_1) {
			myText_1.text = myString_1;
			myText_1.color = Color.Lerp (myText_1.color, Color.white, fadeTime * Time.deltaTime);
			customImage_1.enabled = true;
		}

		else {
			myText.color = Color.Lerp (myText.color, Color.clear, fadeTime * Time.deltaTime);
			myText_1.color = Color.Lerp (myText_1.color, Color.clear, fadeTime * Time.deltaTime);
			customImage.enabled = false;
			customImage_1.enabled = false;
		}
		
	}

	void changepostion(){
		if (displayInfo && Input.GetKeyDown (KeyCode.X)) {
			t = Instantiate(hello);
			t.transform.position = spawnPoint.position;
		}
		else if(Input.GetKeyDown(KeyCode.C)){
			Destroy (t);
			Destroy (t1);
		} 
		else if (displayInfo_1 && Input.GetKeyDown (KeyCode.X)) {
			t1 = Instantiate (hello1);
			t1.transform.position = spawnPoint.position;
		} 
	}

	void letmetry(){
		transform.Rotate (0, speed, 0);
	}

}
