using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPression : MonoBehaviour
{

    GameObject Semelle;
    Renderer CouleurSemelle;

    [SerializeField]
    Color CouleurPourSemelle;

    // Use this for initialization
    void Start()
    {
        Semelle = GameObject.Find("Chaussure/Semelle");
        CouleurSemelle = Semelle.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        Debug.Log("Je suis pressé");
        CouleurSemelle.material.SetColor("_Color", CouleurPourSemelle);
    }
}
