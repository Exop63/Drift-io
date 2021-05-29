using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/Vector2GameEvent")]
public class Vector2GameEventSO : GameEventBaseSO
{
    private UnityAction<Vector2> listeners;

    public void Raise(Vector2 value)
    {
        if (listeners != null)
            listeners.Invoke(value);
    }

    public void RegisterListener(Vector2GameEventListenerSO listener) { listeners += listener.OnEventRaised; }

    public void UnregisterListener(Vector2GameEventListenerSO listener) { listeners -= listener.OnEventRaised; }
}
