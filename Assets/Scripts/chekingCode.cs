using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chekingCode : MonoBehaviour
{
    public int i = 0;
    public int q = 0;
    public TMP_InputField otvet;
    public TextMeshProUGUI result;
    public TMP_InputField inputfield1;
    public TMP_InputField inputfield2;
    public TMP_InputField inputfield3;
    public double minA;
    public double maxA;
    public string inputField1;
    public string inputField2;
    public string inputField3;
    public ShowPersent room1;
    bool isActive = true;
   
    
    public void Changer()
    {
        result.text = "";

        
        double a = double.Parse(otvet.text);
        if (a >= minA && a <= maxA && inputfield1.text == inputField1 && inputfield2.text == inputField2 && inputfield3.text == inputField3)
        {

            result.text = "Ответ правильный";

        }
        else
        {

            result.text = "Ответ неправильный";


        }
        if (i != 0)
        {
            i--;
            result.text += "\nУберите / из решения";
        }
        else if (q != 0)
        {
            q--;
            result.text += "\nУпростите решение. Уберите / из дробей";
        }
        else if (q == 0 && i == 0)
        {
            result.text = result.text;
        }

    }
    public void Plus1FromRoom()
    {
       
        if (result.text == "Ответ правильный" && isActive&&SceneManager.GetActiveScene().buildIndex == 7)
        {
            room1.RoomOnePercent++;
            isActive = false;
            PlayerPrefs.SetFloat("RoomOnePersent", room1.RoomOnePercent);
        }
        if (result.text == "Ответ правильный" && isActive&&SceneManager.GetActiveScene().buildIndex == 8)
        {
            room1.RoomTwoPercent++;
            isActive = false;
            PlayerPrefs.SetFloat("RoomTwoPersent", room1.RoomTwoPercent);
        }
        if (result.text == "Ответ правильный" && isActive && SceneManager.GetActiveScene().buildIndex == 9)
        {
            room1.RoomThreePercent++;
            isActive = false;
            PlayerPrefs.SetFloat("RoomThreePersent", room1.RoomThreePercent);
        }
        if (result.text == "Ответ правильный" && isActive && SceneManager.GetActiveScene().buildIndex == 10)
        {
            room1.RoomFourPercent++;
            isActive = false;
            PlayerPrefs.SetFloat("RoomFourPersent", room1.RoomFourPercent);
        }
        if (result.text == "Ответ правильный" && isActive && SceneManager.GetActiveScene().buildIndex == 11)
        {
            room1.RoomFivePercent++;
            isActive = false;
            PlayerPrefs.SetFloat("RoomFivePersent", room1.RoomFivePercent);
        }


    }


}
