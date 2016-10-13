using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerStart : MonoBehaviour {


	// Use this for initialization
	void Start () {
		MovieTexture movieTexture = ((MovieTexture)GetComponent<Renderer> ().material.mainTexture);
		movieTexture.loop = true;
		movieTexture.Play();

	}
	
	// Update is called once per frame
	void Update () {
	}
}

