using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class TxtIOManager : MonoBehaviour
{
    //单例

    private string scenePath = "\\CurrentScene.txt"; 
    private string consPath = "\\Conditions.txt"; 
    //存档文件一共两个 一个是保存场景的CurrentScene.txt
    //一个是保存bool数组的Conditions.txt
    public string sceneName;
    public bool[] conditions;

    //获取存储的场景
    //获取存储的条件
    //保存存档 (切换场景自动保存)

    //读取txt
    //string[] strs = File.ReadAllLines(path, Encoding.UTF8);
    //新建或覆盖txt
    //File.WriteAllText(path, str, Encoding.UTF8);
    
    //将数组转化为string
    public string ConvertBoolsToString(bool[] bools)
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
    public bool[] ConvertStringsToBools(string[] strs)
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
            Debug.Log(str);
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
        scenePath = Application.dataPath + scenePath;
        consPath = Application.dataPath + consPath;
    }

    void OnGUI() 
    {
        if (GUI.Button(new Rect(20, 40, 100, 50), "save text"))
        {
            Debug.Log(consPath);
            File.WriteAllText(consPath, ConvertBoolsToString(conditions), Encoding.UTF8);
        }
        if (GUI.Button(new Rect(20, 100, 100, 50), "read text"))
        {
            string[] strs = File.ReadAllLines(consPath, Encoding.UTF8);
            conditions = ConvertStringsToBools(strs);
        }

    } 
}
