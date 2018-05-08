using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/** 
 * 
 * @author Jonnathan Juárez (15377). Jennifer Barillas (15307)
 * 
 **/

public class firstScreenOP : MonoBehaviour {
    //ir a menu
    public void gotoMenu() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }//salir del juego
    public void quitGame() {
        Application.Quit();
    }
}
