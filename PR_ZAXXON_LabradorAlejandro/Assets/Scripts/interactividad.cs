using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactividad : MonoBehaviour
{
    [SerializeField] Vector3 PlayerPosition = new Vector3(0f, 0f, 0f);
    public float speed;


    //variables
    //movimienti
    



    //limites
    float limitR = 400f;
    float limitL = -400f;
    float limitUp = 500f;
    float limitDown = 20f;

    //variable bool limite
    bool inLimitY = false;
    bool inLimitX = false;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = PlayerPosition;

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        rotation();
        //limite de movimiento en y
        //limiteY();

        //limite de movimiento en x
        //limiteX();



        /*transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * speed);
        transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * speed);
        */


        //rotacion







    }
    void rotation()
    {
        

        float rot = Input.GetAxis("rotacion") * 2f;

        transform.Rotate(Vector3.back * Time.deltaTime * rot * speed);
    }


    void PlayerMovement()
    {

        float posX = transform.position.x;
        float posY = transform.position.y;
        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");
        //despX
        if (inLimitX)
        {
            transform.Translate(Vector3.right * desplX * Time.deltaTime * speed, Space.World);
        }

        if(posX > limitR && desplX > 0)
        {
            inLimitX = false;
        }
        else if (posX < limitL && desplX < 0)
        {
            inLimitX = false;

        }
        else
        {
            inLimitX = true;
        }
        //desplY
        if (inLimitY)
        {
            transform.Translate(Vector3.up * desplY * Time.deltaTime * speed, Space.World);

        }

        if (posY > limitUp && desplY > 0)
        {
            inLimitY = false;
        }
        else if (posY < limitDown && desplY < 0)
        {
            inLimitY = false;

        }
        else
        {
            inLimitY = true;
        }

    }
  /* void limiteX()
    {
        if (transform.position.x < -99)
        {
            transform.position = new Vector3(-99, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 99)
        {
            transform.position = new Vector3(99, transform.position.y, transform.position.z);
        }
    }
    void limiteY()
    {
        if (transform.position.y < 2)
        {
            transform.position = new Vector3(transform.position.x, 2, transform.position.z);
        }
        if (transform.position.y > 100)
        {
            transform.position = new Vector3(transform.position.x,100, transform.position.z);
        }
    }*/
    











}
