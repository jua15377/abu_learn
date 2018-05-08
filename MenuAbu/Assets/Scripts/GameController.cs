using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

/** 
 * 
 * @author Jonnathan Juárez (15377). Jennifer Barillas (15307)
 * 
 **/
public class GameController : MonoBehaviour {
	public bool gameOver = false;
	public bool winner = false;
	public int score;
	public static GameController instance;
	public SceneChanger sm;
	public Text Pointstxt;
	public Text GO;
	public Text winnerTxt;
	private float timeOver =0;
	public string nextscene; 
	public ArrayList listaBotones;  //para tener guardadas todas las instancias de los botones en la pantalla actual
	public string thisScene;
	private int letterInstances=0; //Para contar cuántas letras correctas ha presionado.
	private int wrongTap=0; //contador para verificar cuantas veces ha presionado la letra incorrecta.

	// Use this for initialization
	void Start () {
		instance = this;
	//	Pointstxt.text = PlayerPrefs.GetInt ("Score").ToString (); // para que muestre en pantalla el score actual
		score = PlayerPrefs.GetInt ("Score");
		winnerTxt.gameObject.SetActive (false);
		listaBotones = new ArrayList ();
	}

	// Update is called once per frame
	void Update () {
	//	Pointstxt.text = score.ToString (); // para que muestre en pantalla el score actual
	/**	if (gameOver == true) {
			timeOver += Time.deltaTime;
			GO.gameObject.SetActive (true);
			int currentHighScore = PlayerPrefs.GetInt ("Highscore");
			if (score > currentHighScore) {
				PlayerPrefs.SetInt ("Highscore", score); //en el caso que el score actual sea mayor que el highscore guardado
			}
			if (timeOver > 3) {
				sm.OnStartGame (thisScene);// avanzar de nivel
				sm.highscore.text = PlayerPrefs.GetInt ("Highscore").ToString (); // para que cambie el texto que aparece en el menu
				// que se guarde el actual como el highscore
				timeOver = 0;
			}
			PlayerPrefs.SetInt ("Score", 0); //se setea el score a 0. 
		} **/
		if (winner == true) { //el jugador ha presionado correctamente las tres letras, ganando el nivel
			winnerTxt.gameObject.SetActive (true); //activar el texto que anuncia que el jugador ha ganado el nivel. 
			foreach (Letter letra in listaBotones) { //se harán desaparecer todas las letras una vez se haya ganado
				letra.gameObject.SetActive (false);
			}
			timeOver += Time.deltaTime;
			if (timeOver > 3) {
				PlayerPrefs.SetInt ("Score", score); // cuando se agreguen puntos, que tambien se guarden en el playerprefs
				sm.OnStartGame (nextscene);
				// que se guarde el actual como el highscore
				timeOver = 0;
			}
		}
	}
	public void setLetterInstances(int value)
	{
		letterInstances += value;
		if (letterInstances == 3) {
			winner = true;
		}
	}
	public void setWrongTaps(int value)
	{
		wrongTap += value;
		if (wrongTap > 7) {
			gameOver = true;
		}
	}
}
