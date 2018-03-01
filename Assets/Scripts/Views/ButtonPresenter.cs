using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using UnityEngine.UI;

public class ButtonPresenter : MonoBehaviour {

	private ButtonClickedSignal _buttonClickedSignal;
	private ShowTextSignal _showTextSignal;

	[Inject]
	public void Init (ButtonClickedSignal buttonClickedSignal, ShowTextSignal showTextSignal) {
		_buttonClickedSignal = buttonClickedSignal;
		_showTextSignal = showTextSignal;
	}

	void Start () {
		Button button = GetComponent<Button> () as Button;
		button.onClick.AddListener(OnClick);
	}

	public void OnClick() {
		_buttonClickedSignal.Fire();
		_showTextSignal.Fire ("Hello world");
	}
}
