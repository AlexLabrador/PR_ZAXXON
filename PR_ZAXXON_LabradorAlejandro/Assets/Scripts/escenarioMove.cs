using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escenarioMove : MonoBehaviour
{
   
    InitGameScript InitGameScript;
    [SerializeField] float speed;
    [SerializeField] GameObject terrenoPrefab;
    Vector3 intpos = new Vector3(0, 0.1f, 0);
    // Start is called before the first frame update
    void Start()
    {
        InitGameScript = GameObject.Find("initGameScripts").GetComponent<InitGameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = InitGameScript.spaceship;
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        if (transform.position.z <= -100)
        {
            Instantiate(terrenoPrefab, intpos, Quaternion.identity);
            Destroy(terrenoPrefab);
        }
    }
}
