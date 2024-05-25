using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperPulo : MonoBehaviour
{
    public bool usarSuperPulo = false;
    public float tempoBoostVelo = 0;

    private AudioSource audioCamera;
    [SerializeField] private AudioClip musicaSuper;
    [SerializeField] private AudioClip musicaAmbiente;

    // Start is called before the first frame update
    void Start()
    {
        audioCamera = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (usarSuperPulo)
        {
            audioCamera.clip = musicaSuper;
            audioCamera.Play();

            tempoBoostVelo += Time.deltaTime;

            if (tempoBoostVelo > 3)
            {
                usarSuperPulo = false;
                tempoBoostVelo = 0;
            }
        }
        //else
        //{
        //    audioCamera.clip = musicaAmbiente;
        //    audioCamera.Play();
        //}
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "itemEspecial")
        {
            usarSuperPulo = true;
        }
    }
}
