using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager GameManager;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
