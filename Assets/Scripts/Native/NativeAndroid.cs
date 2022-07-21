using UnityEngine;

public class NativeAndroid : NativeBase
{
    public const string jave_class_name = "com.xwgame.luaframework.XwActivity";
    public AndroidJavaClass jc = null;
    public AndroidJavaObject jo = null;

    public override void InitSdk()
    {
        AndroidJavaClass jc = new AndroidJavaClass(jave_class_name);
        jo = new AndroidJavaObject(jave_class_name);
//        jo = jc.CallStatic<AndroidJavaObject>("GetInstance");
    }

    public AndroidJavaObject JavaObject
    {
        get
        {
            if (jo == null)
                jo = jc.CallStatic<AndroidJavaObject>("GetInstance");
            return jo;
        }
    }
    public override void CallVoid(string func_name)
    {
        JavaObject.Call(func_name);
    }

    public override void CallVoid(string func_name, string param)
    {
        JavaObject.Call(func_name, param);
    }

    public override string CallString(string func_name)
    {
        return JavaObject.Call<string>(func_name);
    }

    public override string CallString(string func_name, string param)
    {
        return JavaObject.Call<string>(func_name, param);
    }

    public override int CallInt(string func_name)
    {
        return JavaObject.Call<int>(func_name);
    }

    public override int CallInt(string func_name, string param)
    {
        return JavaObject.Call<int>(func_name, param);
    }


    public override bool CallBool(string func_name)
    {
        return JavaObject.Call<bool>(func_name);
    }

    public override bool CallBool(string func_name, string param)
    {
        return JavaObject.Call<bool>(func_name, param);
    }

}