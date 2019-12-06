using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EpisodeSelectSceneScript : MonoBehaviour {

	public void EpisodeSelectSceneChange() {
		Debug.Log("버튼눌림");
		SceneManager.LoadScene("EpisodeSelectScene");
	}
}
