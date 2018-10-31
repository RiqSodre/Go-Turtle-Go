using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cans : MonoBehaviour {

    public float offset;
    public GameObject player;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        offset = Random.Range(20.0f, 70.0f);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		if(player.transform.position.x > transform.position.x - offset)
        {
            rb.isKinematic = false;
        }
	}
}
