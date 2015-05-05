#!/usr/bin/python
import os 
def BatchRename(path,i):
	f=open(path + 'info.txt','w')
	for file in os.listdir(path): 
		if os.path.isfile(os.path.join(path,file))==True: 
			print(os.path.splitext(file)[1])
			if os.path.splitext(file)[1] == '.jpg': 
				newname= str(i) + '.jpg' 
				f.write(file +'  ,  ' +  newname)
				f.write('\n')
				os.rename(os.path.join(path,file),os.path.join(path,newname)) 
				i+=1
				print (file,'ok' )
	f.close()
BatchRename('D:\\Tianze\\art\\project\\ui\\output\\icon\\skill\\Icons\\100\\',10000)
BatchRename('D:\\Tianze\\art\\project\\ui\\output\\icon\\skill\\Icons\\110\\',11000)
# print file.split('.')[-1] 