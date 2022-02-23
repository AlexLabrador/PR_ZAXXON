using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    InitGameScript initGameScript;
    [SerializeField] GameObject initObject;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = initGameScript.spaceship;
        initObject = GameObject.Find("initGameScripts");
        initGameScript = initObject.GetComponent<InitGameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Nave")
        {
            speed = speed += 5f;
        }
    }
}
