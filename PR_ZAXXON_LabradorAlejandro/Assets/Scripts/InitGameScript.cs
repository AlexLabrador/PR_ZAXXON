using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGameScript : MonoBehaviour
{   //variables generales
    public float spaceship;
    public float NaveVelocidad;
    public float aparicionObs;




    float score;
    [SerializeField] float maxSpeed;
         
    bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (spaceship < maxSpeed && alive == true)
        {
            spaceship = 0.001f;
        }
        float tiempo = Time.time;
        print(Mathf.Round(tiempo));
    }
}
