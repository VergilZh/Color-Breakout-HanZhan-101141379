using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager GameManager;
    private void OnTriggerEnter()
    {
        GameManager.CompleteLevel();
    }
}
