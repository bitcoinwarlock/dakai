using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	//string[] message = { "First.", "Second.", "Third.", "Fourth." };
	public TextAsset textFile;
	string[] dialogueLines;
	int counter = 0;
	public Text dialog;
	public float fadeTime;
	public float displayTime;
	private float displayCounter;

		
	// Use this for initialization
	void Start () {
		//dialogueLines = (textFile.text.Split('@'));
		//	dialog.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		displayCounter += Time.deltaTime;

		/*if (displayCounter > displayTime) {
			Speak ();
			displayCounter = 0;
		}*/

	}

	void Speak () {

		//FIRST ITERATION

		/*Debug.Log (message[counter]);
		//dialog.enabled = true;

		dialog.text = dialogueLines[counter];
		//dialog.CrossFadeAlpha (255, fadeTime, false);

		StartCoroutine (Display ());

		//dialog.CrossFadeAlpha (0, fadeTime, false );
		//dialog.enabled = false;
		counter++*/

		//SECOND ITERATION


	}

	IEnumerator Display() {
		yield return new WaitForSecondsRealtime(displayTime);
	}
}
