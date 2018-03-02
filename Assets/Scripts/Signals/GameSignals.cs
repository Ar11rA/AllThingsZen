using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

// Controller Signal
public class ButtonClickedSignal : Signal<ButtonClickedSignal> {}

// Presenter Signal
public class ShowTextSignal : Signal<ShowTextSignal, string> {}

public class ChangedSceneSignal : Signal<ChangedSceneSignal, int> {}