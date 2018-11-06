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

    public AudioClip[] eating;
    public AudioSource audioSource;

    float ver, hor;
    Vector2 direction, velocity;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;
    }

    private void Awake()
    {
        energy.Initialize();
        energy.CurrentVal = 0;
    }
    
    void Update () {
        DontBlock();
        //Movimento do acelerometro.
        transform.position += new Vector3(velocidadeAtual, -Input.acceleration.x * velocidadeY, 0) * Time.deltaTime;

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
            audioSource.clip = GetRandomClip();
            audioSource.Play();
            Destroy(col.gameObject);
        }
        if(col.gameObject.CompareTag("Latinha"))
        {
            velocidadeAtual = -5;
        }
        if (col.gameObject.CompareTag("Sacola"))
        {
            velocidadeAtual = 0;
        }
    }

    //Função DontBlock permite que a tela não entre em repouso. 
    void DontBlock()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    private AudioClip GetRandomClip()
    {
        return eating[Random.Range(0, eating.Length)];
    }

    public void Dash()
    {
        velocidadeAtual = 10;
        energy.CurrentVal = 0;
        dash.SetActive(false);
    }
}
