using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool IsChecked;
    public int MyIntValue = 10;
    // Use this for initialization
    void Start()
    {
        if (IsChecked == true)
        {
            Debug.Log("It's True");
        }
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    // == lika med
    // >= större än eller lika med
    // <= mindre än eller lika med
    // > större än
    // < mindre än
    // && och
    // || ELLER (altgr + större/mindre tecken)
    {
        if (MyIntValue >= 10 || IsChecked == true)
        {
            print("Måndag");
        }
        else if (MyIntValue == 9)

        {
            print("Okänd dag");
        }

        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            print("Reload");
        }
        if (Input.GetKeyDown(KeyCode.Q) == true)
            // Random.Range(10) = 0 1 2 3 4 5 6 7 8 9
            MyIntValue = Random.Range(0, 11);
            print(Random.Range(0, 11));
            print("Lean left");
    }
}
