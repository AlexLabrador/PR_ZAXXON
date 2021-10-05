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
        if (transform.position.y < -13)
        {
            transform.position = new Vector3(transform.position.x, -13, transform.position.z);
        }
        if (transform.position.y > 60)
        {
            transform.position = new Vector3(transform.position.x, 60, transform.position.z);
        }

        //limite de movimiento en x
        if (transform.position.x < -99)
        {
            transform.position = new Vector3(-99, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 99)
        {
            transform.position = new Vector3(99, transform.position.y, transform.position.z);
        }



        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * speed);
        transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * speed);




       float rot = Input.GetAxis("rotacion") * 1.5f;
       
        transform.Rotate(Vector3.back * Time.deltaTime * rot * speed);

       /* if(transform.rotation.z < -20)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, -20);
        }
        if (transform.rotation.z < 20)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 20);
        }
       */
      
    }
}
