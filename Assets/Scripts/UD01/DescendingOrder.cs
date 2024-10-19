using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    public int numeroUno;
    public int numeroDos;
    public int numeroTres;

    // Start is called before the first frame update
    void Start()
    {
        DetectorDecreciente(numeroUno, numeroDos, numeroTres);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void DetectorDecreciente(int n1, int n2, int n3)
    {
        if (n1 > n2 && n2 > n3)
        {
            Debug.Log("Los números están en orden decreciente.");
        }

        else
        {
            Debug.Log("Los números no están en orden decreciente.");
        }
    }
}
