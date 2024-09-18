using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{

    //4.5
    float restultadoCirculoD;

    //-------------------------------------------


    // Start is called before the first frame update
    void Start()
    {
        //4.1
        float resultadototal = Circulo(2.5f);
        Debug.Log(resultadototal);
        float resultadototalT = Triangulo(4, 8);
        Debug.Log(resultadototalT);
        int resultadototalC = Cuadrado(8);
        Debug.Log(resultadototalC);
        //-------------------------------------------

        //4.2
        string DNIcompleto = ConstruirNombre("Alfredo ", "Gonzalez ", "Ramirez ", "20");
        Debug.Log(DNIcompleto);

        //--------------------------------------------

        //4.3
        float ConversionDinero = Convertir(10, 20, "dolares");
        Debug.Log(ConversionDinero);
        //-----------------------

        //4.4
        float ResultadoSegundos = KilometrosH(200);
        Debug.Log(ResultadoSegundos+"M/S");
        //--------------------------------------------

        //4.5
        float conversormonedas = Circulo(60);
        float ConversionDolares = Convertir(20, 10, "Dolares");
        restultadoCirculoD = conversormonedas * ConversionDolares;
        Debug.Log(restultadoCirculoD);

        //-------------------------------------
    }

    // Update is called once per frame
    void Update()
    {

    }
    //4.1
    float Circulo(float radio)
    {
        float resultado = (radio / 2) * 3.14f;
        return resultado;
    }
    float Triangulo(float Base, float Altura)
    {
        float resultadoT = (Base * Altura) / 2;
        return resultadoT;
    }
    int Cuadrado(int lado)
    {
        int resultadoC = lado * lado;
        return resultadoC;
    }
    //-------------------------------------------

    //4.2
    string ConstruirNombre(string nombre, string apellido, string apellido2, string edad)
    {
        string DNI = nombre + apellido + apellido2 + edad;
        return DNI;
    }
    //--------------------------------------------

    //4.3
    float Convertir(float Euros, float Dolares, string Monedas)
    {

         Dolares = Euros * 0.89f;

        return Dolares; 

    }
    //----------------------------------------

    //4.4
    float KilometrosH(float KHora)
    {
        float MSegundo = KHora * 1000;
        return MSegundo;
    }
    //--------------------------------------

}



