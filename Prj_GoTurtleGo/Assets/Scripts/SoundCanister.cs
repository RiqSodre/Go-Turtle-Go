using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCanister : MonoBehaviour {
    AudioSource AudioCan;
	// Use this for initialization
	void Start () {
        AudioCan = GetComponent<AudioSource>();
	}

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            AudioCan.Play();
            Destroy(gameObject);
        }
    }
}
