using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Zadacha1 : MonoBehaviour
{
    public TextMeshProUGUI changetext;
    

    

    public void TextChange()
    {
        if (changetext.text == "������ 1")
        {
            changetext.text = "�����, �������� ����������, �� ��� ���� �������� ����, ������ 108 ��. ��������� �������� �������� ������. (�������� � �������� ��)";
            
        }
        else
        {
            changetext.text = "������ 1";
            
        }
        
    }

    


}
