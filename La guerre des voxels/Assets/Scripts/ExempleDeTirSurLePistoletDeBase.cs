using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExempleDeTirSurLePistoletDeBase : MonoBehaviour
{

    [SerializeField]
    GameObject Balle;

    [SerializeField]
    GameObject Chargeur;

    [SerializeField]
    GameObject Douille;

    GameObject BalleActuelle;
    GameObject ChargeurActuel;
    GameObject DouilleActuelle;
    GameObject AncienChargeur;

    int BalleDansChargeur;

    [SerializeField]
    int BalleDansChargeurMax = 10;

    float TempsRestantAvantRéinsertion;
    float TempsVouluAvantRéinsertion = 1;

    [SerializeField]
    float Puissance = 10;

    // Use this for initialization
    void Start()
    {
        TempsRestantAvantRéinsertion = Mathf.Infinity;
        BalleDansChargeur = BalleDansChargeurMax;
        BalleActuelle = Instantiate(Balle, gameObject.transform.position, gameObject.transform.rotation);
        ChargeurActuel = Instantiate(Chargeur, gameObject.transform);
        DouilleActuelle = Instantiate(Douille, gameObject.transform.position, gameObject.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (BalleDansChargeur == 0)
        {
            Debug.Log("Rechargement");
            ChargeurActuel.GetComponent<Rigidbody>().useGravity = true;
            ChargeurActuel.GetComponent<Rigidbody>().AddForce(new Vector3(0, 10, 0));
            Debug.Log("Chargeur retiré");
            TempsRestantAvantRéinsertion = TempsVouluAvantRéinsertion + Time.realtimeSinceStartup;
            BalleDansChargeur = BalleDansChargeurMax;
        }
        if (Time.realtimeSinceStartup >= TempsRestantAvantRéinsertion)
        {
            ChargeurActuel = Instantiate(Chargeur, gameObject.transform.position, gameObject.transform.rotation);
            Debug.Log("Chargeur réinséré");
            TempsRestantAvantRéinsertion = Mathf.Infinity;
        }
       
    }
    void OnMouseDown()
    {
        BalleActuelle.GetComponent<Rigidbody>().AddForce(new Vector3(Puissance, 0, 0), ForceMode.Impulse);
        DouilleActuelle.GetComponent<Rigidbody>().AddForce(new Vector3(Puissance, 0, 0), ForceMode.Impulse);
        BalleDansChargeur -= 1;
        Debug.Log(BalleDansChargeur);
        BalleActuelle = Instantiate(Balle, gameObject.transform.position, gameObject.transform.rotation);
        DouilleActuelle = Instantiate(Douille, gameObject.transform.position, gameObject.transform.rotation);
    }
}