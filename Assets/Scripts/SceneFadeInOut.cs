using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class SceneFadeInOut : MonoBehaviour {

	public Image _image;
	public float FadeTime; //Time to fade in in seconds
	public GameObject player;


	// Use this for initialization
	void Start () {
		//_image.GetComponent<"Image">.enabled = true;
		FadeIn (FadeTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FadeIn(float seconds) {
		_image.CrossFadeAlpha (0, seconds, false);
		//GameObject.Find ("FPSController").GetComponent<FirstPersonCharacter>().enabled = true;
		//player.SendMessage("GetComponent<FirstPersonController>.enabled = true");
	}
}
