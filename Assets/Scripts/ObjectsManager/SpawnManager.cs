using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

    public GameObject[] Objects = new GameObject[2];
    public GameObject[] LeftSpawners = new GameObject[2];
    public GameObject[] RightSpawners = new GameObject[2];

    public static float timer;
	// Use this for initialization
	void Start () {
        timer = Time.time;
	}

    // Update is called once per frame
    void Update()
    {
        if (GameOver.IsGameOver == false && GameOver.IsPaused == false)
        {
            if (Time.time - timer > 1)
            {
                timer = Time.time;
                int SpawnerID = Random.Range(0, 2);
                int ObjectID = Random.Range(0, 2);

                Instantiate(Objects[ObjectID], LeftSpawners[SpawnerID].transform.position, transform.rotation);

                SpawnerID = Random.Range(0, 2);
                ObjectID = Random.Range(0, 2);

                Instantiate(Objects[ObjectID], RightSpawners[SpawnerID].transform.position, transform.rotation);
            }
        }
    }
}
