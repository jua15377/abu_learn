using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelScripOP : MonoBehaviour {
	public void gotoaei(){
		SceneManager.LoadScene ("levels_0");
	}

	public void gotoABC(){
		SceneManager.LoadScene ("levels_1");
	}

	public void goto123(){
		SceneManager.LoadScene ("levels_2");
	}

	public void gotoMainScreen(){
		SceneManager.LoadScene (0);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
