using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdStatus : MonoBehaviour
{
    public static BirdStatus SharedInstance;

    public static bool isAlive = true;
    void Awake()
    {
        SharedInstance = this;
    }

}
