using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabGenerator : MonoBehaviour
{
    [SerializeField] Transform posInst;
    [SerializeField] GameObject MyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(MyPrefab, posInst);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
