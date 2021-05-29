using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 3;
    [SerializeField]
    private float smooth = 0.5f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        // rb.velocity = rb.transform.forward * speed;
    }
    public void OnMove(Vector2 direction)
    {
        Move(direction);
    }
    public void OnMove(float direction)
    {
        Move(direction);
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        Vector3 targetVelocity = rb.transform.forward * speed;
        rb.velocity = Vector3.Lerp(rb.velocity, targetVelocity, smooth * Time.deltaTime);
    }
    private void Move(Vector2 direction)
    {

        var angle = Mathf.Atan2(direction.y, -direction.x) * Mathf.Rad2Deg;
        rb.rotation = Quaternion.AngleAxis(angle, rb.transform.up);

    }
    private void Move(float angle)
    {
    }
    /*
        private void Move(Vector2 direction)
    {
        Vector3 rotation = new Vector3(direction.x, direction.y, 0);

        float angle = Vector3.Angle(Vector3.right, direction);

        if (direction.x < 0.0f) angle %= 360.0f;

        rb.rotation = Quaternion.AngleAxis(angle * speed, Vector3.up);
    }
    */
}
