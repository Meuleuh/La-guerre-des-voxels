using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExempleDeTirSurLePistoletDeBase : MonoBehaviour
{

    [SerializeField]
    GameObject Balle;

    GameObject BalleActuelle;


    // Use this for initialization
    void Start()
    {
        BalleActuelle = Instantiate(Balle, gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(BalleActuelle.transform.position);
    }
}
