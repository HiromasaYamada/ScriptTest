using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        int[] points = { 0, 1, 2, 3, 4 };

        for (int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }
        for (int i = 4; i > 0; i--)
        {
            Debug.Log(points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}