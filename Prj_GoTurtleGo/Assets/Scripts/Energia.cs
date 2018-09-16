using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energia : MonoBehaviour {

    Player player = new Player();

    public GameObject aguaViva;
    bool comeu;

	void Start () {
        bool comeu = false;
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("AguaViva"))
        {
            Destroy(aguaViva);
            comeu = true;
        }
    }
    
    void Update()
    {
        if(player.energia < 5 && comeu)
        {
            player.energia += 1;
            comeu = false;

            if (player.energia == 5)
            {
                //fazer botao
                player.velocidadeX += 5;
            }
        }

        print("Energia: " + player.energia);
    }
}
