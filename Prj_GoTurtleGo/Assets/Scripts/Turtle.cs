using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour {

    public float speed = 20f;
	
	void Update () {
        transform.position += new Vector3(Input.acceleration.x, Input.acceleration.y, 0) * Time.deltaTime * speed;
	}
}
