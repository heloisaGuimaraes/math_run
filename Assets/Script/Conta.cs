using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Conta : MonoBehaviour {
	
	public Text resu;
	public Text b1;
	public Text b2;
	public Text b3;


	private int a;
	private int b;
	private int res;

	private int sinal;
	private int sinais;




	// Use this for initialization
	void Start () {
		
		a = Random.Range (5, 12);
		b = Random.Range (2, 7); 
		sinal =  Random.Range (1, 6);
		sinais = Random.Range (1, 5);



	}

	// Update is called once per frame
	void FixedUpdate () {
		if (sinal == 1){
			res = a + b;
			GetComponent<Text> ().text = a.ToString() + " + " + b.ToString() + " = ?";
			resu.text =  res.ToString(); 
			b1.text = (res + 3).ToString(); 
			b2.text = (res - 1).ToString ();
			b3.text = (res + 1).ToString ();
			}
		else if (sinal == 2){
			res = a - b;
			GetComponent<Text> ().text = a.ToString() + " - " + b.ToString() + " = ?";
			resu.text = res.ToString();
			b1.text = (res + 3).ToString(); 
			b2.text = (res - 1).ToString ();
			b3.text = (res + 1).ToString ();
		}
		else if (sinal == 3){
			res = a * b;
			GetComponent<Text> ().text = a.ToString() + " x " + b.ToString() + " = ?";
			resu.text = res.ToString(); 
			b1.text = (res + 3).ToString(); 
			b2.text = (res - 1).ToString ();
			b3.text = (res + 1).ToString ();
		}
		else if (sinal == 4){
			while (a % b != 0){
				a ++;
			}
			res = a / b;
			GetComponent<Text> ().text = a.ToString() + " / " + b.ToString() + " = ?";
			resu.text = res.ToString(); 
			b1.text = (res + 3).ToString(); 
			b2.text = (res - 1).ToString ();
			b3.text = (res + 1).ToString ();
		}
		else if (sinal == 5 && sinais == 1){
			res = a + b;
			GetComponent<Text> ().text = a.ToString() + " ? " + b.ToString() + " = " + res.ToString();
			resu.text = "+";
			b1.text = "x"; 
			b2.text = "-";
			b3.text = "/";
		}
		else if (sinal == 5 && sinais == 2){
			res = a - b;
			GetComponent<Text> ().text = a.ToString() + " ? " + b.ToString() + " = " + res.ToString();
			resu.text = "-";
			b1.text = "x"; 
			b2.text = "+";
			b3.text = "/";
		}
		else if (sinal == 5 && sinais == 3){
			res = a * b;
			GetComponent<Text> ().text = a.ToString() + " ? " + b.ToString() + " = " + res.ToString();
			resu.text = "x";
			b1.text = "-"; 
			b2.text = "+";
			b3.text = "/";
		}
		else if (sinal == 5 && sinais == 4){
			while (a % b != 0){
				a ++;
			}
			res = a / b;
			GetComponent<Text> ().text = a.ToString() + " ? " + b.ToString() + " = " + res.ToString();
			resu.text = "/";
			b1.text = "-"; 
			b2.text = "+";
			b3.text = "x";
		}
	}

}

