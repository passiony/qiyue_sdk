using System.Runtime.InteropServices;
using UnityEngine;

public class NativeIOS : NativeBase
{
    //type表示功能分类(login,pay等),
    //jsonpara为以json字串表示的一系列参数
    //调用ios_sdk全部通过该接口,具体实现全部通过通用SDK层去和各平台的SDK进行交互
#if UNITY_IOS
    [DllImport("__Internal")]
    private static extern void CallSDKFunc(string type, string param);

    //点击输入框调用？
    [DllImport("__Internal")]
    private static extern void ActiveInitializeIosUI();

    //退出程序
    [DllImport("__Internal")]
    private static extern void ExitApplication();


    //以下为sdk以外的通用接口
    [DllImport("__Internal")]
    private static extern string OcCallString(string funcName);

    [DllImport("__Internal")]
    private static extern string OcCallStringWithParam(string funcName, string param);

    [DllImport("__Internal")]
    private static extern void OcCallVoid(string funcName);

    [DllImport("__Internal")]
    private static extern void OcCallVoidWithParam(string funcName, string param);

    [DllImport("__Internal")]
    private static extern int OcCallInt(string funcName);

    [DllImport("__Internal")]
    private static extern int OcCallIntWithParam(string funcName, string param);

    [DllImport("__Internal")]
    private static extern bool OcCallBool(string funcName);

    [DllImport("__Internal")]
    private static extern bool OcCallBoolWithParam(string funcName, string param);

    public void OcCallSDKFunc(string type, string jsonpara)
    {
        CallSDKFunc(type, jsonpara);
    }

    public void IosCallUIActiveInit()
    {
        ActiveInitializeIosUI();
    }

    public void IosCallExitApp()
    {
        ExitApplication();
    }


    public void InitSdk()
    {
        OcCallSDKFunc("initSDK", "");
    }

    public void CallVoid(string func_name)
    {
        OcCallVoid(func_name);
    }

    public void CallVoid(string func_name, string param)
    {
        OcCallVoidWithParam(func_name, param);
    }

    public string CallString(string func_name)
    {
        return OcCallString(func_name);
    }

    public string CallString(string func_name, string param)
    {
        return OcCallStringWithParam(func_name, param);
    }

    public int CallInt(string func_name)
    {
        return OcCallInt(func_name);
    }

    public int CallInt(string func_name, string param)
    {
        return OcCallIntWithParam(func_name, param);
    }


    public bool CallBool(string func_name)
    {
        return OcCallBool(func_name);
    }

    public bool CallBool(string func_name, string param)
    {
        return OcCallBoolWithParam(func_name, param);
        return false;
    }

    public bool isIOSCN()
    {
        string channelID = CallString("GetChanelID");
        return channelID.Equals("tw1001");
    }
#endif
}