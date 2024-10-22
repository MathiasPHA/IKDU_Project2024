using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeeklyPlanner : MonoBehaviour
{
    public string dayOfTheWeek = "Monday";
    int listDay = 0;
    // Start is called before the first frame update
    void Start()
    {
        //prints the instructions for the day, from my switch statement and my list
        printDayOfTheWeek();

        Debug.LogFormat("Today is {0}", days[listDay]);
    }

    //switch statment with instructuons for each weekday as a case
    public void printDayOfTheWeek() 
    {
        switch (dayOfTheWeek) 
        {
            case "Monday":
                Debug.Log("Monday: Get out of bed and go to school");
                listDay = 0;
                break;

            case "Tuesday":
                Debug.Log("Go to school and learn some C#");
                listDay = 1;
                break;

            case "Wednesday":
                Debug.Log("IT IS WEDNESDAY MY DUDES!");
                listDay = 2;
                break;

            case "Thursday":
                Debug.Log("Learn more C#");
                listDay = 3;
                break;

            case "Friday":
                Debug.Log("DRINK BEER");
                listDay = 4;
                break;

            case "Saturday":
                Debug.Log("Sleep");
                listDay = 5;
                break;

            case "Sunday":
                Debug.Log("Sleep more");
                listDay = 6;
                break;

        }  
    }

    //list of instructions for each weekday
    List<string> days = new List<string>()
    {
        "Monday: Get out of bed and go to school",
        "Tuesday: Go to school and learn some C#",
        "Wednesday: IT IS WEDNESDAY MY DUDES!",
        "Thursday: Learn more C#",
        "Friday: DRINK BEER",
        "Saturday: Sleep",
        "Sunday: Sleep more"
    };

    // Update is called once per frame
    void Update()
    {
        
    }
}
