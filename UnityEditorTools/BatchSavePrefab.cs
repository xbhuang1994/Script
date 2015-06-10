using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;

public class BatchSavePrefab : MonoBehaviour
{

    [MenuItem("Tools/从选择的物体保存预设")]
    static public void CreatPrefab()
    {
        GameObject[] objs = Selection.gameObjects;
        var localfolder = SelectLocalFolder();
        foreach (GameObject obj in objs)
        {
            CreatPrefab(obj, localfolder);
        }
    }
    static private string SelectLocalFolder()
    {
        //这里要用自己的保存prefab的路径
        var folderpath = EditorUtility.OpenFolderPanel("Load png Textures of Directory", "Assets/Prefab/", "");
        //string localpath = "Assets/Prefab/" + obj.name + ".prefab";
        int assetsIndex = folderpath.IndexOf("Assets");
        var localpath = folderpath.Substring(assetsIndex, folderpath.Length - assetsIndex);
        return localpath;
    }

    [MenuItem("Tools/从选择的物体保存预设", true)]
    static bool ValidateCreatePrefab()
    {
        return Selection.activeGameObject != null;
    }
    //暂不开启
    //[MenuItem("Tools/保存场景中的预设实例")] 
    public static void SavePrefabAll()
    {
        List<GameObject> prefabObjs = new List<GameObject>();
        //获取当前场景里的所有游戏对象
        GameObject[] rootObjects = (GameObject[])UnityEngine.Object.FindObjectsOfType(typeof(GameObject));
        foreach (GameObject go in rootObjects)
        {
            //判断是否是预设实例
            if (PrefabUtility.GetPrefabType(go) == PrefabType.PrefabInstance)
            {
                //获取预设根物体保存到List
                GameObject prefabRoot = PrefabUtility.FindRootGameObjectWithSameParentPrefab(go);
                if (!prefabObjs.Contains(prefabRoot))
                {
                    prefabObjs.Add(prefabRoot);
                }
            }
        }
        foreach (GameObject go in prefabObjs)
        {
            //这里要用自己的保存prefab的路径
            string localpath = "Assets/Prefab/" + go.name + ".prefab";
            CreatNew(go, localpath);
        }
        //保存
        AssetDatabase.SaveAssets();
    }

    static void CreatPrefab(GameObject obj, string localfolder)
    {
        var localpath = localfolder + "/" + obj.name + ".prefab";
        //判断预设资源是否存在
        if (AssetDatabase.LoadAssetAtPath(localpath, typeof(GameObject)))
        {
            if (EditorUtility.DisplayDialog("预设已经存在", "是否重置？", "yes", "no"))
            {
                CreatNew(obj, localpath);
            }
        }
        else
            CreatNew(obj, localpath);
    }

    static void CreatNew(GameObject go, string path)
    {
        Object prefab = PrefabUtility.CreatePrefab(path, go);
        PrefabUtility.ReplacePrefab(go, prefab, ReplacePrefabOptions.ConnectToPrefab);
    }
}
