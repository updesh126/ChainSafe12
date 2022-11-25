using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


#if UNITY_WEBGL
public class WebGLSendTransactionExample : MonoBehaviour
{
    public Text hash;
    async public void OnSendTransaction()
    {
        // account to send to
        string to = "0x20d7b8A7664F723384Fa36c49D6E49aDa3Bb1660";
        // amount in wei to send
        string value = "2000000000000000";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // connects to user's browser wallet (metamask) to send a transaction
        try {
            string response = await Web3GL.SendTransaction(to, value, gasLimit, gasPrice);
            Debug.Log(response);
            hash.text = response;
        } catch (Exception e) {
            Debug.LogException(e, this);
        }
    }

    public void Update()
    {
        if (hash.text.Contains("0"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
#endif