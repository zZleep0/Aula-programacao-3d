using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenarioController : MonoBehaviour
{
    [SerializeField] private Transform personagem;
    [SerializeField] private Transform agua;
    [SerializeField] private Color corDaAgua;
    [SerializeField] private float densidade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (personagem.position.y < agua.position.y)
        {
            //debaixo da agua
            RenderSettings.fog = true;
            RenderSettings.fogMode = FogMode.Exponential;
            RenderSettings.fogColor = corDaAgua;
            RenderSettings.fogDensity = densidade;
        }
        else
        {
            //emcima da agua
            RenderSettings.fog = false;
        }
    }
}
