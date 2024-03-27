using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miraLaserController : MonoBehaviour
{
    [Header("Mira Laser")]
    [SerializeField] private LineRenderer lineMira;
    [SerializeField] private GameObject laser;
    [SerializeField] private float distancia;
    [SerializeField] private KeyCode habilitarLaser;
    private bool laserHabilitado = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lineMira.SetPosition(0, laser.transform.position);
        lineMira.SetPosition(1, laser.transform.forward * distancia);

        if (Input.GetKeyDown(habilitarLaser))
        {
            laserHabilitado = !laserHabilitado;
        }
        if (laserHabilitado)
        {
            laser.SetActive(true);
        }
        else
            laser.SetActive(false);
    }
}
