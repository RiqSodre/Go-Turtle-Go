using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rede : MonoBehaviour {

    Rigidbody2D rb;
    public float speed = 6;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

	void FixedUpdate () {
        rb.AddForce(transform.right * speed);
        rb.velocity = rb.velocity.normalized * speed;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(col.gameObject);
            SceneManager.LoadScene("Game Over");
        }
    }
}
