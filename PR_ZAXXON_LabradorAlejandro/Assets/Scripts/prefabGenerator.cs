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
            posicion = new Vector3(Random.Range(-300f, 300f),Random.Range(0f,60f), Random.Range(500f, 1000f));
           intervalo = Random.Range(0.5f, 1f);
            Instantiate(MyPrefab, posicion, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);
        }
        
    }
}
