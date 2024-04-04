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

    [Header("Mira Luneta")]
    [SerializeField] private GameObject cameraLuneta;
    [SerializeField] private KeyCode habilitarLuneta;
    private bool lunetaHabilitada = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region Laser
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
        #endregion

        #region Luneta
        if (Input.GetKeyDown (habilitarLuneta))
        {
            lunetaHabilitada = !lunetaHabilitada;
        }
        if (lunetaHabilitada)
        {
            cameraLuneta.SetActive(true);
        }
        else
            cameraLuneta.SetActive(false);
        #endregion
    }
}
