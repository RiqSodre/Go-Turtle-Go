using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour{

    public GameObject obs;
    public Player player;

	void Update () {
        if (obs.CompareTag("Lixo"))
        {
            player.currentSpeed = 0;
        }
	}
}
