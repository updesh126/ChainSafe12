using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WalletAccount : MonoBehaviour
{
    public Text mycuenta;
    // Start is called before the first frame update
    void Start()
    {
        mycuenta.text = PlayerPrefs.GetString("Account");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
