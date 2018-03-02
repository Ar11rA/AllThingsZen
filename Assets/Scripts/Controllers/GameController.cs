using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameController: IInitializable, ILateDisposable{

	private ChangedSceneSignal _changedSceneSignal;

	private IGameManager _gameManager;

	public void Initialize() {
		_changedSceneSignal += OnChangeScene;
	}

	[Inject]
	public GameController (IGameManager gamemanager, ChangedSceneSignal changedSceneSignal) {
		_changedSceneSignal = changedSceneSignal;
		_gameManager = gamemanager;
	}

	void OnChangeScene(int id) {
		_gameManager.changeScene(id);
	}

	public void LateDispose() {
		_changedSceneSignal -= OnChangeScene;
	}
}
