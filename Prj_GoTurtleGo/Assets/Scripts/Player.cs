using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    [SerializeField]
    private Stat energy;

    public GameObject dash;
    
    public float velocidadeX = 2f;

    public float velocidadeY = 30f; 
    public float velocidadeAtual = 0;

    private void Awake()
    {
        energy.Initialize();
        energy.CurrentVal = 0;
    }
    
    void Update () {
        DontBlock();
        //Movimento do acelerometro.
        transform.position += new Vector3(velocidadeAtual, Input.acceleration.x * velocidadeY, 0)*Time.deltaTime;

        //Velocidade.
        if (velocidadeAtual < 7)
        {
            velocidadeAtual += 1;
        }
            
        //Energia.
        if (energy.CurrentVal == energy.MaxVal)
        {
            dash.SetActive(true);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("AguaViva"))
        {
            energy.CurrentVal += 10;
            GameManager.Instance.Eat(1);
            Destroy(col.gameObject);
        }
        else if(col.gameObject.CompareTag("Latinha"))
        {
            velocidadeAtual = -3;
        }
        else if (col.gameObject.CompareTag("Sacola"))
        {
            velocidadeAtual = 1;
        }
    }

    //Função DontBlock permite que a tela não entre em repouso. 
    void DontBlock()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
