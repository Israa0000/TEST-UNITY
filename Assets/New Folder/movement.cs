using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] Transform target;
    Vector3 playerPosition;
    Vector3 targetPosition;

    void Start()
    {
        playerPosition = new Vector3(0,0,0);
    }

    void Update()
    {
        targetPosition = target.position;
        gameObject.transform.position = playerPosition;

        Vector3 direction = (targetPosition - playerPosition);

        float acceleration =+ speed * Time.deltaTime;

        playerPosition += direction * acceleration;
    }
}