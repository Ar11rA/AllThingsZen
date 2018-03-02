using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using UnityEngine.UI;

public class ChangeScenePresenter : MonoBehaviour {

	private ChangedSceneSignal _changedSceneSignal;

	[Inject]
	public void Init (ChangedSceneSignal changedSceneSignal) {
		_changedSceneSignal = changedSceneSignal;
	}

	void Start () {
		Button button = GetComponent<Button> () as Button;
		button.onClick.AddListener(OnClick);
	}

	public void OnClick() {
		_changedSceneSignal.Fire(1);
	}
}
