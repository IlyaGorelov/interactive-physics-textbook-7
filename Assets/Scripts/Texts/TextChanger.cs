using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextChanger : MonoBehaviour
{
    public TextMeshProUGUI changetext;
    
    

    public void TextChange()
    {
        if (changetext.text == "����������� ��������")
        {
            changetext.text = "����������� �������� � ��� ��������, ��� ������� ���� ��������\r\n������ ���������� �� ��������� ������ ���������� �������.\r\n";
            Debug.Log("dxhdrh");
        }
        else
            changetext.text = "����������� ��������";
    }

    


}
