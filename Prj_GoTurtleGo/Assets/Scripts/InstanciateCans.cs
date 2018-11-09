using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateCans : MonoBehaviour {

    public GameObject can;

    void Start () {
        InvokeRepeating("Spawner", 3, 2);
    }

    void Spawner()
    {
        float posX = Random.Range(transform.position.x, transform.position.x + 30);
        Vector3 inicio = new Vector3(posX, +8, 0);
        GameObject instance = Instantiate(can, inicio, Quaternion.identity);
        Destroy(instance, 10);
    }
}
