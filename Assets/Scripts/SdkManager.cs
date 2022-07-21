using UnityEngine;

public class SdkManager : MonoBehaviour
{
    private static SdkManager instance = null;

    public static SdkManager Instance
    {
        get { return instance; }
    }

    private NativeBase native = null;
    public int platform = 1;
    private bool isInitedSDK = false;

    private void Awake()
    {
        instance = this;
#if UNITY_ANDROID && !UNITY_EDITOR
        platform = 2;
        native = new NativeAndroid();
#elif UNITY_IOS && !UNITY_EDITOR || EDITOR_OSX
        platform = 3;
        native = new NativeIOS();
#else
        platform = 1;
        native = new NativeBase();
#endif

        InitSdk();
    }

    public bool IsInitedSDK
    {
        get { return isInitedSDK; }
    }

    public static void OcCallSDKFunc(string type, string jsonpara)
    {
        var native = Instance.native;
        native.OcCallSDKFunc(type, jsonpara);
    }

    public static void IosCallUIActiveInit()
    {
        var native = Instance.native;
        native.IosCallUIActiveInit();
    }

    public static void IosCallExitApp()
    {
        var native = Instance.native;
        native.IosCallExitApp();
    }

    public void InitSdk()
    {
        native.InitSdk();
        isInitedSDK = true;
    }

    public void JavaToUnity(string param)
    {
        CallLua(param);
    }

    public void OcToUnity(string param)
    {
        CallLua(param);
    }

    private void CallLua(string param)
    {
        Debug.Log("CallLua" + param);
//            Util.CallMethod("SDKManager", "CallBack", param);
    }

    public void CallVoid(string func_name)
    {
        native.CallVoid(func_name);
    }

    public void CallVoid(string func_name, string param)
    {
        native.CallVoid(func_name, param);
    }

    public string CallString(string func_name)
    {
        return native.CallString(func_name);
    }

    public string CallString(string func_name, string param)
    {
        return native.CallString(func_name, param);
    }

    public int CallInt(string func_name)
    {
        return native.CallInt(func_name);
    }

    public int CallInt(string func_name, string param)
    {
        return native.CallInt(func_name, param);
    }


    public bool CallBool(string func_name)
    {
        return native.CallBool(func_name);
    }

    public bool CallBool(string func_name, string param)
    {
        return native.CallBool(func_name, param);
    }

    public bool isIOSCN()
    {
        return native.isIOSCN();
    }
}