using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararRifle : MonoBehaviour
{
    [SerializeField] public GameObject canoArma;
    [SerializeField] public GameObject bala;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var ba = Instantiate(bala, canoArma.transform.position, canoArma.transform.rotation);
            Destroy(ba, 3f);
        }
    }
}
