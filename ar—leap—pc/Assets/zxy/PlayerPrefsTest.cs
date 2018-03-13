using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsTest : MonoBehaviour
{

    InputField inputText;
    Text placeHolder;

    void Start()
    {
        GetNecessaryComponents();
        //placeHolder.text = LoadLastAccount();
        inputText.text = LoadLastAccount();
    }

    void GetNecessaryComponents()
    {
        inputText = GetComponent<InputField>();
        placeHolder = transform.Find("Text").GetComponent<Text>();
        Debug.Log("获取组件完成"+ inputText.name+"-"+ placeHolder.name);
    }

    /// <summary>
    /// 持久化保存保存用户账号信息
    /// </summary>
    public void AfterTyping()
    {
        PlayerPrefs.SetString("Account", inputText.text);
        Debug.Log("保存用户账号信息"+ inputText.text);
        Debug.Log("保存用户账号信息" + PlayerPrefs.GetString("Account", "请输入账号"));
    }

    string LoadLastAccount()
    {
        string lastIP = PlayerPrefs.GetString("Account", "请输入账号");
        Debug.Log("加载保存用户账号的信息" + PlayerPrefs.GetString("Account", "请输入账号"));
        Debug.Log("加载保存用户账号的信息"+ lastIP);
        return lastIP;
    }
}
