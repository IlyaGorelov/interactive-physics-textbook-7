using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextChangerRoom2 : MonoBehaviour
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
                text2.text = "��� ������ �� ������, ���� � ������ ����� ���������� �������. ����� �� ��� ����� �������? ��������� ������ - 7874 ��/�^3, ���� - 8940 ��/�^3, ������ - 11340 ��/�^3";
                dano1.SetActive(true);
                break;
            case "������ 1+":
                text1.text = "������ 1";
                dano1.SetActive(false);
                break;

            case "������ 2":
                text1.text = "������ 2+";
                text2.text = "�������� ������� 125 � ����� ����� 100 ��. ���������� �� ���������. (1 �^3 = 1000 �)";
                dano1.SetActive(true);
                break;
            case "������ 2+":
                text1.text = "������ 2";
                dano1.SetActive(false);
                break;

            case "������ 3":
                text1.text = "������ 3+";
                text2.text = "������ ����� �������� 30 �� � 10 �� � 10 �� ����� ����� 21,9 ��. ������ ��������� �����? ";
                dano1.SetActive(true);
                break;
            case "������ 3+":
                text1.text = "������ 3";
                dano1.SetActive(false);
                break;

            case "������ 4":
                text1.text = "������ 4+";
                text2.text = "����� ������ ��� � ������ ����� � = 6 �� ����� ����� m = 810 �. ������ ������� ������ ����? ��������� ���� - 8940 ��/�. �������� � ��";
                dano1.SetActive(true);
                break;
            case "������ 4+":
                text1.text = "������ 4";
                dano1.SetActive(false);
                break;

            case "������ 5*":
                text1.text = "������ 5+";
                text2.text = "����� �������� � ����� ���������� 50 �. ����� ���� �� ��������, ����������� �����, �� � ������ ������� � ��� ������ 12 � ���������� 60,5 �. ���������� ��������� �������, ����������� � ��������.";
                dano1.SetActive(true);
                break;
            case "������ 5+":
                text1.text = "������ 5*";
                dano1.SetActive(false);
                break;

            case "������ 6":
                text1.text = "������ 6+";
                text2.text = "������� ������ ������ ������� �������� ����������������� 5 �, ����� ��������� 100 �3 �������? ��������� ������� 2600 ��/�3.";
                dano1.SetActive(true);
                break;
            case "������ 6+":
                text1.text = "������ 6";
                dano1.SetActive(false);
                break;

            case "������ 7":
                text1.text = "������ 7+";
                text2.text = "� ������� ���� ����� ����� �������� �� ��������� 110 ��/�, ����� ������ ��������� �� 10 ���. ���������� ����� ���� �� ��� �� ��������� 90 ��/�. ������ ������� �������� ������ �� ���� ����, ���� �� ������ 400 ��?(��������� �� ����� � �/�) ";
                dano1.SetActive(true);
                break;
            case "������ 7+":
                text1.text = "������ 7";
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
