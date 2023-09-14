using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] float speed;

    private void Update() { transform.Translate(Vector2.left * speed * Time.deltaTime); }
}
