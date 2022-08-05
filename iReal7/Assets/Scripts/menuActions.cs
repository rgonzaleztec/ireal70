using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuActions : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource audiogeneral;

    public void QuitApplication ()
    {
        Application.Quit();
    }

    public void LaunchScene1()
    {
        //Agregar una animacion de cambio de escena
        SceneManager.LoadScene(1);
    }

    public void LaunchScene2()
    {
        //Agregar una animacion de cambio de escena
        SceneManager.LoadScene(2);
    }

    public void LaunchScene3()
    {
        SceneManager.LoadScene(3);  
    }

    public void MuteAudio()
    {
        if (audiogeneral.isPlaying)
        {
            audiogeneral.Stop();
        }
        else
        {
            audiogeneral.Play();
        }
    }


    
}
