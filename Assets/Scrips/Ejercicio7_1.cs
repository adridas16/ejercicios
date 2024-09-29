using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    //7.1
    int numero1;
    //------------------------------------------
    //7.2
    int numero2;
    //------------------------------------------
    //7.3
    int numero3=100;
    //-----------------------------------------
    //7.4
    int numero4;
    //-----------------------------------------
    //7.5
   [SerializeField] int numero5=0;
    [SerializeField] int numero6;
    //-----------------------------------------
    //7.6
    [SerializeField] int numero7 = 030;
    [SerializeField] int numero8;
    //-----------------------------------------


    // Start is called before the first frame update
    void Start()
    {
        //7.1
        while (numero1 < 100)
        {
            numero1++;
            Debug.Log(numero1);
        }
        //--------------------------------------
        //7.2
        for (numero2 = 0; numero2 < 101; numero2++)
        {
            {

                Debug.Log(numero2 + "  2");
            }
            

        }
        //--------------------------------------
        //7.3
        while (numero3 > 1)
        {
            numero3--;
            Debug.Log(numero3+"    3");
        }
        //--------------------------------------

        //7.4
        for (numero4 = 100; numero4 > 0; numero4--)
        {
            {

                Debug.Log(numero4 + "  4");
            }


        }
        //--------------------------------------
        //7.5
        while (numero5 > 18)
        {
            numero5++;
            Debug.Log(numero3 + "    5");
        } 
        for (numero6 = 0; numero6 > 31; numero6++)
        {
            {

                Debug.Log(numero6 + "  6");
            }


        }
        //--------------------------------------

        //7.6
        while (numero7 > -22)
        {
            numero7--;
            Debug.Log(numero7 + "    5");
        }
        for (numero8 = 15; numero8 > -25; numero8--)
        {
            {

                Debug.Log(numero8 + "  6");
            }


        }
        //--------------------------------------
        // Update is called once per frame
        void Update()
        {

        }
    }
}
