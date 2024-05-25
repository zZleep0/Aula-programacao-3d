using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararRifle : MonoBehaviour
{
    [SerializeField] public GameObject canoArma;
    [SerializeField] public GameObject bala;
    public int municao;
    [SerializeField] public GameObject player;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip somDeTiro;
    [SerializeField] private AudioClip somDeRecarregar;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.Find("Player").GetComponent<AudioSource>();

        municao = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (municao > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                audioSource.PlayOneShot(somDeTiro);
                var ba = Instantiate(bala, canoArma.transform.position, canoArma.transform.rotation);
                Destroy(ba, 3f);
                municao--;
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            audioSource.PlayOneShot(somDeRecarregar);
            municao = 20;
        }
    }
    

}
