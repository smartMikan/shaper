using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void OnEnable () {
		Galaxy = new Galaxy ();
		Galaxy.Generate (1);
	}

	public Galaxy Galaxy;

	// Update is called once per frame
	void Update () {
		
	}
}
