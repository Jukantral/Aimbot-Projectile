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
    public float angleYinter;
    public float tempsdinter;

    public float initRouge;
    private void Start()
    {
        //initRouge = rouge.transform.position.z;
    }
    void Update()
    {
        var temps = GameObject.FindGameObjectWithTag("Finish").GetComponent<Temps>().time;
        speedRouge = rouge.GetComponent<EquationRouge>().speed;
        float beta = rouge.GetComponent<EquationRouge>().angleXZ * Mathf.Deg2Rad;
        float alpha = rouge.GetComponent<EquationRouge>().angleYwithPlan * Mathf.Deg2Rad;
        float x0 = rouge.GetComponent<EquationRouge>().x0;
        float y0 = rouge.GetComponent<EquationRouge>().y0;
        float z0 = rouge.GetComponent<EquationRouge>().z0;
        float val = speedRouge * temps;
        float val2 = speed * temps;

        //equation degeulasse.

        float test = Mathf.Pow(x0 + Mathf.Sin(beta) * Mathf.Cos(alpha) * val, 2) + Mathf.Pow(z0 + Mathf.Cos(beta) * Mathf.Cos(alpha) * val, 2) + Mathf.Pow(y0 + Mathf.Sin(alpha) * val, 2);
        Debug.Log("Partie gauche : " + test + " Partie droite : " + val2*val2);

        float c = x0 * x0 + y0 * y0 + z0 * z0;
        float b = 2 * speedRouge *  (Mathf.Sin(beta) * Mathf.Cos(alpha)*x0 + Mathf.Cos(beta) * Mathf.Cos(alpha)*z0 + Mathf.Sin(alpha) * y0);
        float a = speedRouge * speedRouge * (Mathf.Cos(beta) * Mathf.Cos(alpha) * Mathf.Cos(beta) * Mathf.Cos(alpha) + Mathf.Sin(alpha) * Mathf.Sin(alpha) + Mathf.Sin(beta) * Mathf.Cos(alpha) * Mathf.Sin(beta) * Mathf.Cos(alpha)) - speed * speed;
        float delta = b * b - 4 * a * c;
        float racinedelta = 0;
        if (delta >= 0)
        {
            racinedelta = Mathf.Sqrt(delta);
        }

        float r1 = (-b - racinedelta) / 2;
        float r2 = (-b + racinedelta) / 2;
        if (r1 > 0)
        {
            tempsdinter = r1;
        }
        else if (r2 > 0)
        {
            tempsdinter = r2;
        }
        float xfinale;
        float yfinale;
        float zfinale;
       


       /* angleYinter = Mathf.Asin(( Mathf.Sin(alpha * Mathf.Deg2Rad) * speedRouge) / speed);
        float angletr = angleYinter;
        angleYinter = angleYinter * Mathf.Rad2Deg;

        angle = Mathf.Acos((speedRouge * Mathf.Cos(beta * Mathf.Deg2Rad) * Mathf.Cos(alpha * Mathf.Deg2Rad)) / speed * angleYinter);     //Mathf.Asin((speedRouge) / speed);
        float ang = angle;
        angle = angle * Mathf.Rad2Deg;*/





        /*float val = speed * temps;
        Debug.Log(Mathf.Sin(ang));
        transform.position = new Vector3(Mathf.Sin(ang) * val * Mathf.Cos(angletr), val * Mathf.Sin(angletr), Mathf.Cos(angletr)*Mathf.Cos(ang)*val);*/
    }
}
