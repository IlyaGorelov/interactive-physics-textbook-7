using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger3 : MonoBehaviour
{
    public TextMeshProUGUI changetext;
    
    public void TextChange()
    {
        switch (changetext.text)
        {
            case "������ 1":

                changetext.text = "�������, �������� ������ ������� �� ��������� 14 ��/�, �������� ���������� ����� ����� ���������� �� 4 ����. �� ����� ����� �� ������� �� �� ���������� �� �������, ���� �������� �������� � ���� ������ ����� 5,6 �/�?";
                break;
            case "�������, �������� ������ ������� �� ��������� 14 ��/�, �������� ���������� ����� ����� ���������� �� 4 ����. �� ����� ����� �� ������� �� �� ���������� �� �������, ���� �������� �������� � ���� ������ ����� 5,6 �/�?":

                changetext.text = "������ 1";
                break;

            case "������ 2":

                changetext.text = "� ��������� ������� ��� ������ ������ (�������, ����������� ���������� ���������) ��������� ������, ��������� � ��������� ��������� ���� (��������� ����). ����� ����� ���� ���� �����, ����� ������, ����� ���� ��� �� ������, �������� �� ���������� 150 �, ���� �������� ���� 5 �/�, � �������� ��������������� ������� �� ����� 0,8 ��/�?";
                break;
            case "� ��������� ������� ��� ������ ������ (�������, ����������� ���������� ���������) ��������� ������, ��������� � ��������� ��������� ���� (��������� ����). ����� ����� ���� ���� �����, ����� ������, ����� ���� ��� �� ������, �������� �� ���������� 150 �, ���� �������� ���� 5 �/�, � �������� ��������������� ������� �� ����� 0,8 ��/�?":

                changetext.text = "������ 2";
                break;


        }
        

    }




}