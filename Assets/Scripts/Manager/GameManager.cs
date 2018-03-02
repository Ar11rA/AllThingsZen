using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : IGameManager {

	public void changeScene(int sceneId) {
		Debug.Log("Scene Change triggered");
		SceneManager.LoadScene(sceneId);
	}
}
