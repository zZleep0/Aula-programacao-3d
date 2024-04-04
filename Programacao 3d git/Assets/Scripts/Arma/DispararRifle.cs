using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararRifle : MonoBehaviour
{
    [SerializeField] public GameObject canoArma;
    [SerializeField] public GameObject bala;
    public int municao;
    [SerializeField] public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        municao = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (municao > 0)
        {
            if (Input.GetMouseButton(0))
            {
                var ba = Instantiate(bala, canoArma.transform.position, canoArma.transform.rotation);
                Destroy(ba, 3f);
                municao--;
            }
        }
    }
    

}
