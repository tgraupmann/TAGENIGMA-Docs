using System;
using System.Collections.Generic;
using UnityEngine;

public static class WordDetectionInput
{
    public static Dictionary<string, DateTime> TimerDetection = new Dictionary<string, DateTime>();

    public const string KEY_DOWN = "DOWN";
    public const string KEY_LEFT = "LEFT";
    public const string KEY_RIGHT = "RIGHT";
    public const string KEY_UP = "UP";
    public const string KEY_FORWARD = "AHEAD";
    public const string KEY_BACKWARD = "BACK";
    public const string KEY_JUMP = "JUMP";

    public static Vector3 mousePosition
    {
        get
        {
            return Input.mousePosition;
        }
    }

    public static float GetAxis(string axisName)
    {
        switch (axisName.ToUpper())
        {
            case "HORIZONTAL":
                if (TimerDetection.ContainsKey(KEY_LEFT) &&
                    TimerDetection.ContainsKey(KEY_RIGHT) &&
                    TimerDetection[KEY_LEFT] > DateTime.Now &&
                    TimerDetection[KEY_RIGHT] > DateTime.Now)
                {
                    if (TimerDetection[KEY_LEFT] < TimerDetection[KEY_RIGHT])
                    {
                        return 1f;
                    }
                    else
                    {
                        return -1f;
                    }
                    
                }
                else if (TimerDetection.ContainsKey(KEY_LEFT) &&
                    TimerDetection[KEY_LEFT] > DateTime.Now)
                {
                    return -1f;
                }
                else if (TimerDetection.ContainsKey(KEY_RIGHT) &&
                         TimerDetection[KEY_RIGHT] > DateTime.Now)
                {
                    return 1f;
                }
                else
                {
                    return Input.GetAxis(axisName);
                }
                break;
            case "VERTICAL":
                if (TimerDetection.ContainsKey(KEY_FORWARD) &&
                    TimerDetection.ContainsKey(KEY_BACKWARD) &&
                    TimerDetection[KEY_FORWARD] > DateTime.Now &&
                    TimerDetection[KEY_BACKWARD] > DateTime.Now)
                {
                    if (TimerDetection[KEY_FORWARD] < TimerDetection[KEY_BACKWARD])
                    {
                        return -1f;
                    }
                    else
                    {
                        return 1f;
                    }
                    
                }
                else if (TimerDetection.ContainsKey(KEY_FORWARD) &&
                    TimerDetection[KEY_FORWARD] > DateTime.Now)
                {
                    return 1f;
                }
                else if (TimerDetection.ContainsKey(KEY_BACKWARD) &&
                         TimerDetection[KEY_BACKWARD] > DateTime.Now)
                {
                    return -1f;
                }
                else
                {
                    return Input.GetAxis(axisName);
                }
                break;
            default:
                Debug.LogError(string.Format("Unknown Axis: {0}", axisName));
                return Input.GetAxis(axisName);
                break;
        }
    }

    public static float GetAxisRaw(string axisName)
    {
        return GetAxis(axisName);
    }

    public static bool GetButton(string buttonName)
    {
        //Debug.Log(buttonName);
        switch (buttonName.ToUpper())
        {
            case "JUMP":
                if (TimerDetection.ContainsKey(KEY_JUMP) &&
                    TimerDetection[KEY_JUMP] > DateTime.Now)
                {
                    return true;
                }
                else 
                {
                    return Input.GetButton(buttonName);
                }
            case "FIRE2":
                return Input.GetButton(buttonName);
            default:
                Debug.Log(string.Format("Unknown button: {0}", buttonName));
                return Input.GetButton(buttonName);
        }
    }

    public static bool GetButtonDown(string buttonName)
    {
        //Debug.Log(buttonName);
        switch (buttonName.ToUpper())
        {
            case "JUMP":
                if (TimerDetection.ContainsKey(KEY_JUMP) &&
                    TimerDetection[KEY_JUMP] > DateTime.Now)
                {
                    return true;
                }
                else
                {
                    return Input.GetButtonDown(buttonName);
                }
        }
        return Input.GetButtonDown(buttonName);
    }

    public static bool GetMouseButton(int button)
    {
        //Debug.Log(button);
        return Input.GetMouseButton(button);
    }

    public static bool GetMouseButtonDown(int button)
    {
        //Debug.Log(button);
        return Input.GetMouseButtonDown(button);
    }

    public static bool GetKey(KeyCode key)
    {
        //Debug.Log(key);
        return Input.GetKey(key);
    }

    public static bool GetKey(String key)
    {
        //Debug.Log(key);
        return Input.GetKey(key);
    }

    public static void ResetInputAxes()
    {
        TimerDetection.Clear();
        Input.ResetInputAxes();
    }
}