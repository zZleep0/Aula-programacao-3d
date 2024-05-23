using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarinhaController : MonoBehaviour
{
    private Animator anim;
    public bool andar = false;
    public bool girar = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    void Update()
    {
        anim.SetBool("podeAndar", andar);
        anim.SetBool("podeVirar", girar);
    }
}
