using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Slider timeSlider;
    [SerializeField] TMP_Text timeText;

    void Start()
    {
        timeSlider.onValueChanged.AddListener((value) =>
        {
            Time.timeScale = value;
            timeText.text = $"cur Time Scale = {value}";
        });
        timeText.text = $"cur Time Scale = {Time.timeScale}";
        timeSlider.value = Time.timeScale;
    }
}
