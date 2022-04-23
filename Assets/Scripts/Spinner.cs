using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xAngle = 0;
    [SerializeField] private float yAngle = 0;
    [SerializeField] private float zAngle = 0;

    private void Update()
    {
        transform.Rotate(xAngle * Time.deltaTime, yAngle * Time.deltaTime, zAngle * Time.deltaTime);
    }
}
