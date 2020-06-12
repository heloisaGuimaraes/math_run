using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Cronometo : MonoBehaviour {
	public float timer = 20;
	//private float oldTimer;
	private bool isRunning;


	// Use this for initialization
	void Start () {
		isRunning = true;
		//oldTimer = timer;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isRunning){
			timer -= Time.deltaTime;
			GetComponent<Text> ().text = "Tempo: " + Mathf.RoundToInt (timer).ToString () + "s";
		}
		if (timer < 0){
			isRunning = false;
			SceneManager.LoadScene ("GameOver");



		}	
	}
}
