using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    [SerializeField] private Vector2GameEventSO moveEvent;
    [SerializeField] private FloatGameEventSO floatMoveEvent;
    private Vector2 firstClickPoint;
    private Vector2 currentClickPoint;

    [SerializeField] private bool isDragging = false;
    public void OnClick()
    {
        isDragging = true;
        firstClickPoint = Input.mousePosition;
    }

    public void OnClickUp()
    {
        isDragging = false;
        firstClickPoint = Vector2.zero;
    }
    public void Update()
    {
        if (!isDragging) return;

        currentClickPoint = Input.mousePosition;

        Vector2 delta = currentClickPoint - firstClickPoint;
        delta.Normalize();
        moveEvent.Raise(delta);
    }

}
