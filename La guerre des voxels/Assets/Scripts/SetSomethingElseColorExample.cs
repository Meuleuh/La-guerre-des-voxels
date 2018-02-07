using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSomethingElseColorExample : MonoBehaviour
{
    [SerializeField]
    GameObject ChaussureGauche;

    GameObject SemelleGauche;
    Renderer RendererSemelleGauche;
    GameObject LacetsGauche;
    Renderer RendererLacetsGauche;
    GameObject PartiePrincipaleGauche;
    Renderer RendererPartiePrincipaleGauche;
    GameObject DétailCôtéGauche;
    Renderer RendererDétailCôtéGauche;
    GameObject DétailAvantGauche;
    Renderer RendererDétailAvantGauche;
    GameObject DétailArrièreGauche;
    Renderer RendererDétailArrièreGauche;

    [SerializeField]
    Color CouleurSemelleGauche;

    [SerializeField]
    Color CouleurLacetsGauche;

    [SerializeField]
    Color CouleurPartiePrincipaleGauche;

    [SerializeField]
    Color CouleurDétailCôtéGauche;

    [SerializeField]
    Color CouleurDétailAvantGauche;

    [SerializeField]
    Color CouleurDétailArrièreGauche;

    GameObject ChaussureActuelleGauche;

    [SerializeField]
    GameObject ChaussureDroite;

    GameObject SemelleDroite;
    Renderer RendererSemelleDroite;
    GameObject LacetsDroite;
    Renderer RendererLacetsDroite;
    GameObject PartiePrincipaleDroite;
    Renderer RendererPartiePrincipaleDroite;
    GameObject DétailCôtéDroite;
    Renderer RendererDétailCôtéDroite;
    GameObject DétailAvantDroite;
    Renderer RendererDétailAvantDroite;
    GameObject DétailArrièreDroite;
    Renderer RendererDétailArrièreDroite;

    [SerializeField]
    Color CouleurSemelleDroite;

    [SerializeField]
    Color CouleurLacetsDroite;

    [SerializeField]
    Color CouleurPartiePrincipaleDroite;

    [SerializeField]
    Color CouleurDétailCôtéDroite;

    [SerializeField]
    Color CouleurDétailAvantDroite;

    [SerializeField]
    Color CouleurDétailArrièreDroite;

    GameObject ChaussureActuelleDroite;

    Transform PositionChaussure2;
    // Use this for initialization
    void Start()
    {
        ChaussureActuelleGauche = Instantiate(ChaussureGauche);
        SemelleGauche = ChaussureActuelleGauche.transform.Find("Semelle").gameObject;
        LacetsGauche = ChaussureActuelleGauche.transform.Find("Lacets").gameObject;
        PartiePrincipaleGauche = ChaussureActuelleGauche.transform.Find("Partie principale").gameObject;
        DétailCôtéGauche = ChaussureActuelleGauche.transform.Find("Détail côté").gameObject;
        DétailAvantGauche = ChaussureActuelleGauche.transform.Find("Détail avant").gameObject;
        DétailArrièreGauche = ChaussureActuelleGauche.transform.Find("Détail arrière").gameObject;
        RendererSemelleGauche = SemelleGauche.GetComponent<Renderer>();
        RendererLacetsGauche = LacetsGauche.GetComponent<Renderer>();
        RendererPartiePrincipaleGauche = PartiePrincipaleGauche.GetComponent<Renderer>();
        RendererDétailCôtéGauche = DétailCôtéGauche.GetComponent<Renderer>();
        RendererDétailAvantGauche = DétailAvantGauche.GetComponent<Renderer>();
        RendererDétailArrièreGauche = DétailArrièreGauche.GetComponent<Renderer>();
        SemelleGauche = ChaussureActuelleGauche.transform.Find("Semelle").gameObject;
        LacetsGauche = ChaussureActuelleGauche.transform.Find("Lacets").gameObject;
        PartiePrincipaleGauche = ChaussureActuelleGauche.transform.Find("Partie principale").gameObject;
        DétailCôtéGauche = ChaussureActuelleGauche.transform.Find("Détail côté").gameObject;
        DétailAvantGauche = ChaussureActuelleGauche.transform.Find("Détail avant").gameObject;
        DétailArrièreGauche = ChaussureActuelleGauche.transform.Find("Détail arrière").gameObject;
        RendererSemelleGauche = SemelleGauche.GetComponent<Renderer>();
        RendererLacetsGauche = LacetsGauche.GetComponent<Renderer>();
        RendererPartiePrincipaleGauche = PartiePrincipaleGauche.GetComponent<Renderer>();
        RendererDétailCôtéGauche = DétailCôtéGauche.GetComponent<Renderer>();
        RendererDétailAvantGauche = DétailAvantGauche.GetComponent<Renderer>();
        RendererDétailArrièreGauche = DétailArrièreGauche.GetComponent<Renderer>();


        ChaussureActuelleDroite = Instantiate(ChaussureDroite);
        SemelleDroite = ChaussureActuelleDroite.transform.Find("Semelle").gameObject;
        LacetsDroite = ChaussureActuelleDroite.transform.Find("Lacets").gameObject;
        PartiePrincipaleDroite = ChaussureActuelleDroite.transform.Find("Partie principale").gameObject;
        DétailCôtéDroite = ChaussureActuelleDroite.transform.Find("Détail côté").gameObject;
        DétailAvantDroite = ChaussureActuelleDroite.transform.Find("Détail avant").gameObject;
        DétailArrièreDroite = ChaussureActuelleDroite.transform.Find("Détail arrière").gameObject;
        RendererSemelleDroite = SemelleDroite.GetComponent<Renderer>();
        RendererLacetsDroite = LacetsDroite.GetComponent<Renderer>();
        RendererPartiePrincipaleDroite = PartiePrincipaleDroite.GetComponent<Renderer>();
        RendererDétailCôtéDroite = DétailCôtéDroite.GetComponent<Renderer>();
        RendererDétailAvantDroite = DétailAvantDroite.GetComponent<Renderer>();
        RendererDétailArrièreDroite = DétailArrièreDroite.GetComponent<Renderer>();
        SemelleDroite = ChaussureActuelleDroite.transform.Find("Semelle").gameObject;
        LacetsDroite = ChaussureActuelleDroite.transform.Find("Lacets").gameObject;
        PartiePrincipaleDroite = ChaussureActuelleDroite.transform.Find("Partie principale").gameObject;
        DétailCôtéDroite = ChaussureActuelleDroite.transform.Find("Détail côté").gameObject;
        DétailAvantDroite = ChaussureActuelleDroite.transform.Find("Détail avant").gameObject;
        DétailArrièreDroite = ChaussureActuelleDroite.transform.Find("Détail arrière").gameObject;
        RendererSemelleDroite = SemelleDroite.GetComponent<Renderer>();
        RendererLacetsDroite = LacetsDroite.GetComponent<Renderer>();
        RendererPartiePrincipaleDroite = PartiePrincipaleDroite.GetComponent<Renderer>();
        RendererDétailCôtéDroite = DétailCôtéDroite.GetComponent<Renderer>();
        RendererDétailAvantDroite = DétailAvantDroite.GetComponent<Renderer>();
        RendererDétailArrièreDroite = DétailArrièreDroite.GetComponent<Renderer>();




    }

    // Update is called once per frame
    void Update()
    {
        RendererSemelleGauche.material.SetColor("_Color", CouleurSemelleGauche);
        RendererLacetsGauche.material.SetColor("_Color", CouleurLacetsGauche);
        RendererPartiePrincipaleGauche.material.SetColor("_Color", CouleurPartiePrincipaleGauche);
        RendererDétailCôtéGauche.material.SetColor("_Color", CouleurDétailCôtéGauche);
        RendererDétailAvantGauche.material.SetColor("_Color", CouleurDétailAvantGauche);
        RendererDétailArrièreGauche.material.SetColor("_Color", CouleurDétailArrièreGauche);

        RendererSemelleDroite.material.SetColor("_Color", CouleurSemelleDroite);
        RendererLacetsDroite.material.SetColor("_Color", CouleurLacetsDroite);
        RendererPartiePrincipaleDroite.material.SetColor("_Color", CouleurPartiePrincipaleDroite);
        RendererDétailCôtéDroite.material.SetColor("_Color", CouleurDétailCôtéDroite);
        RendererDétailAvantDroite.material.SetColor("_Color", CouleurDétailAvantDroite);
        RendererDétailArrièreDroite.material.SetColor("_Color", CouleurDétailArrièreDroite);
    }
}
