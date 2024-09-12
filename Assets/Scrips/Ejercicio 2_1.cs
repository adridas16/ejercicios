using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio2_1 : MonoBehaviour
{
    //Ejercicio 2.1
    string nombre = "juan";
    float iva = 0.10f;
    float peso = 75.5f;
    bool alumnoRepetidor;
    string letra = "A";
    int minutos = 30;
    string matriculaCoche = "2424XAS";
    bool mayordeEdad;
    int codigoPostal = 22922;
    string Genero = "masculino";
    int numerodeHijos = 2;
    float tallaCamisa = 1.80f;
    float precio = 5.60f;
    string mensaje = "soy paco";
    int mayorEdad = 60;
    int dias = 10;
    int contador = 5;
    string tallaCamiseta = "XL";
    //-------------------------

    //ejercicio 2.2
    int vidas = 8;
    float exp = 12.8f;
    char carac = 'H';
    float resultadosuma;
    float resultadoresta;
    //-----------------------

    //ejercicio 2.3
    int heal = 5;
    float axp = 9.6f;
    float producto;
    float cociente;
    float doble;
    float triple;
    //-----------------------------

    //ejercicio 2.4
    int existencia = 62;
    //------------------------------------------------

    //ejercicio2.5
    int vidasPlayer1 = 2;
    int vidasPlayer2 = 10;
    int vidasPlayer3 = 40;
    int vidasPlayer4 = 8;
    //---------------------------------

    //ejercicio 2.6
    float primer = 6;
    float segun = 2;
    float tercer = 9;
    //--------------------------

    //ejercicio 2.7
    int oro = 7;
    int tiempo = 14400;
    //----------------------------


    //ejercicio 2.8
    float puntos = 120f;
    float puntosresta;
    float puntostotales;
    //-------------------

    // Start is called before the first frame update
    void Start()
    {
        //ejercicio 2.2
        Debug.Log("vidas" + vidas);
        Debug.Log("exp" + exp);

        resultadosuma = vidas + exp;
        resultadoresta = vidas - exp;

        Debug.Log("resultado suma " + resultadosuma);
        Debug.Log("resultado resta " + resultadoresta);
        //---------------------------------------------


        //ejercicio2.3
        producto = heal * axp;
        cociente = heal / axp;
        doble = heal * 2;
        triple = axp * 3;
        //--------------------------

        //ejercicio 2.4
        Debug.Log("existencia normal = " + existencia);
        existencia += 77;
        Debug.Log("existencia + 77 = " + existencia);
        existencia -= 3;
        Debug.Log("existencia -3 = " + existencia);
        existencia *= 4;
        Debug.Log("existencia cuadruplicada = " + existencia);
        //------------------------------------------------

        //ejercicio2.5
        Debug.Log("vida jugador1   " + vidasPlayer1);
        Debug.Log("vida jugador2   " + vidasPlayer2);
        Debug.Log("vida jugador3   " + vidasPlayer3);
        Debug.Log("vida jugador4   " + vidasPlayer4);
        int  vidasplayerv2  = vidasPlayer3;
        Debug.Log("vida jugador1   " + vidasPlayer1);
        Debug.Log("vida jugador2   " + vidasplayerv2);
        Debug.Log("vida jugador3   " + vidasPlayer3);
        Debug.Log("vida jugador4   " + vidasPlayer4);
        vidasPlayer3 = vidasPlayer1;
        Debug.Log("vida jugador1   " + vidasPlayer1);
        Debug.Log("vida jugador2   " + vidasplayerv2);
        Debug.Log("vida jugador3   " + vidasPlayer3);
        Debug.Log("vida jugador4   " + vidasPlayer4);
        vidasPlayer1 = vidasPlayer4;
        Debug.Log("vida jugador1   " + vidasPlayer1);
        Debug.Log("vida jugador2   " + vidasplayerv2);
        Debug.Log("vida jugador3   " + vidasPlayer3);
        Debug.Log("vida jugador4   " + vidasPlayer4);
        vidasPlayer4 = vidasPlayer2;
        Debug.Log("vida jugador1   " + vidasPlayer1);
        Debug.Log("vida jugador2   " + vidasplayerv2);
        Debug.Log("vida jugador3   " + vidasPlayer3);
        Debug.Log("vida jugador4   " + vidasPlayer4);
        //---------------------------------

        //ejercicio 2.6

        Debug.Log("puntos primer " + primer);
        Debug.Log("puntos segun" + segun);
        Debug.Log("puntos tercer" + tercer);
        primer *= 0.20f;
        segun *= 0.40f;
        tercer *= 0.40f;
        float  puntospuestos=primer+segun+tercer;
        Debug.Log("media"+puntospuestos);
        
        //-----------------

        //ejercicio 2.7
        oro *= tiempo;
        Debug.Log(oro);
        //---------------------------------

        //ejercicio 2.8
        Debug.Log(puntos);
        puntosresta = puntos * 0.03f;
        puntostotales = puntos - puntosresta;
        Debug.Log(puntostotales);
        puntosresta = puntos * 0.06f;
        puntostotales = puntos - puntosresta;
        Debug.Log(puntostotales);
        puntosresta = puntos * 0.09f;
        puntostotales = puntos - puntosresta;
        Debug.Log(puntostotales);
        puntosresta = puntos * 0.12f;
        puntostotales = puntos - puntosresta;
        Debug.Log(puntostotales);
        puntosresta = puntos * 0.15f;
        puntostotales = puntos - puntosresta;
        Debug.Log(puntostotales);

        //-----------------------
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
