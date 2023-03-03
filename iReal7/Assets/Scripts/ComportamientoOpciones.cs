using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ComportamientoOpciones : MonoBehaviour
{
    [Header("Prefabs de cubos")]
    [SerializeField] GameObject _PrefabCube1;
    [SerializeField] GameObject _PrefabCube2;
    [SerializeField] GameObject _PrefabCube3;
    [SerializeField] Transform _PosicionIniCubo;
    [SerializeField] GameObject _CuboActivo;
    [Header("Materiales para superficie")]
    [SerializeField] PhysicMaterial _PhisicalMaterialLija;
    [SerializeField] PhysicMaterial _PhisicalMaterialTela;
    [SerializeField] PhysicMaterial _PhisicalMaterialPapel;
    [SerializeField] BoxCollider _BoxColliderSuperficie;
    [SerializeField] Renderer _Superficie;
    [SerializeField] Material _TexturaLija;
    [SerializeField] Material _TexturaTela;
    [SerializeField] Material _TexturaPapel;
    [Header("Toggle Selectores")]
    [SerializeField] Toggle _Cubo1;
    [SerializeField] Toggle _Cubo2;
    [SerializeField] Toggle _Cubo3;
    [SerializeField] Toggle _Tela;
    [SerializeField] Toggle _Lija;
    [SerializeField] Toggle _Papel;
    [Header("General")]
    [SerializeField] AudioSource _notificacion;




    public void CambioValorCubos(int numcubo)
    {
            if (_CuboActivo != null)
            {
                Destroy(_CuboActivo);
            }

            if (numcubo == 1)
                StartCoroutine(InstanciarCubo(_PrefabCube1));
            if (numcubo == 2)
                StartCoroutine(InstanciarCubo(_PrefabCube2));
            if (numcubo == 3)
                StartCoroutine(InstanciarCubo(_PrefabCube3));
    
    }

    public void CambioMaterialSuperficie(int tiposuperficie)
    {
        if (tiposuperficie == 1)
            _BoxColliderSuperficie.material = _PhisicalMaterialTela;
        else if (tiposuperficie == 2)
        {
            _BoxColliderSuperficie.material = _PhisicalMaterialLija;
            _Superficie.material = _TexturaLija;
        }
        else
            _BoxColliderSuperficie.material = _PhisicalMaterialPapel;


    }

    IEnumerator InstanciarCubo(GameObject cubo)
    {
        _CuboActivo = Instantiate(cubo);
        cubo.transform.position = _PosicionIniCubo.transform.position;
        cubo.transform.rotation = _PosicionIniCubo.transform.rotation;
        yield return null;
    }

    public void RegresarMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void SalirApp()
    {
        Application.Quit();
    }
}
