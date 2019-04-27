using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Orbital {

	public Orbital(){
		TimeToOrbit = 1;
		Children = new List<Orbital> ();
	}

	public Orbital Parent;
	public List<Orbital> Children;


	//public float OrbitalDistance;　　//AUを使う場合
	public UInt64 OrbitalDistance;
	public float Angle;    //公転角度
	public UInt64 TimeToOrbit;  //周り一周所要時間 　　　todo:Kepler's third law


	//惑星の位置をgameobjcetに渡す関数
	public Vector3 Position {

		//惑星の相対位置を計算し、絶対位置を渡す
		get {
			return new Vector3 (
				Mathf.Sin (Angle) * OrbitalDistance,
				Mathf.Cos (Angle) * OrbitalDistance,
				0);
		}
	}


	public int GraphicID;

	public void Update(UInt64 TimeSinceStart){
		//時間に基づいて角度を更新します
		Angle = TimeSinceStart/TimeToOrbit * 2 * Mathf.PI;


		for (int i = 0; i < Children.Count; i++) {
			Children [i].Update (TimeSinceStart);
		}
	}


	public void MakeEarth(){
		Angle = 0;
		OrbitalDistance = 150000000000;
		TimeToOrbit = 365 * 24 * 60 * 60;
	}

	public void AddChild(Orbital a){
		a.Parent = this;
		Children.Add (a);
	}

	public void RemoveChild(Orbital a){
		a.Parent = null;
		Children.Remove (a);
	
	}


}
