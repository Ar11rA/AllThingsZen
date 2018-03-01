using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class HelloWorldController: IInitializable, ILateDisposable{

	private ButtonClickedSignal _buttonClickedSignal;

	public void Initialize() {
		_buttonClickedSignal += OnButtonClick;
	}

	[Inject]
	public HelloWorldController (ButtonClickedSignal buttonClickedSignal) {
		_buttonClickedSignal = buttonClickedSignal;
	}

	void OnButtonClick() {
		Debug.Log ("Controller Called");
	}

	public void LateDispose() {
		_buttonClickedSignal -= OnButtonClick;
	}
}
