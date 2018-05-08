using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

/** 
 * 
 * @author Jonnathan Juárez (15377). Jennifer Barillas (15307)
 * 
 **/

public class Letter : MonoBehaviour {
		

	// Use this for initialization
	void Start () {

		GameController.instance.listaBotones.Add (this);
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
			GameController.instance.setWrongTaps(1);
		}
			
	}
}
