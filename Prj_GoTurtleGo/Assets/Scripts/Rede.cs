using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rede : MonoBehaviour {

    Rigidbody2D rb;
    public GameObject player;
    public float speed = 3;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

	void FixedUpdate () {
        rb.AddForce(transform.right * speed);
        rb.velocity = rb.velocity.normalized * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
         Destroy(gameObject);
    }
}
