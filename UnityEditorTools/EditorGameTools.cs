using UnityEditor;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/// <summary>
/// 游戏工具
/// </summary>
public class EditorGameTools : EditorWindow
{

    /// <summary>
    /// 想获得的道具ID集合和数量
    /// </summary>
    private static int[][] mIdTables;
    /// <summary>
    /// 我的文本
    /// </summary>
    private string mText;
    private string battleText;

    [MenuItem("GameTools/EditorGameTools")]
    static void Init()
    {
        EditorGameTools editorGameToolsWindow = (EditorGameTools)EditorWindow.GetWindow(typeof(EditorGameTools));
        editorGameToolsWindow.Show();
    }

    public void GetItemInText()
    {
        if (mText == null || mText.Length == 0)
        {
            Debug.LogWarning("请输入道具ID");
        }
        string[] texts = Regex.Split(mText, "\n");
        foreach (var t in texts)
        {
            if (t.Length < 2)
                return;
            string[] idStr = t.Split(':');
            //如果是列表
            if (idStr[0].Contains("-"))
            {
                int num = 0;
                if (idStr.Length > 1)
                    num = int.Parse(idStr[1]);
                GetItemList(idStr[0], num);
                return;
            }


            ///如果包含@b则代表解锁关卡
            if (idStr[0].Equals("@b"))
            {
                GetBattle(int.Parse(idStr[1]));
                return;
            }
            if (idStr.Length > 1)
                GetProps(idStr[0], int.Parse(idStr[1]));
            else
                GetProps(idStr[0]);
        }
    }
    /// <summary>
    /// Gets the item list.
    /// </summary>
    /// <param name="str">String.</param>
    /// <param name="num">Number.</param>
    private void GetItemList(string str, int num)
    {
        if (num == 0)
            num = 666;
        string[] s = str.Split(new char[] { '-' });
        int start = int.Parse(s[0]);
        int end = int.Parse(s[1]);
        for (int i = start; i <= end; i++)
        {
            GetProps(i.ToString(), num);
        }

    }

    [MenuItem("GameTools/GetSomething")]
    /// <summary>
    /// 获取一些道具
    /// </summary>
    /// <returns></returns>
    public static void GetSomething()
    {
        for (int e = 3; e < 8; e++)
        {
            for (int s = 0; s < 10; s++)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        string str = string.Format("{0}0{1}{2}{3}", e, s, i, j);
                        GetProps(str);
                    }

                }
            }
        }
        for (int i = 1; i < 20; i++)
        {
            GetProps(i.ToString());
        }
    }

    [MenuItem("GameTools/GetMine 100W")]
    public static void GetMine()
    {
        GetSome("@mine 1000000");
    }

    [MenuItem("GameTools/GetRMB 100W")]
    public static void GetRMB()
    {
        GetSome("@rmb 1000000");
    }

    [MenuItem("GameTools/GetPepo 100W")]
    public static void GetPepo()
    {
        GetSome("@pepo 1000000");
    }

    [MenuItem("GameTools/GetMoney 100W")]
    public static void GetMoney()
    {
        GetSome("@money 1000000");
    }

    [MenuItem("GameTools/Custom")]
    public static void Custom()
    {
        var list = new List<WidgetItemData>();
        list.Add(new WidgetItemData(RoleProType.IT_SILVER, 100));
        list.Add(new WidgetItemData(RoleProType.IT_SILVER, 100));
        list.Add(new WidgetItemData(RoleProType.IT_SILVER, 100));
        list.Add(new WidgetItemData(RoleProType.IT_SILVER, 100));
        list.Add(new WidgetItemData(RoleProType.IT_SILVER, 100));
        list.Add(new WidgetItemData(RoleProType.IT_SILVER, 100));
        list.Add(new WidgetItemData(RoleProType.IT_SILVER, 100));
        GlobalFunction.SendTipMsg(list);
    }
    string mIpStr = "editor_game_tools_ip_str";
    void OnGUI()
    {
        EditorGUILayout.LabelField("目标IP地址：");
        ipIndex = PlayerPrefs.GetInt(mIpStr);
        ipIndex = EditorGUILayout.Popup(ipIndex, options);
        PlayerPrefs.SetInt(mIpStr, ipIndex);
        EditorGUILayout.LabelField("获取道具/通关关卡：");
        mText = EditorGUILayout.TextArea(mText, GUILayout.Height(50));
        if (GUILayout.Button("OK"))
        {
            GetItemInText();
        }
        if (GUILayout.Button("100W金币"))
            GetMoney();
        if (GUILayout.Button("100W砖石"))
            GetRMB();
        if (GUILayout.Button("100W矿石"))
            GetMine();
        if (GUILayout.Button("100W人力"))
            GetPepo();
        if (GUILayout.Button("Custom"))
            Custom();

    }

    public void Update()
    {
        Main.LOGIN_IP = options[ipIndex];
        Main.SERVER_IP = options[ipIndex];
    }

    int ipIndex = 0;
    String[] options = {
        "192.168.0.220",
        "192.168.0.222",
        "192.168.0.141",
        "192.168.0.223",
        "192.168.0.151",
        "192.168.0.150"
    };
    /// <summary>
    /// 获取一个ID 默认为666个
    /// </summary>
    /// <param name="str"></param>
    /// <param name="num"></param>
    private static void GetProps(string str, int num = 666)
    {
        str = string.Format("@item {0} {1}", str, num);
        GetSome(str);
    }

    private static void GetBattle(int battleId)
    {
        string str = string.Format("@battle {0}", battleId);
        GetSome(str);
    }

    private static void GetSome(string str)
    {
        GlobalFunction.SendMsg(ProtocolIDs.MC_LOGIC_C2S_CHAT, new ReqChat((byte)ChatType.CT_World, (int)GlobalFunction.GetRoleInfo().uID, 0, str));
    }

}
