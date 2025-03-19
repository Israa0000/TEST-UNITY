using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform[] currentOrbit;
    int currentIndex;

    private void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        CameraChanger();
    }

    void CameraChanger()
    {
        if (currentOrbit.Length == 0) return;

        currentIndex++;
        if (currentIndex >= currentOrbit.Length)
        {
            currentIndex = 0;
        }

        //transform.position = new vector3 (currentOrbit[currentIndex].position);
        transform.rotation = currentOrbit[currentIndex].rotation;
    }

}
