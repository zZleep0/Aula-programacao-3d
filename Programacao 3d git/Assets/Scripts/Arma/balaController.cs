using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaController : MonoBehaviour
{
    private Rigidbody fis;
    public float velocidade;


    // Start is called before the first frame update
    void Start()
    {
        fis = GetComponent<Rigidbody>();
        fis.AddForce(transform.forward * velocidade, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
