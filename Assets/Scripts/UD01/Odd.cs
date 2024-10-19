using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NumerosImpares();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void NumerosImpares()
    {
        string impares = "Números impares entre 0 y 100 son: ";

        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
              impares += i + " ";
            }
        }
    
       Debug.Log(impares);     
    }
}
