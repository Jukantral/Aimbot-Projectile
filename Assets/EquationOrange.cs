using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquationOrange : MonoBehaviour
{


    public GameObject rouge;
    public float speed;
    public float speedRouge;
    public float speedRougeZ;
    public float angle;

    public float initRouge;
    private void Start()
    {
        initRouge = rouge.transform.position.z;
    }
    void Update()
    {
        var temps = GameObject.FindGameObjectWithTag("Finish").GetComponent<Temps>().time;
        speedRouge = rouge.GetComponent<EquationRouge>().speed;
        speedRougeZ = rouge.GetComponent<EquationRouge>().speedZ;
        float beta = rouge.GetComponent<EquationRouge>().angle;

        angle = Mathf.Asin((speedRouge * Mathf.Cos(beta * Mathf.Deg2Rad)) / speed);     //Mathf.Asin((speedRouge) / speed);
        float ang = angle;
        angle = angle * Mathf.Rad2Deg;
        float val = speed * temps;
        transform.position = new Vector3(Mathf.Sin(ang) * val, speedRougeZ * temps, Mathf.Cos(ang)*val);
    }
}
