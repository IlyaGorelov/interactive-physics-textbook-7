using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Zadachi : MonoBehaviour
{

    public TextMeshProUGUI changetext;
    public GameObject dano;
    
    public void TextChange()
    {
        switch (changetext.text)
        {
            case "������":

                changetext.text = "";
                dano.SetActive(true);
                
                break;
            case "":

                changetext.text = "������";
                dano.SetActive(false);
                
                break;

            case "������1":

                changetext.text = "������1+";
                dano.SetActive(true);
                

                break;
            case "������1+":

                changetext.text = "������1";
                dano.SetActive(false);
                break;

            case "������2. �������� � ��������":

                changetext.text = "������2. �������� � ��������+";
                dano.SetActive(true);
                break;
            case "������2. �������� � ��������+":

                changetext.text = "������2. �������� � ��������";
                dano.SetActive(false);
                break;

            case "������3. A��������� ����":

                changetext.text = "������3. A��������� ����+";
                dano.SetActive(true);
                break;
            case "������3. A��������� ����+":

                changetext.text = "������3. A��������� ����";
                dano.SetActive(false);
                break;

            case "������ 6":
                changetext.text = "������ 6+";
                dano.SetActive(true);
                break;
            case "������ 6+":
                changetext.text = "������ 6";
                dano.SetActive(false);
                break;

            case "������ 7":
                changetext.text = "������ 7+";
                dano.SetActive(true);
                break;
            case "������ 7+":
                changetext.text = "������ 7";
                dano.SetActive(false);
                break;

            case "������ 8":
                changetext.text = "������ 8+";
                dano.SetActive(true);
                break;
            case "������ 8+":
                changetext.text = "������ 8";
                dano.SetActive(false);
                break;
        }
    }
}
