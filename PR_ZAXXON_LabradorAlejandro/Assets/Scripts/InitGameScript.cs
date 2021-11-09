using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class InitGameScript : MonoBehaviour
{   //variables generales
    public float spaceship;
    public float aparicionObs;
    private float gameSec;
    [SerializeField] Text velocidadEnPantalla;





    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("velocidad");
       
    }
    IEnumerator velocidad()
    {
        for (gameSec = 0; spaceship <= 1400; gameSec++)
        {
            spaceship = spaceship + gameSec;
            //print(spaceship);
            yield return new WaitForSeconds(1f);
        }

    }
    void Update()
    {
        reaparicionAumenta();
        print(Time.time);
        //velocidadAumenta();
        BackToTheFuture();
        VelocidadEnPantalla();
        Acelerar();


    }

    void reaparicionAumenta()
    {
        if (Time.time > 15)
        {
            aparicionObs = aparicionObs += -0.0001f;
        }

       
    }
    void velocidadAumenta()
    {
        if (Time.time > 0)
        {
            spaceship = spaceship +=0.05f;
        }
    }
    void BackToTheFuture()
    {
        if (spaceship > 140)
        {
            SceneManager.LoadScene("lv2");
        }
    }
    void VelocidadEnPantalla()
    {
        velocidadEnPantalla.text = spaceship + "";
    }

    void Acelerar()
    {
        if (Input.GetKey("space"))
        {
            print(spaceship);
            spaceship = spaceship += 0.05f;
        }
    }

}

 
