using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Zadacha2 : MonoBehaviour
{
    public TextMeshProUGUI changetext;
    

    

    public void TextChange()
    {
        if (changetext.text == "�������")
        {
            changetext.text = "������� ���������� �������� ���� ��� ���������� �������� �� ����";

        }
        else
        {
            changetext.text = "�������";

        }

    }

    


}
