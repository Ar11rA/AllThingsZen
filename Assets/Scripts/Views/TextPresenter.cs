using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class TextPresenter : MonoBehaviour {

	private ShowTextSignal _showTextSignal;
	private Text _textComponent;

	[Inject]
	public void Init(ShowTextSignal showTextSignal){
		_showTextSignal = showTextSignal;
		_showTextSignal.Listen (ChangeText);
	}

	void Start() {
		_textComponent = GetComponent<Text> () as Text;
	}

	private void ChangeText(string text) {
		_textComponent.text = text;
	}
}
