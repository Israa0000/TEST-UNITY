using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitAroundParent : MonoBehaviour
{
    public float orbitSpeed; 

    void Update()
    {
        transform.Rotate(Vector3.forward, orbitSpeed * Time.deltaTime);
    }
}