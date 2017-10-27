using UnityEngine;
using System.Collections;

public class RoadDestroy : MonoBehaviour {
    void Update () {
        if (transform.position.z > Camera.main.transform.position.z + 150)
        {
            Destroy(gameObject);
        }
	}
}
