using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManagerScript : MonoBehaviour
{
    public static menuManagerScript Instance { get; private set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int level;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

}
