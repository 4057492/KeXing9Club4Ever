using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class TxtIOManager : MonoBehaviour
{
    //单例
    public static TxtIOManager Instance { get; private set; }
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            GameObject.Destroy(this.gameObject);
        }
        Instance = this;
    }
    void OnDestroy()
    {
        Instance = null;
    }
    //是保存场景的CurrentScene.txt
    public  string scenePath = "/CurrentScene.txt"; 
    //保存bool数组的Conditions.txt(代表当前active的需要保存的gameobject)
    public  string consPath = "/Conditions.txt";
    //保存character的position的Position.txt
    public string posPath = "/Position.txt";

    //希望要保存的场景index 在buildsetting中查看
    public int sceneIndex;
    public int defaultScene;
    public bool[] conditions;
    public Vector3 pos;

    //获取存储的场景
    public int GetSavedSceneIndex()
    {
        string str = File.ReadAllText(scenePath, Encoding.UTF8);
        if(str.Equals(string.Empty))
        {
            return defaultScene;
        }
        float temp = float.Parse(str);
        return (int)temp;
    }
    //获取存储的条件
    public bool[] GetSavedConditions()
    {
        string[] strs = File.ReadAllLines(consPath, Encoding.UTF8);
        Instance.conditions = ConvertStringsToBools(strs);
        return Instance.conditions;
    }
    //获取存储的位置
    public Vector3 GetSavedPosition()
    {
        string[] strs = File.ReadAllLines(posPath, Encoding.UTF8);
        Instance.pos = ConvertStringsToVector3(strs);
        return Instance.pos;
    }
    
    //保存存档
    public void SaveFiles()
    {
        Debug.Log(scenePath);
        Debug.Log(consPath);
        Debug.Log(posPath);
        File.WriteAllText(scenePath, sceneIndex.ToString(), Encoding.UTF8);
        File.WriteAllText(consPath, ConvertBoolsToString(conditions), Encoding.UTF8);
        File.WriteAllText(posPath, ConvertVector3ToString(pos), Encoding.UTF8);
    }
    //保存新游戏存档
    public void NewFiles()
    {
        Debug.Log(scenePath);
        Debug.Log(consPath);
        Debug.Log(posPath);
        File.WriteAllText(scenePath, defaultScene.ToString(), Encoding.UTF8);
        File.WriteAllText(consPath, "", Encoding.UTF8);
        File.WriteAllText(posPath, "", Encoding.UTF8);
    }


    //读取txt
    //string[] strs = File.ReadAllLines(path, Encoding.UTF8);
    //新建或覆盖txt
    //File.WriteAllText(path, str, Encoding.UTF8);
    
    //将数组转化为string
    public static string ConvertBoolsToString(bool[] bools)
    {
        if(bools == null)
        {
            return null;
        }
        if(bools.Length == 0)
        {
            return null;
        }
        string result = "";
        for(int i = 0 ; i < bools.Length ; i++)
        {
            int temp = bools[i] ? 1 : 0; 
            result = System.String.Concat(result,temp.ToString());
            result = System.String.Concat(result,"\n");
        }
        return result;
    }

    //将string转化为数组
    public static bool[] ConvertStringsToBools(string[] strs)
    {
        if(strs == null)
        {
            return null;
        }
        if(strs.Length == 0)
        {
            return null;
        }
        List<bool> boolList = new List<bool>();
        foreach(string str in strs)
        {
            //Debug.Log(str);
            if(str.Contains("1"))
            {
                boolList.Add(true);
            }
            else if(str.Contains("0"))
            {
                boolList.Add(false);
            }
            else
            {
                Debug.LogError("wrong.");
            }
        }
        return boolList.ToArray();
    }
    //将vector3转换为string
    public static string ConvertVector3ToString(Vector3 vec)
    {
        if(vec == null)
        {
            return null;
        }
        string result = "";
        
        result = System.String.Concat(result,vec.x.ToString());
        result = System.String.Concat(result,"\n");
        result = System.String.Concat(result,vec.y.ToString());
        result = System.String.Concat(result,"\n");
        result = System.String.Concat(result,vec.z.ToString());
        result = System.String.Concat(result,"\n");
        
        return result;
    }
    //将string转化为vector3
    public static Vector3 ConvertStringsToVector3(string[] strs)
    {
        if(strs == null)
        {
            return Vector3.zero;
        }
        if(strs.Length == 0)
        {
            return Vector3.zero;
        }
        Vector3 result = Vector3.zero;
        result.x = float.Parse(strs[0]);
        result.y = float.Parse(strs[1]);
        result.z = float.Parse(strs[2]);
        return result;
    }
    void Start() {
        scenePath = Application.persistentDataPath + scenePath;
        consPath = Application.persistentDataPath + consPath;
        posPath = Application.persistentDataPath + posPath;
    }

    //测试用
    /*void OnGUI() 
    {
        if (GUI.Button(new Rect(20, 40, 100, 50), "save text"))
        {
            Debug.Log(consPath);
            SaveFiles();
        }
        if (GUI.Button(new Rect(20, 100, 100, 50), "read text"))
        {
            GetSavedConditions();
        }
        GUI.TextArea(new Rect(20, 160, 100, 500), consPath);
        for (int i = 0; i < conditions.Length; i++)
        {
            conditions[i] = GUI.Toggle(new Rect(200, 40 + i * 30, 100, 20), conditions[i], i.ToString() + " : ");
        }
    } */
}
