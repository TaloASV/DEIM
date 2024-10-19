using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    public int numeroUno;
    public int numeroDos;
    public int numeroTres;

    // Start is called before the first frame update
    void Start()
    {
        NumerosOrdenados(numeroUno, numeroDos, numeroTres);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void NumerosOrdenados(int n1, int n2, int n3)
    {
        int[] numeros = new int[3] { n1, n2,n3 };

        System.Array.Sort(numeros);

        Debug.Log("El orden de estos números de menor a mayor son: " + numeros[0] + ", " + numeros[1] + " y " + numeros[2]);
    }
}
