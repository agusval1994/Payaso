using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DientesManager : MonoBehaviour
{
    public GameObject[] listaDeDientes;
    private Diente diente;

    int dientesTirados;

    private GameManager manager;

    private void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }
    public void TirarDiente()
    {
        dientesTirados++;
        manager.SumarPuntos();

        if (dientesTirados >= 6)
        {
            Invoke("SubirDientes", 1f);
        }
    }

    public void SubirDientes()
    {
        foreach(GameObject unDiente in listaDeDientes)
        {
            diente = unDiente.GetComponent<Diente>();
            diente.SubirDiente();
            FindObjectOfType<AudioManager>().Play("SubirDientes");
        }

        dientesTirados = 0;
    }
}
