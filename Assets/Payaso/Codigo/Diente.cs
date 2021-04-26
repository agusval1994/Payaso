using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diente : MonoBehaviour
{
    Animator animator;
    public bool puedeTirarDiente = true;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void BajarDiente()
    {
        if (puedeTirarDiente) {
            animator.SetInteger("Condicion", 1);
            FindObjectOfType<DientesManager>().TirarDiente();
            puedeTirarDiente = false;
        }
    }

    public void SubirDiente()
    {
        animator.SetInteger("Condicion", 2);
        Invoke("SePuedeVolverATirar", 1f);
    }

    public void SePuedeVolverATirar()
    {
        puedeTirarDiente = true;
    }
}
