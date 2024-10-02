using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterctableAddForce : MonoBehaviour
{
    private Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void AddForceUp()
    {
        Debug.Log("UP!!");
        rigidbody.AddRelativeForce(new Vector3(0, 200, 0));
    }
}
