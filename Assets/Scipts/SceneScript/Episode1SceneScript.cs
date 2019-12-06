using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Episode1SceneScript : MonoBehaviour {

	public void Episode1SceneChange() {
		Debug.Log("버튼눌림");
		SceneManager.LoadScene("Episode1Scene");
	}
}
