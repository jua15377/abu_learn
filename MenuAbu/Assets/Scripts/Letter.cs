using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using System.Runtime.CompilerServices;
using System;
using UnityEngine.UI;

/** 
 * 
 * @author Jonnathan Juárez (15377). Jennifer Barillas (15307)
 * 
 **/

public class Letter : MonoBehaviour {
		

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (GameController.instance.getLetterInstances () == 3 || GameController.instance.gameOver == true) {
			this.gameObject.SetActive (false);
		}
	}

	/**
	 * El parámetro ID sirve para identificar si la letra que se presionó es la correcta. 
	 * 
	 **/
	public void clickOnLetter(int ID) 
	{
		if (ID == 1) {
			GameController.instance.score += 10; //si presiona la letra correcta, aumenta el score +10
			GameController.instance.setLetterInstances(1);
			this.gameObject.SetActive (false); //para hacer la letra "desaparecer"
		} else {
			if (GameController.instance.score >= 0) {
				GameController.instance.score -= 2;
				GameController.instance.setWrongTaps(1);
				Handheld.Vibrate ();
			}
		}
			
	}

}
