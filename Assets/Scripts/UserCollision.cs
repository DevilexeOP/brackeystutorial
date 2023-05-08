
using UnityEngine;

public class UserCollision : MonoBehaviour
{
    public UserMovement movement;
    public GameManager gameManager;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
