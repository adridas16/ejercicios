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

    //5.6
    [SerializeField] int nivelP = 30;

    //----------------------------------------

    //5.7
    [SerializeField] int velocidad1 = 1;
    [SerializeField] int velocidad2 = 2;
    [SerializeField] int velocidad3 = 3;


    //----------------------------------------

    //5.8
    [SerializeField] int H=13;
    [SerializeField] int M=30;
    [SerializeField] int S=54;

    //----------------------------------------

    //5.10

    int TP = 10;

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

        //5.6
        nivelP *= 3;
        if (nivelP == 30)
        {
            Debug.Log("es multiplo");
        }

        //----------------------------------------


        //5.7
        if (velocidad1 > velocidad2 && velocidad1 > velocidad3) 
        {
            Debug.Log(velocidad1+" gana el 1");
        }
        if (velocidad2 > velocidad1 && velocidad2 > velocidad3) 
        {
            Debug.Log(velocidad2 + " gana el 2");
        }
        if (velocidad3 > velocidad2 && velocidad3 > velocidad1) 
        {
            Debug.Log(velocidad3 + " gana el 3");
        }
        //----------------------------------------

        //5.8

        Debug.Log("hora " + H + ":" + M + ":" + S);

        //----------------------------------------

        //5.10

        if (TP <= 10)
        {
            Debug.Log("frio");

        }
        else if (10<TP&& TP<=20)
        {
            Debug.Log("nublado");
        }
        else if (20 < TP && TP <= 30)
        {
            Debug.Log("nublado");
        }
        else if(TP>30)
        {
            Debug.Log("Tropical");
        }
        //----------------------------------------

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
