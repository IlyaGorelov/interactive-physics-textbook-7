using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Velocity : MonoBehaviour
{
    public TextMeshProUGUI changetext;
    public GameObject GameObject;

    

    public void TextChange()
    {
        if (changetext.text == "��������")
        {
            changetext.text = "�������� ��� ����������� �������� ���� ����������, ����� ���� ��� ������ � ������� �������.\n �������� � ���������� �������� �������� ����������. (    ) ";
            GameObject.SetActive(true);
        }
        else
        {
            changetext.text = "��������";
            GameObject.SetActive(false);
        }
    }

    


}
