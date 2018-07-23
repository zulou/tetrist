﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	
	public GameObject[] groups;
	
	
	void Start () {
		spawnNext ( ) ; 
	}
	void Update () {
		
	}
	 public void spawnNext ( ) {
		// Random Index
		int i = Random.Range( 0 , groups.Length) ;

		// Spawn Group at current Position
		Instantiate ( groups[ i ],transform.position ,Quaternion.identity ) ;
	} 
}
