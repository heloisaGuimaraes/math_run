using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pontuacao : MonoBehaviour {
	public static int pontos;
	public static int highScore;
	public Text pontosTXT;
	public Text highScoreTXT;


	// Use this for initialization
	void Start () {
		highScore = PlayerPrefs.GetInt ("highScore", highScore);
	
	}
	
	// Update is called once per frame
	void Update () {
		pontosTXT.text = pontos.ToString ();
		highScoreTXT.text = "High Score: " + highScore.ToString ();


		if (pontos > highScore){
			highScore = pontos;
			highScoreTXT.text = "High Score: " + highScore.ToString ();

			PlayerPrefs.SetInt ("highScore", highScore);
		}

	}
}
