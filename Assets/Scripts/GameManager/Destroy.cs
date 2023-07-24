using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float min = 3;
    public float max = 5;

    void Start()
    {
        Destroy(gameObject, Random.Range(min,max));
    }
}
