using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextChangerRoom3 : MonoBehaviour
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
                text2.text = "����� ������� 5 ��^3 ��������� �����. ����� ��� ����� ����? ";
                dano1.SetActive(true);
                break;
            case "������ 1+":
                text1.text = "������ 1";
                dano1.SetActive(false);
                break;

            case "������ 2":
                text1.text = "������ 2+";
                text2.text = "��� ��������� ����� � 200 � ������� ����������� ���������� �� 0,5 ��. ������ ��������� ������� ��� ��������� ����� � 700 �? �������� � �� ";
                dano1.SetActive(true);
                break;
            case "������ 2+":
                text1.text = "������ 2";
                dano1.SetActive(false);
                break;

            

            case "������ 3":
                text1.text = "������ 3+";
                text2.text = "���������� ����� ��� ���� ���������� �����, ����� ������� �� ������� ����� 125 �. ";
                dano1.SetActive(true);
                break;
            case "������ 3+":
                text1.text = "������ 3";
                dano1.SetActive(false);
                break;

            case "������ 4":
                text1.text = "������ 4+";
                text2.text = "��������� ��������� ���� ����, ����������� �� �����, ������� ����� ��� ���������. ���� ��������� ���� ���� 80��, ������ � 85 ��. ";
                dano1.SetActive(true);
                break;
            case "������ 4+":
                text1.text = "������ 4";
                dano1.SetActive(false);
                break;

            case "������ 5":
                text1.text = "������ 5+";
                text2.text = "������� ���������������� ������� ���, ���� ��������, ��� F1 =150 � � F2 = 770 � ���������� � ���� �������, � F3 =880� � F4 = 1200 � � �� ��� �� ������, �� � ��������������� �������. ";
                dano1.SetActive(true);
                break;
            case "������ 5+":
                text1.text = "������ 5";
                dano1.SetActive(false);
                break;

            case "������ 6":
                text1.text = "������ 6+";
                text2.text = "���� ����� ��������� ����� �������, ��������� �� ���� ��������������� ����������� ������, ��������� ������� 52000�/� � 13000�/�, ���� � ������� ����� ���� ������� �������� ����������� ��� ������� 16 �, � ������� �� ����� ��������� � �������?";
                dano1.SetActive(true);
                break;
            case "������ 6+":
                text1.text = "������ 6";
                dano1.SetActive(false);
                break;

            case "������ 8":
                text1.text = "������ 8+";
                text2.text = "���������� ����� ����� ���������� 144 ��. ������� ������� ����������� �������� ��� ���������� ����� ����� ���������� ���� � �������, ���� �������� �������� � ������� ���� 18 ��/�, � �������� ������� 3�/�? ";
                dano1.SetActive(true);
                break;
            case "������ 8+":
                text1.text = "������ 8";
                dano1.SetActive(false);
                break;

            case "������ 9":
                text1.text = "������ 9+";
                text2.text = "�������, ������� �� ��������� 300 ��/�, � ������������ ������ �������� ���������� ����� ����������� � � � �� 2,2 �. �������� ����� ��-�� ���������� ����� �� �������� �� 2,4 �. ���������� �������� �����.(�������� � ��/�) ";
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
