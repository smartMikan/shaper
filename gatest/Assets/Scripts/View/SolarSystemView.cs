using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemView : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gc = GameObject.FindObjectOfType<GameController>();
		ShowSolarSystem (0);

	}
	public Sprite[] Sprites;
	public ulong zoomLevels = 100000000000; // zoom unit

	GameController gc;
	SolarSystem solarSystem;

	public void ShowSolarSystem(int solarSystemID){
		solarSystem = gc.Galaxy.SolarSystems [solarSystemID];

		for (int i = 0; i < solarSystem.Children.Count; i++) {

			//Orbital o = solarSystem.Children [i];
			MakeSpritesForOrbital(this.transform, solarSystem.Children[i]);

		}
	}

	void MakeSpritesForOrbital(Transform transformParent,Orbital o){
		GameObject go = new GameObject ();
		go.transform.SetParent (transformParent);

		//set position
		go.transform.position = o.Position/zoomLevels ;


		SpriteRenderer sr = go.AddComponent<SpriteRenderer> ();
		sr.sprite = Sprites [o.GraphicID]; 

		for (int i = 0; i < o.Children.Count; i++) {
			MakeSpritesForOrbital (go.transform, o.Children [i]);
		
		}

	}
	// Update is called once per frame
	void Update () {
		
	}
}
