using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquationRouge : MonoBehaviour
{
    public float x0; // marche pas
    public float z0;
    public float y0; // marche pas

    
    public float angleYwithPlan;
    public float angleXZ;

    public float speed;
    void Update()
    {
        var time = GameObject.FindGameObjectWithTag("Finish").GetComponent<Temps>().time;
        float val = speed * time;
        transform.position = new Vector3(Mathf.Sin(angleXZ * Mathf.Deg2Rad) * Mathf.Cos(angleYwithPlan * Mathf.Deg2Rad) * val + x0,
                                         val * Mathf.Sin(angleYwithPlan * Mathf.Deg2Rad) + y0,
                                         Mathf.Cos(angleXZ * Mathf.Deg2Rad) * val * Mathf.Cos(angleYwithPlan * Mathf.Deg2Rad) + z0);
    }
}
