using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager GameManager;
    public PlayerMovement movement;
    private void OnTriggerEnter()
    {
        GameManager.CompleteLevel();
        movement.enabled = false;
    }
}
