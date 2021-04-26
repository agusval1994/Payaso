using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public Vector3 movimiento;
    public int tiempoDeVida;
    bool mover = true;
    public float speed = 2000;
    public Vector3 destination;
    public Rigidbody rb;

    private Diente diente;

    int vecesQuePuedeRebotar = 4;

    public Material[] coloresPelota;

    private void Start()
    {
        Invoke("Destruir", tiempoDeVida);
        rb = GetComponent<Rigidbody>();
        ElegirColor();
    }

    void Update()
    {
        if (mover)
        {
            rb.AddForce(transform.forward * speed);
            mover = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Diente")
        {
            diente = collision.gameObject.GetComponent<Diente>();
            diente.BajarDiente();
        }
        RebotePelota();
    }

    void Destruir()
    {
        Destroy(gameObject);
    }

    public void RebotePelota()
    {
        vecesQuePuedeRebotar--;

        if(vecesQuePuedeRebotar > 0)
        {
            FindObjectOfType<AudioManager>().Play("RebotePelota");
        }
    }

    public void ElegirColor()
    {
        int rand = Random.Range(0, coloresPelota.Length);
        Material unMaterial = coloresPelota[rand];
        gameObject.GetComponent<MeshRenderer>().material = unMaterial;
    }
}
