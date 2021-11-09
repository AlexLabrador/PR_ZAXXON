using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;


public class InitGameScript : MonoBehaviour
{   //variables generales
    public float spaceship;
    public float NaveVelocidad;
    public float aparicionObs;
    private float gameSec;





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
        velocidadAumenta();
        BackToTheFuture();

    }

    void reaparicionAumenta()
    {
        if (spaceship > 60)
        {
            aparicionObs = aparicionObs += -0.0002f;
        }

       
    }
    void velocidadAumenta()
    {
        if (Time.time > 10)
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

}

 
