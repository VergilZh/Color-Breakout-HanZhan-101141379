using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMBehaviour : MonoBehaviour
{
    public AudioSource Bgm;
    // Start is called before the first frame update
    void Start()
    {
        if (!Bgm.isPlaying)
        {
            Bgm.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);
    }
}
