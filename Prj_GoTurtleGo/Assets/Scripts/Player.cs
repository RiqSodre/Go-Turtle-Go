using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public bool comeu;
    public int energia = 0;
    public float velocidadeX = 2f;

    public float velocidadeY = 30f; 
    public float velocidadeAtual = 6f;

    void Update () {
        DontBlock();
        //Movimento do acelerometro.
        transform.position += new Vector3(velocidadeAtual, Input.acceleration.x * velocidadeY, 0)*Time.deltaTime;
        
        //Energia.
        if (energia < 5 && comeu)
        {
            energia += 1;
            comeu = false;

            if (energia == 5)
            {
                velocidadeAtual += 5f;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("AguaViva"))
        {
            GameManager.Instance.AddPoints(1);
            Destroy(col.gameObject);
        }
        else if(col.gameObject.CompareTag("Latinha"))
        {
            velocidadeAtual -= velocidadeAtual;
        }
        //else if (col.gameObject.CompareTag("Pedra"))
        //{

        //}
        //else if (col.gameObject.CompareTag("Sacola"))
        //{

        //}
    }

    //Função DontBlock permite que a tela não entre em repouso. 
    void DontBlock()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
