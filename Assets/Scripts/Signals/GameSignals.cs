using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

// Controller Signal
public class ButtonClickedSignal : Signal<ButtonClickedSignal> {}
public class ChangedSceneSignal : Signal<ChangedSceneSignal, int> {}

// Presenter Signal
public class ShowTextSignal : Signal<ShowTextSignal, string> {}

