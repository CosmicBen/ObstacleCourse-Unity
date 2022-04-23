using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ObjectHit : MonoBehaviour
{
    private MeshRenderer myRenderer;

    private void Awake()
    {
        myRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Bumped into a wall");
            myRenderer.material.color = Color.red;
        }
    }
}
