using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Episode3SceneScript : MonoBehaviour {

	public void Episode3SceneChange() {
		Debug.Log("버튼눌림");
		SceneManager.LoadScene("Episode3Scene");
	}
}
