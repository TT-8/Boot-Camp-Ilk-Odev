using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChanger : MonoBehaviour
{
    public Vector3 YeniPozisyon;

    void Start()
    {
        //transform.position = YeniPozisyon;
        transform.position = new Vector3(Random.Range(0, 5), Random.Range(0, 5), Random.Range(0, 5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
