using UnityEngine;

public class ObstacleDisabler : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Refresh")) { this.gameObject.SetActive(false); }
    }
    
}
