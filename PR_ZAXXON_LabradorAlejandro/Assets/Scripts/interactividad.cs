using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactividad : MonoBehaviour
{
    [SerializeField] Vector3 PlayerPosition = new Vector3(0f, 0f, 0f);
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = PlayerPosition;

    }

    // Update is called once per frame
    void Update()
    {
        //limite de movimiento en y
        limiteY();

        //limite de movimiento en x
        limiteX();



        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * speed);
        transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * speed);


        //rotacion
        rotation();
   
      




    }
    void rotation()
    {
        float rot = Input.GetAxis("rotacion") * 2f;

        transform.Rotate(Vector3.back * Time.deltaTime * rot * speed);
    }
    void limiteX()
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
    }
}
