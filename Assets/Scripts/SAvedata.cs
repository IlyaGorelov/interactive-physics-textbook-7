using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SAvedata : MonoBehaviour
{

    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
    public TMP_InputField inputField3;
    public GameObject gameObj;
    public delenieCode code;
    public Galka galkaCode;
   
    private void Awake()
    {
       inputField1.text= PlayerPrefs.GetString(gameObj.name+"inputfield1");
        inputField2.text = PlayerPrefs.GetString(gameObj.name + "inputfield2");
        inputField3.text = PlayerPrefs.GetString(gameObj.name + "inputfield3");
       code.isAcive= PlayerPrefs.GetInt(gameObj.name + "delenie", code.isAcive);
        if (code.isAcive == 1)
        {
            code.delenObj.SetActive(true);

        }
        else
        {
            code.delenObj.SetActive(false);
        }
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            PlayerPrefs.DeleteAll();
            inputField1.text = null;
            inputField2.text = null;
            inputField3.text = null;
            code.isAcive = 0;
            galkaCode.isGalka = 0;
        }
    }
    // Update is called once per frame
    public void SaveStrings()
    {
        PlayerPrefs.SetString(gameObj.name+"inputfield1", inputField1.text);
        PlayerPrefs.SetString(gameObj.name + "inputfield2", inputField2.text);
        PlayerPrefs.SetString(gameObj.name + "inputfield3", inputField3.text);
        PlayerPrefs.SetInt(gameObj.name + "delenie", code.isAcive);
        
    }
}
