using UnityEngine;
using System;

public class ClockScript : MonoBehaviour
{
    public Transform hourHand;   // Reference to the hour hand
    public Transform minuteHand; // Reference to the minute hand
    public Transform secondHand; // Reference to the second hand

    void Update()
    {
        DateTime currentTime = DateTime.Now;

        float hours = currentTime.Hour;
        float minutes = currentTime.Minute;
        float seconds = currentTime.Second;

        float hourAngle = hours * 30f + minutes * 0.5f; // 360 degrees / 12 hours = 30 degrees per hour, + 0.5 degree per minute
        float minuteAngle = minutes * 6f + seconds * 0.1f; // 360 degrees / 60 minutes = 6 degrees per minute, + 0.1 degree per second
        float secondAngle = seconds * 6f; // 360 degrees / 60 seconds = 6 degrees per second

        hourHand.localRotation = Quaternion.Euler(0f, 0f, -hourAngle);
        minuteHand.localRotation = Quaternion.Euler(0f, 0f, -minuteAngle);
        secondHand.localRotation = Quaternion.Euler(0f, 0f, -secondAngle);
    }
}
