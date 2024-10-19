using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    public int numeroMes;

    // Start is called before the first frame update
    void Start()
    {
       MostrarMes(numeroMes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MostrarMes(int mes)
    {
        string[] nombreMeses = { "Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre" };
    
        Debug.Log("El mes es: " + nombreMeses[mes - 1]);
    }
}
