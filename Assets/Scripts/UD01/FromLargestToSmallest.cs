using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
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
        int[] numeros = new int[3] { n1, n2, n3 };

        System.Array.Sort(numeros);

        System.Array.Reverse(numeros);

        Debug.Log("El orden de estos números de mayor a menor son: " + numeros[0] + ", " + numeros[1] + " y " + numeros[2]);
    }
}
