using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class ShowPersent : MonoBehaviour
{
    public float RoomOnePercent;
    public float RoomTwoPercent;
    public float RoomThreePercent;
    public float RoomFourPercent;
    public float RoomFivePercent;
    public TextMeshProUGUI PercentOne;
    public TextMeshProUGUI PercentTwo;
    public TextMeshProUGUI PercentThree;
    public TextMeshProUGUI PercentFour;
    public TextMeshProUGUI PercentFive;

    // Update is called once per frame
    void Start()
    {
      RoomOnePercent= PlayerPrefs.GetFloat("RoomOnePersent");
       double RoomOnePercentDouble = (double)RoomOnePercent;
        RoomOnePercentDouble = RoomOnePercentDouble*10;
        PercentOne.text =  RoomOnePercentDouble+ " %";
        if(RoomOnePercentDouble==100)
            PercentOne.color=Color.green;

        RoomTwoPercent = PlayerPrefs.GetFloat("RoomTwoPersent");
        double RoomTwoPercentDouble = (double)RoomTwoPercent;
        RoomTwoPercentDouble = RoomTwoPercentDouble/6*100;
        PercentTwo.text = Math.Round(RoomTwoPercentDouble,0) + " %";
        if (RoomTwoPercentDouble == 100)
            PercentTwo.color = Color.green;

        RoomThreePercent = PlayerPrefs.GetFloat("RoomThreePersent");
        double RoomThreePercentDouble = (double)RoomThreePercent;
        RoomThreePercentDouble = RoomThreePercentDouble / 5 * 100;
        PercentThree.text = Math.Round(RoomThreePercentDouble, 0) + " %";
        if (RoomThreePercentDouble == 100)
            PercentThree.color = Color.green;

        RoomFourPercent = PlayerPrefs.GetFloat("RoomFourPersent");
        double RoomFourPercentDouble = (double)RoomFourPercent;
        RoomFourPercentDouble = RoomFourPercentDouble / 9 * 100;
        PercentFour.text = Math.Round(RoomFourPercentDouble, 0) + " %";
        if (RoomFourPercentDouble == 100)
            PercentFour.color = Color.green;

        RoomFivePercent = PlayerPrefs.GetFloat("RoomFivePersent");
        double RoomFivePercentDouble = (double)RoomFivePercent;
        RoomFivePercentDouble = RoomFivePercentDouble / 9 * 100;
        PercentFive.text = Math.Round(RoomFivePercentDouble, 0) + " %";
        if (RoomFivePercentDouble == 100)
            PercentFive.color = Color.green;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1)) 
        {
            PlayerPrefs.DeleteAll();
            RoomOnePercent = 0;
            RoomTwoPercent = 0;
            RoomThreePercent = 0;
            RoomFourPercent = 0;
            RoomFivePercent = 0;
        }

    }

}
