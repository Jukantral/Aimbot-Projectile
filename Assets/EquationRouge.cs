using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquationRouge : MonoBehaviour
{
    public float x0; // marche pas
    public float z0;
    public float y0; // marche pas

    public float angle;
    public float speed;

    public float speedZ;
    void Update()
    {
        var time = GameObject.FindGameObjectWithTag("Finish").GetComponent<Temps>().time;
        float val = speed * time;
        transform.position = new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad) * val + x0, speedZ * time + y0, Mathf.Sin(angle * Mathf.Deg2Rad) * val + z0);
    }
}
