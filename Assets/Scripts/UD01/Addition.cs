using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    public int numero;

    // Start is called before the first frame update
    void Start()
    {
        AdditionNumero(numero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AdditionNumero(int n)
    {
        int suma = 0;

        for (int i = 1; i <= n; i++)
        {
            suma += i;
        }

        Debug.Log("La suma de los números del uno hasta el numero " + n + " es : " + suma);


    }
}
