using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSomethingElseColorExample : MonoBehaviour
{

    GameObject Semelle;
    Renderer CouleurSemelle;

    GameObject Lacets;
    Renderer CouleurLacets;

    GameObject CouleurPrincipale;
    Renderer CouleurCouleurPrincipale;

    GameObject DetailCote;
    Renderer CouleurDetailCote;

    GameObject DetailAvant;
    Renderer CouleurDetailAvant;

    GameObject DetailArriere;
    Renderer CouleurDetailArriere;

    [SerializeField]
    Color CouleurPourSemelle;

    [SerializeField]
    Color CouleurPourLacets;

    [SerializeField]
    Color CouleurPourCouleurPrincipale;

    [SerializeField]
    Color CouleurPourDetailCote;

    [SerializeField]
    Color CouleurPourDetailAvant;

    [SerializeField]
    Color CouleurPourDetailArriere;

    // Use this for initialization
    void Start()
    {
        Semelle = GameObject.Find("Chaussure/Semelle");
        CouleurSemelle = Semelle.GetComponent<Renderer>();
        Lacets = GameObject.Find("Chaussure/Lacets");
        CouleurLacets = Lacets.GetComponent<Renderer>();
        CouleurPrincipale = GameObject.Find("Chaussure/CouleurPrincipale");
        CouleurCouleurPrincipale = CouleurPrincipale.GetComponent<Renderer>();
        DetailCote = GameObject.Find("Chaussure/DetailCote");
        CouleurDetailCote = DetailCote.GetComponent<Renderer>();
        DetailAvant = GameObject.Find("Chaussure/DetailAvant");
        CouleurDetailAvant = DetailAvant.GetComponent<Renderer>();
        DetailArriere = GameObject.Find("Chaussure/DetailArriere");
        CouleurDetailArriere = DetailArriere.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        CouleurSemelle.material.SetColor("_Color", CouleurPourSemelle);
        CouleurLacets.material.SetColor("_Color", CouleurPourLacets);
        CouleurCouleurPrincipale.material.SetColor("_Color", CouleurPourCouleurPrincipale);
        CouleurDetailCote.material.SetColor("_Color", CouleurPourDetailCote);
        CouleurDetailAvant.material.SetColor("_Color", CouleurPourDetailAvant);
        CouleurDetailArriere.material.SetColor("_Color", CouleurPourDetailArriere);
    }
}
