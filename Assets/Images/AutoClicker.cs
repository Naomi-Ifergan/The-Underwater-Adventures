
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    public bool Going = false;
    public bool Waiting = false;
    //mouse event constants
    const int MOUSEEVENTF_LEFTDOWN = 2;
    const int MOUSEEVENTF_LEFTUP = 4;
    //input type constant
    const int INPUT_MOUSE = 0;

    [DllImport("User32.dll", SetLastError = true)]
    public static extern int SendInput(int nInputs, ref INPUT pInputs, int cbSize);

    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            Going = !Going;
        }
        if (Going == true && Waiting == false)
        {
            Waiting = true;
            timer1_Tick();
        }
    }

    public struct MOUSEINPUT
    {
        public int dx;
        public int dy;
        public int mouseData;
        public int dwFlags;
        public int time;
        public IntPtr dwExtraInfo;
    }

    public struct INPUT
    {
        public uint type;
        public MOUSEINPUT mi;
    };

    private void timer1_Tick()
    {
        INPUT i = new INPUT();
        i.type = INPUT_MOUSE;
        i.mi.dx = 0;
        i.mi.dy = 0;
        i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
        i.mi.dwExtraInfo = IntPtr.Zero;
        i.mi.mouseData = 0;
        i.mi.time = 0;
        //send the input 
        SendInput(1, ref i, Marshal.SizeOf(i));
        //set the INPUT for mouse up and send it
        i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
        SendInput(1, ref i, Marshal.SizeOf(i));
        //yield return new WaitForSeconds(1f);
        Waiting = false;
    }
}