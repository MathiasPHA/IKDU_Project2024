using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeChanger : MonoBehaviour
{
    //Initializing variables
    public int currentAge = 24;
    public int addYears = 5;


    // Start is called before the first frame update
    void Start()
    {
        //calling the function, calculating my age in 1 year.
        futureAge(currentAge);
        //displaying the results for the fuction in the console
        Debug.LogFormat("My age next year is {0}", futureAge(currentAge));

        //calling the function, calculating my age in n (addYears) years, n being 5. 
        futureAge(currentAge, addYears);
        //displaying the results for the fuction in the console
        Debug.LogFormat("My age in {0} years is {1}", addYears, futureAge(currentAge, addYears));
    }

    //a function, returning my current age + 1.
    int futureAge(int n) 
    {
        return (currentAge + 1);
    }

    //a function returning my current age + n (addYears).
    int futureAge(int n, int m)
    {
        return (currentAge + addYears);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
