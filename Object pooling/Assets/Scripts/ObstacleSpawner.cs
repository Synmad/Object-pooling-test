using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    GameObject obstacle;
    [SerializeField] GameObject spawnPoint;

    private void Start() { StartCoroutine(EnableObstacle()); }

    private IEnumerator EnableObstacle()
    {
        while (true)
        {
            obstacle = ObstaclePool.Instance.GetPooledObstacles();
            if(obstacle != null)
            {
                obstacle.transform.position = spawnPoint.transform.position;
                obstacle.SetActive(true);
            }
            yield return new WaitForSeconds(1.0f);
            yield return null; 
        }
    }
}
