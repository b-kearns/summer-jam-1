using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityBlock : MonoBehaviour
{
    public float xMin = -1.8f;
    public float xMax = 1.8f;
    public float zMin = 2f;
    public float zMax = 22f;

    public GameObject[] obstacles;

    // Start is called before the first frame update
    void Start()
    {
        GenerateObjects();
    }

    private void GenerateObjects()
    {
        int amount = Random.Range(1,3);

        for (int i = 0; i < amount; i++)
        {
            int index = Random.Range(0, obstacles.Length);
            float _X = Random.Range(xMin, xMax);
            float _Z = Random.Range(zMin + transform.position.z, zMax + transform.position.z);

            var newObject = GameObject.Instantiate(obstacles[index], new Vector3(_X, 0.035f, _Z), Quaternion.Euler(0,Random.value,0));
            newObject.transform.parent = this.transform;
        }
    }
}
