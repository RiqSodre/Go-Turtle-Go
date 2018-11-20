using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour {
    
    public GameObject panel;
    public GameObject dash;
    public GameObject pause;
    public GameObject energy;
    public GameObject energiaT;
    public Text fraseTexto, scoreText;

    public string[] frases;

    IEnumerator Points()
    {
        for (int i = 0; i <= GameManager.Instance.score; i++)
        {
            yield return new WaitForSeconds(0.05f);
            scoreText.text = "Pontos\n" + i;
        }
    }

    private void OnCollisionEnter2D()
    {
        Active();
        fraseTexto.text = frases[Random.Range(0, frases.Length)];
        StartCoroutine(Points());
    }

    void Active()
    {
        panel.SetActive(true);
        dash.SetActive(false);
        energy.SetActive(false);
        pause.SetActive(false);
    }
}
