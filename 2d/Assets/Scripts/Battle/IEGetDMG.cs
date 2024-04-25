using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEGetDMG 
{
    public delegate void ShowDMGTextEvent();


    public void getDMG(float DMG);
    
}
