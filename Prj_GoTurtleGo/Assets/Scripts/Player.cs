using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    #region Váriaveis
    public int energia = 0;
    public float velocidadeX = 0.25f;

    public float velocidadeY = 30f; 
    public float velocidadeAtual = 0f;
   // public float velocidadeNegativa = -8f;
    #endregion

    void Update () {
        DontLock();

        transform.position += new Vector3(velocidadeAtual, Input.acceleration.x * velocidadeY, 0)*Time.deltaTime;

        if(velocidadeAtual < 7 && energia < 5)
        {
            velocidadeAtual += velocidadeX;
        }
        
    }

    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.CompareTag("Inimigo"))
    //    {
    //        velocidadeAtual = velocidadeNegativa;
    //    }
    //}

     void DontLock()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
