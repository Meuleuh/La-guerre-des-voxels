using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSomethingElseColorExample : MonoBehaviour
{
    GameObject Semelle;
    Renderer RendererSemelle;
    GameObject Lacets;
    Renderer RendererLacets;
    GameObject PartiePrincipale;
    Renderer RendererPartiePrincipale;
    GameObject DétailCôté;
    Renderer RendererDétailCôté;
    GameObject DétailAvant;
    Renderer RendererDétailAvant;
    GameObject DétailArrière;
    Renderer RendererDétailArrière;

    [SerializeField]
    Color CouleurSemelle;

    [SerializeField]
    Color CouleurLacets;

    [SerializeField]
    Color CouleurPartiePrincipale;

    [SerializeField]
    Color CouleurDétailCôté;

    [SerializeField]
    Color CouleurDétailAvant;

    [SerializeField]
    Color CouleurDétailArrière;

    [SerializeField]
    GameObject Chaussure;

    GameObject ChaussureActuelle;
    // Use this for initialization
    void Start()
    {
        ChaussureActuelle = Instantiate(Chaussure);
        Semelle = ChaussureActuelle.transform.Find("Semelle").gameObject;
        Lacets = ChaussureActuelle.transform.Find("Lacets").gameObject;
        PartiePrincipale = ChaussureActuelle.transform.Find("Partie principale").gameObject;
        DétailCôté = ChaussureActuelle.transform.Find("Détail côté").gameObject;
        DétailAvant = ChaussureActuelle.transform.Find("Détail avant").gameObject;
        DétailArrière = ChaussureActuelle.transform.Find("Détail arrière").gameObject;
        RendererSemelle = Semelle.GetComponent<Renderer>();
        RendererLacets = Lacets.GetComponent<Renderer>();
        RendererPartiePrincipale = PartiePrincipale.GetComponent<Renderer>();
        RendererDétailCôté = DétailCôté.GetComponent<Renderer>();
        RendererDétailAvant = DétailAvant.GetComponent<Renderer>();
        RendererDétailArrière = DétailArrière.GetComponent<Renderer>();


    }

    // Update is called once per frame
    void Update()
    {
        RendererSemelle.material.SetColor("_Color", CouleurSemelle);
        RendererLacets.material.SetColor("_Color", CouleurLacets);
        RendererPartiePrincipale.material.SetColor("_Color", CouleurPartiePrincipale);
        RendererDétailCôté.material.SetColor("_Color", CouleurDétailCôté);
        RendererDétailAvant.material.SetColor("_Color", CouleurDétailAvant);
        RendererDétailArrière.material.SetColor("_Color", CouleurDétailArrière);
    }
}
