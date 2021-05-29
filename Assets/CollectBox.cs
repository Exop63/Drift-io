using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectBox : MonoBehaviour
{
    public UnityEvent onCollect;

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Contains("box"))
        {
          //  onCollect.Invoke();
            Destroy(other.gameObject);
        }
    }
}
