using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text PlayerNameText;
    public Text SizeText;
    

    private void Update()
    {
        {
           PlayerNameText.text = "Name: " +  KeepData.PlayerName;
           SizeText.text = "Size " + KeepData.Size.ToString();

        }
    }

}
