using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarNaves : MonoBehaviour
{
    float intervalo;
    [SerializeField] Transform posInst;
    [SerializeField] GameObject[] MyPrefab;
    [SerializeField] GameObject initObject;

    InitGameScript initGameScript;

    public Vector3 posicion;
    // Start is called before the first frame update
    void Start()
    {
        initObject = GameObject.Find("initGameScripts");
        initGameScript = initObject.GetComponent<InitGameScript>();
        StartCoroutine("CrearNaves");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CrearNaves()
    {
        while (true)
        {
            int randomNum = Random.Range(0, MyPrefab.Length);
            ; posicion = new Vector3(Random.Range(-9f, 9f),(Random.Range(5f, 15f)), transform.position.z + 100f);
            //intervalo = Random.Range(0.5f, 1f);
            intervalo = initGameScript.aparicionObs;
            Instantiate(MyPrefab[randomNum], posicion, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);
        }

    }
}
