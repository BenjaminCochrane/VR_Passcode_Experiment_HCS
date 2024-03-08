using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PasscodeVisuliser : MonoBehaviour
{
    public TextMeshPro passcodeText;
    string currentNum;

    public void pressOne()
    {
        currentNum = currentNum + "1";
        passcodeText.text = currentNum;
    }

    public void pressTwo()
    {
        currentNum = currentNum + "2";
        passcodeText.text = currentNum;
    }

    public void pressThree()
    {
        currentNum = currentNum + "3";
        passcodeText.text = currentNum;
    }

    public void pressFour()
    {
        currentNum = currentNum + "4";
        passcodeText.text = currentNum;
    }

    public void pressFive()
    {
        currentNum = currentNum + "5";
        passcodeText.text = currentNum;
    }

    public void pressSix()
    {
        currentNum = currentNum + "6";
        passcodeText.text = currentNum;
    }

    public void pressSeven()
    {
        currentNum = currentNum + "7";
        passcodeText.text = currentNum;
    }

    public void pressEight()
    {
        currentNum = currentNum + "8";
        passcodeText.text = currentNum;
    }

    public void pressNine()
    {
        currentNum = currentNum + "9";
        passcodeText.text = currentNum;
    }

    public void pressZero()
    {
        currentNum = currentNum + "0";
        passcodeText.text = currentNum;
    }

    public void pressClear()
    {
        currentNum = "";
        passcodeText.text = "_";
    }

    public void pressEnter()
    {
        switch(currentNum){
            case "0000":
                currentNum = "";
                passcodeText.text = "Correct Code!";
                break;
            default:
                currentNum = "";
                passcodeText.text = "Wrong Code!";
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
