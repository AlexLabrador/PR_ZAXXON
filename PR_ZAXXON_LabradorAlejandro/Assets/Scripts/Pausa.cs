using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    [SerializeField]  GameObject botonPausa;
    [SerializeField]  GameObject menuPausa;

    public void Pausar()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);

    }
    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void Cerrar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Inicio");
    }
    public void TextoInicio()
    {

    }
}
