using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEspecialController : MonoBehaviour
{
    public Vector3 movItemEspecial;
    public BallMoviment ballmov;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(movItemEspecial);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "pelota")
        {
            ballmov.velocidadeBola = ballmov.velocidadeBola * 2;

            Destroy(gameObject);
        }
    }
}
