using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/FloatGameEvent")]
public class FloatGameEventSO : GameEventBaseSO
{
    private UnityAction<float> listeners;

    public void Raise(float value)
    {
        if (listeners != null)
            listeners.Invoke(value);
    }

    public void RegisterListener(FloatGameEventListenerSO listener) { listeners += listener.OnEventRaised; }

    public void UnregisterListener(FloatGameEventListenerSO listener) { listeners -= listener.OnEventRaised; }
}
