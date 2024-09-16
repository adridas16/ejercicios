using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{

    //4.1

    //-------------------------------------------


    // Start is called before the first frame update
    void Start()
    {
        float resultadototal =circulo(2.5f);
        Debug.Log(resultadototal);
        float resultadototalT = triangulo(4, 8);
        Debug.Log(resultadototalT);
        int resultadototalC = Cuadrado(8);
        Debug.Log(resultadototalC);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float circulo(float radio)
    {
        float resultado = (radio / 2) * 3.14f;
        return resultado;
    }
    float triangulo(float Base,float Altura)
    {
        float resultadoT = (Base * Altura) / 2;
        return resultadoT;
    }
    int Cuadrado(int lado)
    {
        int resultadoC= lado*lado;
        return resultadoC;
    }
}
