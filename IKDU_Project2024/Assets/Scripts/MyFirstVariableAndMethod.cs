using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstVariableAndMethod : MonoBehaviour
{
    //Initialize Variables
    public int currentAge = 24;
    public int ageIncrease = 1;
    bool isFunny = true;
    string myName = "Mathias";
    string secondName = "Andersen";
    public int a = 512;
    public int b = 731;


    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("a={0}, b={1}", a, b);
        int c = b - a;
        a = a + c;
        b = b - c;
        Debug.LogFormat("a={0}, b={1}", a, b);

        int d0 = 10;
        int d1 = 20;

        (a,b) = Swap(a,b);
        Debug.LogFormat("a={0}, b={1}", a, b);
        
        (d0,d1) = Swap(d0,d1);
        Debug.LogFormat("d0={0}, d1={1}", d0, d1);

        (int m1, int m2) = Swap(1,7);
        Debug.LogFormat("1={0},7={1}", m1, m2);

        (float f1, float f2) = Swap(1.5f,7.3f);
        Debug.LogFormat("1.5={0},7.3={1}", f1, f2);
    }

    // Update is called once per frame
    void Update()
    {
        /*
         currentAge += ageIcrease;
         Debug.Log(currentAge);
        */
    }

    (int, int) Swap(int m, int n) // This function swaps the value of integer m and integer n.
    {
        int temp = m;
        m = n;
        n = temp;

        return (m, n);
    }

    (float, float) Swap(float m, float n) // This function swaps the value of integer m and integer n.
    {
        float temp = m;
        m = n;
        n = temp;

        return (m, n);
    }

}
