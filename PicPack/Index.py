#!/usr/bin/python

import os
import shutil
import tools
ui_folder = r"D:\Tianze\art\project\ui\output"
texture_packer = r"D:\CodeAndWeb\TexturePacker\bin\TexturePacker.exe"
assetpath = r"D:\Tianze\dev\client\ClientEditor\Assets\Art\UI"


class PackTPS:

    def __init__(self):
        pass
    # 打包图集
    def publishTps(self, folder, filename, assetfolder):
        fp = PackTPS.getPATH(ui_folder,folder,filename)
        tpspath = PackTPS.getTPS(fp)
        picpath = PackTPS.getPNG(fp)
        txtpath = PackTPS.getTXT(fp)
        targetDir = PackTPS.getTARGET(assetpath ,assetfolder)
        if not os.path.exists(picpath):
            picpath = PackTPS.getJPG(fp)
        args = texture_packer + " " + tpspath
        os.system(args)
        shutil.copy(picpath,  targetDir)
        shutil.copy(txtpath,  targetDir)
    def getTARGET(path,folder):
    	return path + "\\" + folder
    def getPATH(ui_folder,folder,filename):
    	return ui_folder + "\\" + folder + "\\" + filename
    def getTPS(filepath):
        return filepath + ".tps"

    def getPNG(filepath):
        return filepath + ".png"

    def getTXT(filepath):
        return filepath + ".txt"

    def getJPG(filepath):
    	return filepath + ".jpg"    	

pr = PackTPS()
# VIP界面
pr.publishTps("VIP", "UI_Vip", "UI_Vip")
# 公共资源图集
pr.publishTps("common", "common_global", "common_global") 
# 英雄（列表、详情等）界面
pr.publishTps("yingxiong", "UI_Hero", "UI_Hero")  
# 英雄天赋界面
pr.publishTps("yingxiong", "UI_Talent", "UI_Talent")  
# 布阵界面
pr.publishTps("liezhen","UI_Liezhen","UI_Liezhen")
# 飞艇
pr.publishTps("feiting","UI_Airship","UI_Airship")
# 战斗界面
pr.publishTps("zhandou\\zhandou","UI_Battle","UI_Battle")
#君主
pr.publishTps("junzhu","UI_UpgradeLevel","UI_UpgradeLevel")
#背包
pr.publishTps("beibao","UI_Bag","UI_Bag")

#ICON 相关
assetpath = r"D:\Tianze\dev\client\ClientEditor\Assets\Prefab\Icon"
#技能1
pr.publishTps("icon\\skill","Icon_Skill_101","Icon_Skill")
#技能2
pr.publishTps("icon\\skill","Icon_Skill_111","Icon_Skill")
