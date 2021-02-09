using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner13 : MonoBehaviour
{
    public GameObject CarrosCalle1;
    public GameObject CarrosCalle2;
    public GameObject CarrosCalle3;
    public GameObject CarrosCalle4;
    void Start()
    {
        InvokeRepeating("SpawnCarros13", 1, 3);
        InvokeRepeating("SpawnCarros24", 1, 3);
    }

    void SpawnCarros13()
    {
        Instantiate(CarrosCalle1, transform.position,Quaternion.identity);
        Instantiate(CarrosCalle3, transform.position, Quaternion.identity);
    }

    void SpawnCarros24()
    {
        Instantiate(CarrosCalle2, transform.position, Quaternion.identity);
        Instantiate(CarrosCalle4, transform.position, Quaternion.identity);
    }
}
