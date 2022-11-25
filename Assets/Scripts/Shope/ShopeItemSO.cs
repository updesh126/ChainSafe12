using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="shopMenu",menuName ="Scriptable Objects/New shop Item", order=1)]
public class ShopeItemSO : ScriptableObject
{
    public string title;
    public Sprite img;
    public int baseCost;
}
