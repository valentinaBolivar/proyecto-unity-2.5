using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masaCorporal : MonoBehaviour
{
    public string nombreUsuario;
    public float alturaCm;
    public int kilogramos;
   
    // Start is called before the first frame update
    void Start()
    {
      float IMC = 0;
        Debug.Log(nombreUsuario);
        Debug.Log(alturaCm);
        Debug.Log(kilogramos);
        Debug.Log(kilogramos / (alturaCm * alturaCm));

        //  IMC = kilogramos / (alturaCm * alturaCm);

        if (IMC <= 20.8 || IMC >= 21.8)
        {
            Debug.Log("correcto");
        }
        else
        {
            Debug.Log("incorrecto");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
