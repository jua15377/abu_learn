using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/** 
 * Esta sera la clase utilizada para cambiar entre el menú principal y las demás escenas
 * 
 * @author Jonnathan Juárez (15377). Jennifer Barillas (15307)
 * 
 **/
public class SceneChanger : MonoBehaviour {
	public Text highscore; //cuenta de el puntaje más alto de todas las jugadas. 
	public Text currentScore; //cuenta del puntaje de la jugada actual
	
	//public Text contadorText;

	// Use this for initialization
	void Start () {
		highscore.text = PlayerPrefs.GetInt ("Highscore").ToString(); // para que cambie el texto que aparece en el menu
		// por el highscore
		currentScore.text = PlayerPrefs.GetInt ("Score").ToString();
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void OnStartGame(string scene)
	{
		SceneManager.LoadScene (scene); //cambio de escenas
		if (scene == "menuPrincipal") {
			PlayerPrefs.SetInt ("Score", 0); //cuando el juego inicie, también se reinicia el puntaje de la jugada actual
		} 
	}
}
