using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaArmaController : MonoBehaviour
{
    [SerializeField] private GameObject Rifle;
    [SerializeField] private GameObject Pistola;
    private bool trocaArma = false;

    // Start is called before the first frame update
    void Start()
    {
        Pistola.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("pistola"))
        {
            Rifle.SetActive(false);
            Pistola.SetActive(true);
            trocaArma=true;
        }
    }
}
