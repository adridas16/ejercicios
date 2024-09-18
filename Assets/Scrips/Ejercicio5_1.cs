using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    //5.1
    [SerializeField] int VidaJ1 = 2;
    [SerializeField] int VidaJ2 = 2;
    //------------------------------------

    //5.2
    [SerializeField] int numero = 5;
    [SerializeField] int numero2 = 2;
    //-----------------------------------

    //5.3
    [SerializeField] int numeroR=5;
    //----------------------------------------

    //5.4
    [SerializeField] float NumeroDivision1 = 5;
    [SerializeField] float NumeroDivision2 = 10;
    float NumeroResultado;
    //----------------------------------------

    //5.5
    [SerializeField] int Nivel = 2;
    //----------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        //5.1
        if (VidaJ1 == VidaJ2)
        {
            Debug.Log("Jugador 1 " + VidaJ1 + " Jugador 2 " + VidaJ2);
        }
        //------------------------------------

        //5.2
        if (numero < 3 && numero2<3)
        {
            
        }
        //-----------------------------------

        //5.3
        if (numeroR > 0 && numeroR < 9)
        {
            Debug.Log("esta bien");
        }
        //----------------------------------------//5.4
        NumeroDivision1 /= NumeroDivision2;
        if (NumeroDivision2!=0)
        {
            Debug.Log("buena division" + NumeroResultado);
        }
        //----------------------------------------

        //5.5
       

        //----------------------------------------

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
