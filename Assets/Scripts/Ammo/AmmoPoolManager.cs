using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPoolManager : MonoBehaviour
{
    public static AmmoPoolManager Instance;
    public GameObject ammoPrefab;
    
    void Awake()
    {
        Instance = this;
    }

}
