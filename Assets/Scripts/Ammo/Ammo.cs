using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    private float currentSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.up * -1 * currentSpeed * Time.deltaTime);
    }
}
