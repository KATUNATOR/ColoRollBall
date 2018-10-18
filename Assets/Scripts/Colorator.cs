using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorator : MonoBehaviour {

	private Renderer rendSelf;

	// Use this for initialization
	void Start () {
		rendSelf = GetComponent<Renderer>();
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Kek")) {
			Renderer renOther = other.gameObject.GetComponent<Renderer>();
			rendSelf.material.color = renOther.material.color;
			other.gameObject.SetActive(false);
		}
	}
}
