using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemTPController : MonoBehaviour
{
    //public CenaController control;

    public Vector3 posicaoTP;
    public Vector3 positaoatual;
    public Vector3 movItemTP;

    private AudioSource audioSource;
    [SerializeField] private AudioClip somTP;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.Find("pelota").GetComponent<AudioSource>();
        positaoatual = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(movItemTP);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "pelota")
        {
            audioSource.PlayOneShot(somTP);

            //control.quantidadeItens++;
            if (transform.position == posicaoTP)
            {
                Destroy(gameObject);
            }
            transform.position = posicaoTP;
        }

    }
}
