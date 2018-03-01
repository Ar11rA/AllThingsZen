using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller {

	public override void InstallBindings() {
		PresenterSignals ();
		ControllerSignals ();
		Container.BindInterfacesAndSelfTo<HelloWorldController> ().AsSingle ();
	}

	private void PresenterSignals() {
		Container.DeclareSignal<ShowTextSignal> ();
	}

	private void ControllerSignals() {
		Container.DeclareSignal<ButtonClickedSignal> ();
	}
}
