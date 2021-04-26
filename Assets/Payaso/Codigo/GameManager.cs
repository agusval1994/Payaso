using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int puntos;
    public Text textoPuntos;

    public void SumarPuntos()
    {
        puntos++;
        textoPuntos.text = puntos.ToString();
    }
}
