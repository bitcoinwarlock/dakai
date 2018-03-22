using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactible : MonoBehaviour {

	[TextArea(3,10)]
	public string dialogue;
	private string output;
	public Text subtitle;

	private int counter;
	string[] lines;

	// Use this for initialization
	void Start () {
		//Split lines into array
		lines = dialogue.Split ('\n');
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Speak () {

		//increment through list of lines each time method is called
		output = lines [counter];
		subtitle.text = output;
		counter += 1;
	}
}
