using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabGenerator : MonoBehaviour
{
    float intervalo;
    [SerializeField] Transform posInst;
    [SerializeField] GameObject MyPrefab;
    
    public Vector3 posicion;
    

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("CrearObstaculos");
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CrearObstaculos()
    {
        while (true)
        {
            posicion = new Vector3(Random.Range(-130f,130f),Random.Range(60f,100f), Random.Range(1500,1500f));
           //intervalo = Random.Range(0.5f, 1f);
            intervalo =0.35f;
            Instantiate(MyPrefab, posicion, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);
        }
        
    }
}
