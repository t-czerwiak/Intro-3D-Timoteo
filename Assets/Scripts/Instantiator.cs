using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject cuboPrefab;
    void Start()
    {
        Instantiate(cuboPrefab);
    }

    public void instanciarCubo()
    {
        Instantiate(cuboPrefab);
    }
}
