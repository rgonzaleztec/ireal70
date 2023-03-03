using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuActions : MonoBehaviour
{
    // Start is called before the first frame update
    

    public AudioSource audiogeneral;
    public AudioSource audioButton;
    public GameObject UICubos;
    public GameObject UISuperficie;
    public GameObject UIMute;
    public GameObject UIUnmute;
    public GameObject Mesa;
    public GameObject Lija;
    public GameObject Carton;
    public GameObject Tela;
    public GameObject Cubo1;
    public GameObject Cubo2;
    public GameObject Cubo3;

    public void QuitApplication ()
    {
        Application.Quit();
    }

    public void LaunchScene0()
    {
        //Agregar una animacion de cambio de escena
        SceneManager.LoadScene(0);
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


    public void SoundButton(){
        audioButton.Play();
    }
    
    public void MuteAudio()
    {
        if (audiogeneral.isPlaying)
        {
            audiogeneral.Stop();
            UIUnmute.SetActive(false);
            UIMute.SetActive(true);
            
        }
        else
        {
            UIMute.SetActive(false);
            UIUnmute.SetActive(true);
            audiogeneral.Play();
        }
    }

    public void btncontinuar(){
        UICubos.SetActive(true);
        UISuperficie.SetActive(true);
        Mesa.SetActive(true);
    }
    public void btnLija(){
        Carton.SetActive(false);
        Tela.SetActive(false);
        Lija.SetActive(true);
    }
    public void btnCarton(){ 
        Tela.SetActive(false);
        Lija.SetActive(false);
        Carton.SetActive(true);
    }
    public void btnTela(){
        Lija.SetActive(false);
        Carton.SetActive(false);
        Tela.SetActive(true);
    }

    public void btnCubo1(){
        Cubo3.SetActive(false);
        Cubo2.SetActive(false);
        Cubo1.SetActive(true);
    }
    public void btnCubo2(){ 
        Cubo3.SetActive(false);
        Cubo1.SetActive(false);
        Cubo2.SetActive(true);
    }
    public void btnCubo3(){
        Cubo1.SetActive(false);
        Cubo2.SetActive(false);
        Cubo3.SetActive(true);
    }

    
}
