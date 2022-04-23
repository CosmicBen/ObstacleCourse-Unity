using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(Rigidbody))]
public class Dropper : MonoBehaviour
{
    [SerializeField] private float dropTime = 5.0f;
    private Rigidbody myRigidbody;
    private MeshRenderer myRenderer;

    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRenderer = GetComponent<MeshRenderer>();

        myRigidbody.useGravity = false;
        myRenderer.enabled = false;
    }

    private void Update()
    {
        if (Time.time > dropTime)
        {
            myRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
