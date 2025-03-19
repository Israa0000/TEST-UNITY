using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    Rigidbody2D rb;
    [SerializeField] float acceleration;
    Transform targetPosition;

    void Velocity() {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //direction = targetPosition.position - transform.position).normalicen;
        //rb.velocity = rb.velocity.normaliced * 
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(
        Random.Range(-1, 1),
        Random.Range(-1, 1)
        );
        rb.velocity =+ acceleration * direction * Time.deltaTime;
    }

}
