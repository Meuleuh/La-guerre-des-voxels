using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    [SerializeField]
    Texture Texture;

    Renderer Renderer;

    // Use this for initialization
    void Start()
    {
        Renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Texture Loaded Sucessfully...");
        Renderer.material.mainTexture = Texture;
    }
}
