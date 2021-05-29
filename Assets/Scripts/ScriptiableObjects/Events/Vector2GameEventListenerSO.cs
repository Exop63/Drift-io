using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Vector2GameEventListenerSO : MonoBehaviour
{
    public Vector2GameEventSO Event;
    public UnityEvent<Vector2> Response;

    private void OnEnable()
    { Event.RegisterListener(this); }

    private void OnDisable()
    { Event.UnregisterListener(this); }

    public void OnEventRaised(Vector2 value)
    { Response.Invoke(value); }
}
