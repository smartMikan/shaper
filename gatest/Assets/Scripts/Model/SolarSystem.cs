using System;

public class SolarSystem : Orbital
{
	public void Generate(){
	
		Orbital myStar = new Orbital ();
		myStar.GraphicID = 0;
		this.AddChild (myStar);


		Orbital planet = new Orbital ();
		planet.MakeEarth ();
		planet.GraphicID = 1;
		myStar.AddChild (planet);

	}

}

