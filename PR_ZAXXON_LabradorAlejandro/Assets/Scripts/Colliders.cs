using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colliders : MonoBehaviour
{
    [SerializeField] GameObject columnaObs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    
   /* void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Nave")
        {
            Destroy(this.gameObject);
        }
    }*/
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Nave")
        {
            print(other.gameObject.tag);
            Destroy(other.gameObject);
        }
    }

    void DestruirObs()
    {
       
        if (transform.position.z <= -10)
        {
            Destroy(columnaObs);
             
        }


    }
}
