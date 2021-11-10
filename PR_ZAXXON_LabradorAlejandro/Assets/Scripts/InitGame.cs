using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartGame();
    }
     void StartGame()
    {
        if (Input.GetButton("StartGame"))
        {

            SceneManager.LoadScene("Nivel_1");
        }
        
    }
}
