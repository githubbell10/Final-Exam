using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public static string PlayerName = "Default Name";
    public static float Size = 1.0f;
    public static int SpeedOption;
    public static float TimeOption;
    public InputField playerName;
    public Dropdown Speed;
    public Dropdown time;
    public Slider SizeBar;
    

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName()    //updates on input change for input field
    {
        PlayerName = playerName.text;
    }

    public void SizeAdjuster()
    {
        Size *= SizeBar.value;
    }

    public void setSpeed()
    {
        switch (Speed.value)
        {
            case 1:
                SpeedOption = 1;
                break;
            
            case 2:
                SpeedOption = 10;
                break;
            
            default:
                SpeedOption = 1;
                break;
        }
    }

    public void setTime()
    {
        switch (time.value)
        {
            case 1:
                TimeOption = 10f;
                break;
            case 2:
                TimeOption = 20f;
                break;
            case 3:
                TimeOption = 40f;
                break;

            default:
                TimeOption = 10f;
                break;
        }
    }

}