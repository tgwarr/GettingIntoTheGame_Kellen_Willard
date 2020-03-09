using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private const float spawnPointZ = 25;
    private const float xRange = 10;
    public GameObject[] Animals;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals", 3.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAnimals()
    {
        int randomSpawn = Random.Range(0, Animals.Length);
        Instantiate(Animals[randomSpawn], new Vector3(Random.Range(-xRange, xRange), 0, spawnPointZ), Animals[randomSpawn].transform.rotation);
    }
}
