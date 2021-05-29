using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloatGameEventListenerSO : MonoBehaviour
{
    public FloatGameEventSO Event;
    public UnityEvent<float> Response;

    private void OnEnable()
    { Event.RegisterListener(this); }

    private void OnDisable()
    { Event.UnregisterListener(this); }

    public void OnEventRaised(float value)
    { Response.Invoke(value); }
}
