using UnityEngine;
using System.Collections;

public class ObjectDestroy : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (transform.position.z > Camera.main.transform.position.z + 5)
        {
            Destroy(gameObject);
        }
	}
}
