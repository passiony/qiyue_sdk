using UnityEditor;

public class NativeBase
{
    public virtual void InitSdk()
    {
    }

    public virtual void OcCallSDKFunc(string type, string jsonpara){}

    public virtual void IosCallUIActiveInit(){}

    public virtual void IosCallExitApp(){}
    
    public virtual void CallVoid(string func_name)
    {
    }

    public virtual void CallVoid(string func_name, string param)
    {
        if (func_name.Equals("TakePhoto"))
        {
//            string path = EditorUtility.OpenFilePanel("选择头像", "", "png");
//            if (!path.Equals(string.Empty))
//            {
//                JsonPhotoInfo jsonData = JsonUtil.DeserializeObject<JsonPhotoInfo>(param);
//                string file_path = jsonData.file_path;
//                string file_name = jsonData.file_name;
//                int width = jsonData.width;
//                int height = jsonData.height;
//                Util.cutPicture(path, file_path + file_name, width, height);
//                jsonData.func_name = "GetPhoto";
//                Util.CallMethod("SDKManager", "CallBack", jsonData.ToJson());
//            }
        }
    }

    public virtual string CallString(string func_name)
    {
        return "";
    }

    public virtual string CallString(string func_name, string param)
    {
        return "";
    }

    public virtual int CallInt(string func_name)
    {
        return -1;
    }

    public virtual int CallInt(string func_name, string param)
    {
        return -1;
    }

    public virtual bool CallBool(string func_name)
    {
        return false;
    }

    public virtual bool CallBool(string func_name, string param)
    {
        return false;
    }

    public virtual bool isIOSCN()
    {
        return false;
    }

}