using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movCamera : MonoBehaviour
{
    private Vector3 posicaoInicial;
    private Vector3 posicaoAtual;
    public GameObject pelota;

    // Start is called before the first frame update
    void Start()
    {
        posicaoInicial = pelota.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        posicaoAtual = pelota.transform.position;
        transform.position = transform.position + (posicaoAtual - posicaoInicial);
        posicaoInicial = pelota.transform.position;
    }
}
