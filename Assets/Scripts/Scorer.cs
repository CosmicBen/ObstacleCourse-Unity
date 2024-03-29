﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Hit"))
        {
            collision.gameObject.tag = "Hit";
            hits++;
            Debug.Log("You have bumped into a thing this many times: " + hits);
        }
    }
}
