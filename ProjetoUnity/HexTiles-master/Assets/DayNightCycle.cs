
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DayNightCycle : MonoBehaviour
{
    public float time;
    public TimeSpan currentime;
    public Transform SunTransform;
    public Light Sun;
    public Text timetext;
    public int days;

    public float intensity;
    public Color fogday = Color.gray;
    public Color fognight = Color.black;

    public int speed;



    // Update is called once per frame
    void Update()
    {

        ChangeTime();
    }

    public void ChangeTime()
    {
        time += Time.deltaTime * speed;
        if (time > 86400)
        {
            days += 1;
            time = 0;
        }

        currentime = TimeSpan.FromSeconds(time);
        string[] tempTime = currentime.ToString().Split(":"[0]);
        timetext.text = tempTime[0] + ":" + tempTime[1];

        SunTransform.rotation = Quaternion.Euler(new Vector3((time - 21600) / 86400 * 360, 0, 0));
        if (time < 43200)
        {
            intensity = 1 - (43200 - time) / 43200;
        }else
        {
            intensity = 1 - (43200 - time) / 43200 * -1;
        }

        RenderSettings.fogColor = Color.Lerp (fognight,fogday, intensity * intensity);

        Sun.intensity = intensity;

    }
}
