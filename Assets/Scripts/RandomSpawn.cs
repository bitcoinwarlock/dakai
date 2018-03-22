using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

    public GameObject prefab;
	int i = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		i++;
		if(i == 60) { 
			Spawn();
			i = 0;
		}
	}

    void Spawn() {
		Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f));
		Instantiate(prefab, position, Quaternion.identity);
	}

}
