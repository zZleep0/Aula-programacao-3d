using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperPulo : MonoBehaviour
{
    public bool usarSuperPulo = false;
    public float tempoBoostVelo = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (usarSuperPulo)
        {
            tempoBoostVelo += Time.deltaTime;

            if (tempoBoostVelo > 3)
            {
                usarSuperPulo = false;
                tempoBoostVelo = 0;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "itemEspecial")
        {
            usarSuperPulo = true;
        }
    }
}
