using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenUI : MonoBehaviour
{
    [ContextMenu("Set Data To Google")]
    void SetDataToGoogle()
    {
        var weaponData = new Dictionary<string, object>();
        weaponData["LongSword"] = 100;
        weaponData["ShortSword"] = 50;
        FirestoreData.SaveToCloud("ItemData/Weapon", weaponData);
    }
    [ContextMenu("Load Data From Google")]
    void LoadDataFromGoogle()
    {
        FirestoreData.LoadFromCloud("ItemData/Weapon", LoadDataFromGoogleCallBack);
    }
    void LoadDataFromGoogleCallBack(IDictionary<string, object> dic)
    {
        foreach (var kv in dic)
        {
            print($"{kv.Key} : {kv.Value}");
        }
    }
}
