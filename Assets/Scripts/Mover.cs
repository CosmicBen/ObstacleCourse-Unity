using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.0f;
    private Rigidbody myRigidbody;

    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        PrintInstructions();    
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");

        transform.Translate(xValue * moveSpeed * Time.deltaTime, 0.0f, zValue * moveSpeed * Time.deltaTime);
    }

    private void PrintInstructions()
    {
        Debug.Log("Welcome to the game.");
        Debug.Log("Move your player with WASD or arrow keys.");
        Debug.Log("Don't hit the walls!");
    }
}
