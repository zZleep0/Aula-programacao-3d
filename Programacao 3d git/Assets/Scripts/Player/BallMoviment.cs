using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoviment : MonoBehaviour
{

    [Header("Configuracao")]
    private float movX;
    private float movZ;
    [SerializeField] public float velocidadeBola;
    private Vector3 posicaoInicial;

    private Rigidbody fisica;
    [SerializeField] private float forcaPulo;
    private bool estaNoChao = true;

    [Header("Entradas Teclado")]
    [SerializeField] private KeyCode paraFrente;
    [SerializeField] private KeyCode paraTraz;
    [SerializeField] private KeyCode paraEsquerda;
    [SerializeField] private KeyCode paraDireita;
    [SerializeField] private KeyCode teclaPulo;

    public int tempospeed = 3;
    public bool boost;


    // Start is called before the first frame update
    void Start()
    {
        fisica = GetComponent<Rigidbody>();
        posicaoInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        #region 1° forma de pegar o Input
        //movX = Input.GetAxis("Horizontal");
        //movZ = Input.GetAxis("Vertical");
        #endregion

        #region 2³ forma de pegar o Input
        movX = 0;
        movZ = 0;
        if (Input.GetKey(paraFrente))
            movZ = 1;
        if (Input.GetKey(paraTraz))
            movZ = -1;

        if (Input.GetKey(paraEsquerda))
            movX = -1;
        if (Input.GetKey(paraDireita))
            movX = 1;
        #endregion

        #region 1° forma de aplicar o movimento
        //Vector3 posicao = new Vector3(movX, 0, movZ);
        transform.Translate(new Vector3(movX, 0, movZ) * Time.deltaTime * velocidadeBola);
        #endregion

        #region 2° forma de aplicar o movimento
        //fisica.AddForce(new Vector3(movX, 0, movZ) * Time.deltaTime * velocidadeBola);
        #endregion

        #region 3° forma de aplicar o movimento
        //fisica .velocity = (new Vector3(movX, 0, movZ) * Time.deltaTime * velocidadeBola);
        #endregion

        #region Pulo da bolinha
        //pulo da bolinha
        if (Input.GetKeyDown(teclaPulo) && estaNoChao)
        {
            fisica.AddForce(new Vector3 (0, 1, 0) * forcaPulo, ForceMode.Impulse);
        }
        #endregion

        
    }

    #region Colisoes
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "chao")
            estaNoChao = true;

        if (collision.collider.tag == "limite")
            transform.position = posicaoInicial;


        if (collision.collider.tag == "itemEspecial")
        {
            velocidadeBola = velocidadeBola * 2;
            Invoke("Desligarvelocidade", tempospeed);
            boost = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "chao")
            estaNoChao = false;
    }
    #endregion

    private void Desligarvelocidade()
    {
        if (boost)
        {
            velocidadeBola = velocidadeBola / 2;
            boost = false;
        }
    }
}
