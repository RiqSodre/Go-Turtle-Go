using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicplayer : MonoBehaviour {
    public AudioClip[] swim;
    public AudioSource audioSource;

    void Start () {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
    }
	
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
