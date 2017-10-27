using UnityEngine;
using System.Collections;

public class ObjectPickup : MonoBehaviour {

    void Update()
    {
        if (transform.position.z > Camera.main.transform.position.z + 5)
        {
            GameOver.IsGameOver = true;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        Score.score++;
        Destroy(gameObject);
    }
}
