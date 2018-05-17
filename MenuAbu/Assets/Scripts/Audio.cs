using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Audio : MonoBehaviour {

	private AudioSource backgroundMusic;
	void Start()
	{
		backgroundMusic = GameObject.FindWithTag("Music").GetComponent<AudioSource>();
		backgroundMusic.mute = true;
		StartCoroutine(playInstructions());
	}

	IEnumerator playInstructions()
	{
		AudioSource sonido = GetComponent<AudioSource>();
		sonido.Play ();
		yield return new WaitForSeconds(sonido.clip.length);
		backgroundMusic.mute = false;
	}
}
