using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private string nombre;
    private float vida;
    private float altura;
    private float velocidad;

    #region getters and setters
    public float Vida { get => vida; set => vida = value; }
    public float Vida1 { get => vida; set => vida = value; }
    public float Altura { get => altura; set => altura = value; }
    public float Velocidad { get => velocidad; set => velocidad = value; }
    #endregion
    public void Mover(float x, float y, float z)
    {

    }
    
    public void Atacar()
    {

    }

    public void Saltar()
    {

    }


}
