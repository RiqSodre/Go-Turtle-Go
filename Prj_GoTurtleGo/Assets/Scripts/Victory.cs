using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour {

    public GameObject panel;
    public GameObject player;
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

    private void OnTriggerEnter2D()
    {
        Destroy(player);
        panel.SetActive(true);
        fraseTexto.text = frases[Random.Range(0, frases.Length - 1)];
        StartCoroutine(Points());
    }
}
