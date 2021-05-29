using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/GameEvent")]
public class GameEventSO : GameEventBaseSO
{
    private List<GameEventListenerSO> listeners = new List<GameEventListenerSO>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
            listeners[i].OnEventRaised();
    }

    public void RegisterListener(GameEventListenerSO listener)
    { listeners.Add(listener); }

    public void UnregisterListener(GameEventListenerSO listener)
    { listeners.Remove(listener); }
}