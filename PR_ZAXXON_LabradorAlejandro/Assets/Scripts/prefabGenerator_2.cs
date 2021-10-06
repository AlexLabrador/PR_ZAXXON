using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabGenerator_2 : MonoBehaviour
{
    float intervalo_2;
    [SerializeField] Transform posInst;
    [SerializeField] GameObject MySecondPrefab;

    public Vector3 posicion_2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CrearObstaculos2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CrearObstaculos2()
    {
        while (true)
        {
            posicion_2 = new Vector3(Random.Range(-95f, 95f), Random.Range(50f, 100f), Random.Range(500f, 600f));
            intervalo_2 = Random.Range(1f, 1.5f);
            Instantiate(MySecondPrefab, posicion_2, Quaternion.identity);
            yield return new WaitForSeconds(intervalo_2);
        }

    }
}
