using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextChanger1 : MonoBehaviour
{
    public TextMeshProUGUI changetext;

    public GameObject Dano;

    public void TextChange()
    {
        if (changetext.text == "������ 1")
        {
            changetext.text = "";
            Dano.SetActive(true);
        }
        else
        {
            changetext.text = "������ 1";
            Dano.SetActive(false);
        }
    }

    


}
