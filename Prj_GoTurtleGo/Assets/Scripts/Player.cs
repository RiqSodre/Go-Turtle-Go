using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    #region Váriaveis
    public int energia;
    public int folego;
    public float velocidade;

    public float speedY = 30f; 
    public float currentSpeed = 0.0f;
    public float negativeSpeed = -8f;
    #endregion

    void Update () {
        transform.position += new Vector3(currentSpeed, Input.acceleration.x * speedY, 0) * Time.deltaTime;

        if(currentSpeed < 7)
            currentSpeed += 0.25f;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Inimigo"))
        {
            currentSpeed = negativeSpeed;
        }
    }
}
