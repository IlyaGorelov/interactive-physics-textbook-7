using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextChangerRoom5 : MonoBehaviour
{
    public GameObject dano1;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public void Dano1()
    {

        switch (text1.text)
        {
            case "������ 1":
                text1.text = "������ 1+";
                text2.text = "����� ������ �������� ���������, ���������� ������ ���� ������ 30 �� �� ������ 0,5 �? ";
                dano1.SetActive(true);
                break;
            case "������ 1+":
                text1.text = "������ 1";
                dano1.SetActive(false);
                break;

            case "������ 2":
                text1.text = "������ 2+";
                text2.text = "���������� ������ ������, ������� ���������� �� ��������������� ���� ��� ������ 0,2� �� ���������� 0,5 ��. ����������� ������ ����� 0,02.  ";
                dano1.SetActive(true);
                break;
            case "������ 2+":
                text1.text = "������ 2";
                dano1.SetActive(false);
                break;

            case "������ 3":
                text1.text = "������ 3+";
                text2.text = "����� ���� ������� 12 � ������� �����, �������� \r\n������ 600 ��. �� ����� ������ ������� �����? \r\n";
                dano1.SetActive(true);
                break;
            case "������ 3+":
                text1.text = "������ 3";
                dano1.SetActive(false);
                break;

            case "������ 4":
                text1.text = "������ 4+";
                text2.text = "����� ������ ��������� ��������� ��������� ��������� 200 ��� �� 30 ���? �������� � ��� ";
                dano1.SetActive(true);
                break;
            case "������ 4+":
                text1.text = "������ 4";
                dano1.SetActive(false);
                break;

            case "������ 5":
                text1.text = "������ 5+";
                text2.text = "���� ������ � ������� ����������� ������������������� � ������ 37,5 �. ������ ���� � ������� 200 �3/�. ������ �������� �������? �������� � ���";
                dano1.SetActive(true);
                break;
            case "������ 5+":
                text1.text = "������ 5";
                dano1.SetActive(false);
                break;

            case "������ 6":
                text1.text = "������ 6+";
                text2.text = "������� ����, ����������� �� �����, ����� 5�. ������� ������� ����, ���� ����� ������ 0,1 � � 0,3�.  ";
                dano1.SetActive(true);
                break;
            case "������ 6+":
                text1.text = "������ 6";
                dano1.SetActive(false);
                break;

            case "������ 7":
                text1.text = "������ 7+";
                text2.text = "����� ����������� ����� �������� 14,7 ���. �� ��� ���������� ������ 500 � ����� �� ������ 2 �. ����� ����������� ��������� �������� �����������? �������� � ��������� ";
                dano1.SetActive(true);
                break;
            case "������ 7+":
                text1.text = "������ 7";
                dano1.SetActive(false);
                break;

            case "������ 8":
                text1.text = "������ 8+";
                text2.text = "����� ������������� �������� ������������ ����� �������� ������� ������ 80 �� �� ������ 20 �? ";
                dano1.SetActive(true);
                break;
            case "������ 8+":
                text1.text = "������ 8";
                dano1.SetActive(false);
                break;

            case "������ 9":
                text1.text = "������ 9+";
                text2.text = "����������������� ������� ����������� ��������� �� 10 ��, � �� ������������� ������� ����� 0,4 ��. ����� ����������� ��������� �������? ";
                dano1.SetActive(true);
                break;
            case "������ 9+":
                text1.text = "������ 9";
                dano1.SetActive(false);
                break;

            case "������ 10":
                text1.text = "������ 10+";
                text2.text = "����� ��������� 20 �. �� ����� ����� ����, ������������ � ������ ���������, ������ � ��� �����, ���� �������� �������� ��������� 10 ��/�? ";
                dano1.SetActive(true);
                break;
            case "������ 10+":
                text1.text = "������ 10";
                dano1.SetActive(false);
                break;
        }
    }
}
