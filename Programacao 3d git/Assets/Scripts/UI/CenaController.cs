using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CenaController : MonoBehaviour
{
    public Text txtTempo;
    public Text txtQuantidade;
    private float tempo = 0;
    public int quantidadeItens = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //tempo = tempo + Time.deltaTime; (mesma coisa acima)
        tempo += Time.deltaTime;
        txtTempo.text = tempo.ToString();

        txtQuantidade.text = "Itens: " + quantidadeItens;
    }

}
