using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager GameManager;
    public int blockColorNum;
    private int currentPlayerColor;
    public PlayerMovement player;
    public ParticleSystem Explosion;
    public AudioSource Pop;
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
                Instantiate(Explosion, gameObject.transform.position, Quaternion.identity);
                Instantiate(Pop, gameObject.transform.position, Quaternion.identity);
            }
            else
            {
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
}

