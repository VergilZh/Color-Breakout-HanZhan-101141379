using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager GameManager;
    public int blockColorNum;
    public int currentPlayerColor;
    public PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPlayerColor = player.playerColorNum;
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            if (currentPlayerColor == blockColorNum)
            {
                Destroy(gameObject);
            }
            else
            {
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
}

