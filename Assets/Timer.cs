using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Text TimeLeft;
    float TimeSelection=30f;
    float timer;
    private void Start()
    {
       
       TimeSelection = KeepData.TimeOption;

        TimeLeft.text = TimeSelection.ToString();
        timer = Time.deltaTime;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            TimeSelection--;
            TimeLeft.text = TimeSelection.ToString();
            timer = Time.deltaTime;
        }
    }
}
