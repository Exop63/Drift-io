using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform target;
    private Vector3 diff;
    void Awake()
    {
        diff = transform.position - target.position;
    }

    void Update()
    {
        transform.position = target.position + diff;
    }
}
