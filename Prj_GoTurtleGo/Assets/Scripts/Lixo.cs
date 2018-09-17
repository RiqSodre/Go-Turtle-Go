using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lixo : MonoBehaviour {

    Player player = new Player();

    void OnColliderEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            player.velocidadeAtual = -player.velocidadeX;
        }
    }
}
