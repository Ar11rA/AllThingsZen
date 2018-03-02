using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller {

	public override void InstallBindings() {
		PresenterSignals ();
		ControllerSignals ();
		ManagerBindings ();
		ControllerBindings ();
	}

	private void PresenterSignals() {
		Container.DeclareSignal<ShowTextSignal> ();
	}

	private void ControllerSignals() {
		Container.DeclareSignal<ButtonClickedSignal> ();
		Container.DeclareSignal<ChangedSceneSignal> ();
	}

	private void ManagerBindings() {
		Container.Bind<IGameManager> ().To<GameManager>().AsSingle ();
	}

	private void ControllerBindings() {
		Container.BindInterfacesAndSelfTo<HelloWorldController> ().AsSingle ();
		Container.BindInterfacesAndSelfTo<GameController> ().AsSingle ();

	}
}
