using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class prefabMove : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject initObject;
    InitGameScript initGameScript;
    private bool enMovimiento;
   
    // Start is called before the first frame update
    void Start()
    {
        initObject = GameObject.Find("initGameScripts");
        initGameScript = initObject.GetComponent<InitGameScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = initGameScript.spaceship;
        transform.Translate(Vector3.back * Time.deltaTime * speed);
       
    }
}
