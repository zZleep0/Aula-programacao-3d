using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTPController : MonoBehaviour
{
    public GameObject localTP;
    public Vector3 posicaoTP;

    public Vector3 movItemTP;

    // Start is called before the first frame update
    void Start()
    {

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

            Destroy(gameObject);
        }
    }
}
