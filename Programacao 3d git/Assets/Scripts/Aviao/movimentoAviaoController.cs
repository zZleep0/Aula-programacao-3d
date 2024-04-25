using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoAviaoController : MonoBehaviour
{
    [Header("Movimento da helice")]
    [Tooltip("Velocidade da helice")]
    [SerializeField] private float fatorDeGiro;
    [SerializeField] private GameObject helice;

    [Header("Movimento do Aviao")]
    [SerializeField] private KeyCode paraCima;
    [SerializeField] private KeyCode paraBaixo;
    [SerializeField] private KeyCode inclinarDireita;
    [SerializeField] private KeyCode inclinarEsquerda;
    [SerializeField] private KeyCode paraDireita;
    [SerializeField] private KeyCode paraEsquerda;
    [SerializeField] private KeyCode acelerador;
    [SerializeField] private KeyCode freio;
    
    [SerializeField] private float velocidade = 0;

    private bool ligado = false;

    [Header("Interacoes")]
    private int qtdeComb;
    private float tempo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ligado)
        {
            GiroDaHelice();
            Movimento();
        }
    }

    public void Movimento()
    {
        #region acelerar e desacelerar aviao
        if (Input.GetKey(acelerador) && velocidade < 5)
        {
            velocidade += Time.deltaTime;
        }
        if (Input.GetKey(freio))
        {
            if (velocidade >= 0)
            {
                velocidade -= Time.deltaTime;
                if (velocidade < 0)
                {
                    velocidade = 0;
                }
            }
        }
        #endregion

        #region virar o aviao
        float movX = 0;
        float movY = 0;
        float movZ = 0;

        if (Input.GetKey(paraCima))
        {
            movX = -1;
        }
        if (Input.GetKey(paraBaixo))
        {
            movX = 1;
        }
        if (Input.GetKey(paraDireita))
        {
            movZ = 1;
        }
        if (Input.GetKey(paraEsquerda))
        {
            movZ = -1;
        }
        if (Input.GetKey(inclinarDireita))
        {
            movY = 1;
        }
        if (Input.GetKey(inclinarEsquerda))
        {
            movY = -1;
        }
        #endregion

        transform.Translate(new Vector3 (0, -1, 0) * velocidade); //ou Vector.down
        transform.Rotate(movX, movY, movZ);

    }

    public void GiroDaHelice()
    {
        helice.transform.Rotate(new Vector3(0, fatorDeGiro * Time.deltaTime , 0));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            ligado = true;
            collision.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Combustivel"))
        {
            qtdeComb++;
            
            Destroy(other.gameObject);
        }
    }
}
