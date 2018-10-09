using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class Clicksound : MonoBehaviour {
    public AudioClip btnSound;

    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    // Use this for initialization
    void Start () {
        gameObject.AddComponent<AudioSource>();
        source.clip = btnSound;
        source.playOnAwake = false;

        button.onClick.AddListener(() => PlaySound());
	}
	
	// Update is called once per frame
	void PlaySound()
    {
        source.PlayOneShot(btnSound);
    }
}
