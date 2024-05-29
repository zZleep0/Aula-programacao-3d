using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerAviao : MonoBehaviour
{
    [SerializeField] private Camera camMinimapa;
    private bool ativaMinimapa;

    [SerializeField] private Camera camera1P;
    [SerializeField] private Camera camera3P;
    [SerializeField] private Camera cameraRetrovisor;
    [SerializeField] private movimentoAviaoController movimentoAviaoController;

    [SerializeField] private KeyCode trocaCamera;
    [SerializeField] private KeyCode espelho;
    [SerializeField] private KeyCode minimapa;
    private bool primeiraPessoa;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (movimentoAviaoController.ligado == true)
        {
            camera1P.enabled = true;
            camera3P.enabled = true;
            cameraRetrovisor.enabled = true;
            camMinimapa.enabled = true;
        }
        else
        {
            camera1P.enabled = false;
            camera3P.enabled = false;
            cameraRetrovisor.enabled = false;
            camMinimapa.enabled = false;
        }
        Minimapa();
        TrocaDeCamera();
        HabilitaRetrovisor();
        
    }

    private void TrocaDeCamera()
    {
        if (Input.GetKeyDown(trocaCamera))
        {
            primeiraPessoa = !primeiraPessoa; // ! significa inverso ou seja, inverso do valor de primeira pessoa
        }
        if (primeiraPessoa) // se for true
        {
            camera1P.depth = 2;
            camera3P.depth = 1;
        }
        else
        {
            camera1P.depth = 1;
            camera3P.depth = 2;
        }
    }

    private void HabilitaRetrovisor()
    {
        if (Input.GetKey(espelho))
        {
            cameraRetrovisor.depth = 3;
        }
        else
        {
            cameraRetrovisor.depth = 0;
        }
    }

    private void Minimapa()
    {
        if (Input.GetKeyDown(minimapa))
        {
            ativaMinimapa = !ativaMinimapa;

        }
        if (ativaMinimapa)
        {
            camMinimapa.depth = 5;
            Debug.Log("ativou minimapa");
        }
        else
            camMinimapa.depth = 1;
        
    }
}
