using System.Collections.Generic;
using UnityEngine;

public class ObstaclePool : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] List<GameObject> pooledObstacles;
    [SerializeField] int poolSize;

    public static ObstaclePool Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(this); }
        else { Instance = this; }

        pooledObstacles = new List<GameObject>();
        GameObject tmp;

        for (int i = 0; i < poolSize; i++)
        {
            tmp = Instantiate(obstaclePrefab);
            tmp.SetActive(false);
            pooledObstacles.Add(tmp);
        }
    }

    public GameObject GetPooledObstacles()
    {
        for (int i = 0; i < poolSize; i++) { if (!pooledObstacles[i].activeInHierarchy) { return pooledObstacles[i]; } }
        return null;
    }
}
