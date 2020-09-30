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
    private static string scenePath = "/CurrentScene.txt"; 
    private static string consPath = "/Conditions.txt"; 
    //存档文件一共两个 一个是保存场景的CurrentScene.txt
    //一个是保存bool数组的Conditions.txt

    //希望要保存的场景index 在buildsetting中查看
    public int sceneIndex;
    public int defaultScene;
    public bool[] conditions;

    //获取存储的场景
    public int GetSavedSceneIndex()
    {
        string str = File.ReadAllText(scenePath, Encoding.UTF8);
        if(str.Contains("0"))
        {
            return 0;
        }
        else if(str.Contains("1"))
        {
            return 1;
        }
        else if(str.Contains("2"))
        {
            return 2;
        }
        else if(str.Contains("3"))
        {
            return 3;
        }
        else if(str.Contains("4"))
        {
            return 4;
        }
        else
        {
            //没有找到存档文件
            return defaultScene;
        }
    }
    //获取存储的条件
    public void GetSavedConditions()
    {
        string[] strs = File.ReadAllLines(consPath, Encoding.UTF8);
        Instance.conditions = ConvertStringsToBools(strs);   
    }
    //保存存档
    public void SaveFiles()
    {
        Debug.Log(scenePath);
        Debug.Log(consPath);
        File.WriteAllText(scenePath, sceneIndex.ToString(), Encoding.UTF8);
        File.WriteAllText(consPath, ConvertBoolsToString(conditions), Encoding.UTF8);
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

    void Start() {
        scenePath = Application.persistentDataPath + scenePath;
        consPath = Application.persistentDataPath + consPath;
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
