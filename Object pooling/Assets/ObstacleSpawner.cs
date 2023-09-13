using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    GameObject obstacle;
    [SerializeField] Transform spawnPoint;

    private void Start()
    {
        obstacle = ObstaclePool.Instance.GetPooledObstacles();
    }

    private void Update()
    {
        if (obstacle != null)
        {
            obstacle.transform.position = spawnPoint.position;
            obstacle.SetActive(true);
        }
    }
}
