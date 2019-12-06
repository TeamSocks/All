using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpisodeSelect2 : MonoBehaviour {

	public GameObject button;
	public GameObject cat1;
	public GameObject cat2;
	public GameObject cat3;
	public GameObject cat4;


	void Start () {
	}
	
	void Update () {
		
	}

	public void Click() {
		cat1.SetActive(false);
		cat2.SetActive(true);
		cat3.SetActive(false);
		cat4.SetActive(false);
	}
}
