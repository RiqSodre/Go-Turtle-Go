using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //Váriaveis para controlar a velocidade.
    public float speedY = 30f;
    public float currentSpeed = 0f;
    public float speedX = 10f;
    
	void Update () {
        transform.position += new Vector3(currentSpeed, Input.acceleration.x * speedY, 0) * Time.deltaTime;

        if(currentSpeed < 5)
            currentSpeed += speedX;
    }
}
