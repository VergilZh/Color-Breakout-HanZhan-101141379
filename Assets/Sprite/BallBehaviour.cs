using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public int BallColorNum;
    public PlayerMovement player;
    public Color[] colors;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter(Collision collisionInfo)
    //{
    //    if (collisionInfo.collider.tag == "Player")
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        { 
            if (BallColorNum == 1)
            { 
                player.GetComponent<Renderer>().material.color = colors[1];
                player.playerColorNum = 1;
            }

            if (BallColorNum == 2)
            {
                player.GetComponent<Renderer>().material.color = colors[2];
                player.playerColorNum = 2;
            }



            Destroy(gameObject);
        }
    }
    
}
