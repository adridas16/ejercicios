using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPersonaje : MonoBehaviour
{
    int numero = 4;
    string texto = "Hola";
    float deci = 3.14f;
    Personaje link;
    Personaje Mario;
    // Start is called before the first frame update
    void Start()
    {
        //link.nombre = "Link";
        //link.velocidad = 100;
        link.Vida = 100;
        Mario.Vida = 50;


        link.Mover(3,1,0);
        link.Saltar();
        link.Atacar();

    }


   

   
}
