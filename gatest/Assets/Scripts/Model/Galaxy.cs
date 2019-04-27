using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galaxy {

	public Galaxy(){
		SolarSystems = new List<SolarSystem>();
	}

	public List<SolarSystem> SolarSystems;

	public void Generate(int numStars){
		for (int i = 0; i < numStars; i++) {
			SolarSystem ss = new SolarSystem();
			ss.Generate ();

			SolarSystems.Add (ss);
		}
	}

	public void LoadFromFile(string fileName){
	
	}
}
