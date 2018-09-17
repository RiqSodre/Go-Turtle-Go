using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    #region Váriaveis
    public int energia = 0;
    public float velocidadeX = -2f;

    public float velocidadeY = 30f; 
    public float velocidadeAtual = 6f;
    #endregion

    void Update () {
        DontBlock();
   
        transform.position += new Vector3(velocidadeAtual, Input.acceleration.x * velocidadeY, 0)*Time.deltaTime;
        
        
    }

    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.CompareTag("Inimigo"))
    //    {
    //        velocidadeAtual = velocidadeNegativa;
    //    }
    //}

     void DontBlock()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
