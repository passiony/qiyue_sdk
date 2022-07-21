using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestNative : MonoBehaviour
{
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    
    void Start()
    {
        btn1.onClick.AddListener(OnClickBtn1);        
        btn2.onClick.AddListener(OnClickBtn2);        
        btn3.onClick.AddListener(OnClickBtn3);        
        btn4.onClick.AddListener(OnClickBtn4);        
    }

    private void OnClickBtn4()
    {
        var isEmulator = SdkManager.Instance.CallBool("isEmulator");
        Debug.Log(isEmulator);
    }

    private void OnClickBtn3()
    {
        var state = SdkManager.Instance.CallString("GetBatteryState");
        Debug.Log(state);
    }

    private void OnClickBtn2()
    {
        var deviceId = SdkManager.Instance.CallString("GetDeviceID");
        Debug.Log(deviceId);
    }

    private void OnClickBtn1()
    {
        var size = SdkManager.Instance.CallInt("getTotalInternalMemorySize");
        Debug.Log(size);
    }

}
