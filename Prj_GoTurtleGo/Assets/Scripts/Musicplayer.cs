using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicplayer : MonoBehaviour {
    public AudioClip[] swim;
    public AudioSource audioSource;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
        }
	}

    private AudioClip GetRandomClip()
    {
        return swim[Random.Range(0, swim.Length)];
    }

}
