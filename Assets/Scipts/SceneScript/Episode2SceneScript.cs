using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Episode2SceneScript : MonoBehaviour {

	public void Episode2SceneChange() {
		Debug.Log("버튼눌림");
		SceneManager.LoadScene("Episode2Scene");
	}
}
