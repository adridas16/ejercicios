using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejericio3_1 : MonoBehaviour
{

    //3.1
    [SerializeField]int numeroEntero = 2;
    [SerializeField] int numeroEntero2 = 3;
    //-----------------------------------------

    //3.2
    [SerializeField] string nombre = "juan ramirez";
    //--------------------------------

    //3.3
    int numeroE = 4;
    int numeroEdoble;
    int numeroEtriple;
    //--------------------
    //3.4
    [SerializeField] int EXP = 100;
    int LVL;
    //-------------------

    // 3.5
    [SerializeField] float radio = 9f;
    float Area ;
    float longitud;
    //---------------------------

    //3.6
    [SerializeField] int KMH = 120;
    int MS;
    //----------------------------

    //3.7
    [SerializeField] int Base=12;
    [SerializeField] int Altura=7;
    int areaT;
    //----------------------------------

    // Start is called before the first frame update
    void Start()
    {
        //3.1
        Debug.Log(numeroEntero+ numeroEntero2);
        //------------------------------------

        //3.2
        Debug.Log("Bienvenido de nuevo " + nombre);
        //---------------------------------

        //3.3
        numeroEdoble = numeroE * 2;
        numeroEtriple = numeroE * 3;
        Debug.Log(numeroEdoble);
        Debug.Log(numeroEtriple);
        //----------------------------

        //3.4
        LVL=32+(9*EXP/5);
        Debug.Log(LVL);
        //-------------------------------------------

        //3.5 
        longitud = 2 * 3.14f * radio;
        Area = 3.14f * radio / 2;
        Debug.Log(Area);
        Debug.Log(longitud);

        //------------------------------------

        //3.6
        MS = KMH * 1000;
        Debug.Log(MS);
        //----------------------------

        //3.7
        areaT = Base*Altura/2;
        Debug.Log(areaT);
        //----------------------------------
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
