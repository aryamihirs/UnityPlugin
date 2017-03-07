
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class cimg_img : MonoBehaviour
{
    [DllImport("ConsoleApplication13", EntryPoint = "img")]
    public static extern void img();
    // Use this for initialization
    void Start()
    {
        img();
    }
}
