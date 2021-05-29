using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineShower : MonoBehaviour
{
    [SerializeField] private SpringJoint springJoint;
    [SerializeField] private LineRenderer lineRenderer;

    void Update()
    {
        lineRenderer.SetPosition(0, springJoint.transform.position);
        lineRenderer.SetPosition(1, springJoint.connectedBody.transform.position);
    }
}
