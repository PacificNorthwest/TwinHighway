using UnityEngine;
using System.Collections;

public class RoadSpawn : MonoBehaviour {

    public GameObject RoadBlock;
    public Transform SpawnPoint;

    void Update()
    {
        if (transform.position.z > SpawnPoint.position.z - 90)
        {
            RoadBlockSpawn();
        }
    }

    void RoadBlockSpawn()
    {
        Instantiate(RoadBlock, transform.position, transform.rotation);
        transform.position += new Vector3(0, 0, -160);
    }	
}
