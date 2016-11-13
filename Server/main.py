import sys
from ics import Calendar

def downloadFile(url):
	import urllib.request
	response=urllib.request.urlopen(url)
	data=response.read()
	text=data.decode()
	return(text)

if __name__=="__main__":
	theList=sys.argv
	theList.pop(0)
	if len(theList)>0:
		print(theList[0])
		c=Calendar(downloadFile("https://cal.bruck.me/?pStud="+theList[0]))
		file=open("export.fkt","w")
		for item in c.events:
			#print('"'+item.name+'"'+'"'+item.begin.format("YYYY-MM-DD HH:mm:ss")+'"')
			file.write('%'+item.name+'%'+'%'+item.begin.format("YYYY-MM-DD HH:mm:ss")+'%\r\n')
		file.close()
	else:
		exit(-1)
