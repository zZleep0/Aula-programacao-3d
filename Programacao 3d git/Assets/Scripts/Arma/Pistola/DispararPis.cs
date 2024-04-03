using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararPis : MonoBehaviour
{
    [SerializeField] public GameObject canoArma;
    [SerializeField] public GameObject bala;
    private int limiteBala = 20;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (limiteBala > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                var ba = Instantiate(bala, canoArma.transform.position, canoArma.transform.rotation);
                Destroy(ba, 3f);
                limiteBala--;
            }
        }
    }
}
