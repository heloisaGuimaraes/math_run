using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
     
public class JogarNovamente : MonoBehaviour {
	public Text errosTXT;
	public static int erros;


	public void JogarN(){
	SceneManager.LoadScene ("Iniciar");
	}
	public void Certeza(){
		SceneManager.LoadScene ("Certeza");
	}



	void Update(){
		errosTXT.text = "Erros: " + erros.ToString ();
	}
}
