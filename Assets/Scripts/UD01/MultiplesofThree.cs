using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesofThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MultiplesDeTres();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MultiplesDeTres()
    {
        string multiplos = "Múltiplos de 3 entre 0 y 100 son: ";

        for (int i = 0; i <= 100; i++)
          {
            if (i % 3 == 0)
            {
                multiplos += i + " ";
            }
          }

        Debug.Log(multiplos);
    }


}
