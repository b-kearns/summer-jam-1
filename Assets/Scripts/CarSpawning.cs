using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawning : MonoBehaviour
{
    public GameObject[] carPrefabs;
    public float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = Random.Range(1.5f, 5f);

        InvokeRepeating("SpawnCar", spawnInterval, spawnInterval);
    }

    private void SpawnCar()
    {
        int index = Random.Range(0, carPrefabs.Length);
        GameObject.Instantiate(carPrefabs[index], this.transform);
    }
}
