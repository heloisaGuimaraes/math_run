﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Certeza : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void JogarN(){
		SceneManager.LoadScene ("Iniciar");
	}

	public void Sair(){
		Application.Quit ();
	}
}
