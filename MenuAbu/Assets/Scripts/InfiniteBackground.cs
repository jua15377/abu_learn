using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteBackground : MonoBehaviour {
	float scrollingSpeed = 50f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(1, 0, 0) * -scrollingSpeed * Time.deltaTime);
		if (transform.position.x <-250f)
		{
			transform.position = new Vector3(500f, transform.position.y, transform.position.z);
		}

	}
}