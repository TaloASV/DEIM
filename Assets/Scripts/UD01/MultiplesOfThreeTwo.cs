using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MultiplesDeTresDos();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void MultiplesDeTresDos()
    {
        string multiplos = "Mútiplos de 2 y 3 entre 0 y 100 son: ";

        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0 || i % 3 == 0)
            {
                multiplos += i + " ";
            }
        }

        Debug.Log(multiplos);
    }
}
