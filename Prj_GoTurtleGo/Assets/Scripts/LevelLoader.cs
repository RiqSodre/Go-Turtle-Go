using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour {

    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;

    public GameObject btn1, btn2, btn3, btn4, btn5;

	public void LoadLevel(int index)
    {
        StartCoroutine(LoadAsynchronously(index));
    }

    IEnumerator LoadAsynchronously(int index)
    {
        AsyncOperation opreation = SceneManager.LoadSceneAsync(index);

        loadingScreen.SetActive(true);

        while (!opreation.isDone)
        {
            DisableBtns();
            float progress = Mathf.Clamp01(opreation.progress / 0.9f);
            slider.value = progress;
            progressText.text = progress * 100 + "%";
            yield return null;
        }
    }

    //Desabilita os botões na hora do loading.
    public void DisableBtns()
    {
        btn1.SetActive(false);
        btn2.SetActive(false);
        btn3.SetActive(false);
        btn4.SetActive(false);
        btn5.SetActive(false);
    }
}
