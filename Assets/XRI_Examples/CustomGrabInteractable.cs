using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class CustomGrabInteractable : XRGrabInteractable
{
    Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        Debug.Log("Enter up!");
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        Debug.Log("Exit up!");
        rigidbody.AddForce(new Vector3(0, 200, 0));
    }
}
