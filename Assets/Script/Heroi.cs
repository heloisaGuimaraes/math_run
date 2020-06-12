using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System.Collections;

public class Heroi : MonoBehaviour {

	Animator animator;
	float axis;
	Vector2 velocidade;
	bool ladoDireito = true;
	bool noChao = true;
	float chaoCheckRaio = 0.2f;

	public float MaxVelocidade = 10;

	public Transform ChaoCheck;
	public LayerMask OQueEChao;
	public GameObject _button;
	Botao _component;

	public GameObject _button2;
	NewButton _component2;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		_component = _button.GetComponent <Botao> ();
		_component2 = _button2.GetComponent <NewButton> ();
	
	}

	 public void Update(){
		transform.eulerAngles = new Vector3 (0, 0, 0);
		noChao = Physics2D.OverlapCircle (ChaoCheck.position, chaoCheckRaio, OQueEChao);
		animator.SetBool ("NoChao", noChao);
		//bott = Input.GetAxis ("Horizontal");

		axis = _component.pressing; 
		if (_component2.precionar < 0 ){
			axis = _component2.precionar;
		}

		if (axis > 0 && !ladoDireito){//Virado pra esquerda, botao Direito
			
		Vire ();

		}
		if (axis < 0 && ladoDireito){
			
		Vire ();
		}
		velocidade = new Vector2 (axis * MaxVelocidade, GetComponent<Rigidbody2D> ().velocity.y);
		animator.SetFloat ("Velocidade", Mathf.Abs (axis));
		GetComponent<Rigidbody2D> ().velocity = velocidade;
		animator.SetFloat("VelocidadeVertical", GetComponent<Rigidbody2D>().velocity.y );//teste

	} 
	 
	// Pular
	public void cima(){
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 900));
			animator.SetBool ("NoChao", false);
		}


	void Vire (){
		
		ladoDireito = !ladoDireito;
		Vector2 novoScale = new Vector2 (transform.localScale.x * -1, transform.localScale.y);
		transform.localScale = novoScale;

	}

	void OnCollisionEnter2D(Collision2D colisao){
		if (colisao.gameObject.tag == "Iniciar"){
			Pontuacao.pontos = 0;
			SceneManager.LoadScene (Random.Range(5, SceneManager.sceneCount));
			//SceneManager.LoadScene ("Fase1");
		}
		if (colisao.gameObject.tag == "Bau"){
			Pontuacao.pontos += 1;
			//SceneManager.LoadScene ("Fase2");
			SceneManager.LoadScene (Random.Range(5, SceneManager.sceneCount));
		}
		if (colisao.gameObject.tag == "Erro"){
			JogarNovamente.erros += 1;
			//SceneManager.LoadScene ("GameOver");

		}

	}
		
}
