using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    //Váriaveis para controlar a velocidade.
    public float speedY = 30f;              //Velocidade vertical.
    public float currentSpeed = 0.0f;       //Velocidade atual.
    
	void Update () {
        transform.position += new Vector3(currentSpeed, Input.acceleration.x * speedY, 0) * Time.deltaTime;

        if(currentSpeed < 7)
            currentSpeed += 1;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Inimigo"))
        {
            currentSpeed = -2;
        }
    }
}
