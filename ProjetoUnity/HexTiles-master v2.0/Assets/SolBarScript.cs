using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolBarScript : MonoBehaviour
{
    private Image SunBar;
    public float CurrentSun;
    private float MaxSun = 86400;

    DayNightCycle Cycle;

    // Start is called before the first frame update
    void Start()
    {
        SunBar = GetComponent<Image>();
        Cycle = FindObjectOfType<DayNightCycle>();
        
    }



    // Update is called once per frame
    void Update()
    {
        CurrentSun = Cycle.time;
        SunBar.fillAmount = CurrentSun / MaxSun;

    }
}
