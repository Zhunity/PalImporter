#include <iostream>
#include <vector>
using namespace std;

//定义文件头
struct fileHeader
{
	//文件合法性判断
	char valid[4];
	//未知
	int iDontKnow;
	//模型计数
	int polyCount;
};

//模型头
struct polyHeader
{
	char iDontKnow[52];
};

//顶点头
struct vertexHeader
{
	char iDontKnow[28];
	int vertexCount;
};

//顶点
struct vertex
{
	//顶点的坐标
	float x;
	float y;
	float z;
	//FFFF FFFF 
	long e;
	//顶点的贴图坐标
	float u;
	float v;
};

//贴图数据区
struct betweenVertexAndFace
{
	//贴图数据区，固定长度
	char iDontKnow[144];
};

//面数据区头
struct faceHeader
{
	int iDontKnow[2];
	int whoCares;
	int faceCount;
};

//三角面数据
struct face
{
	short a;
	short b;
	short c;
};

//入口
int main(int argc, char* argv[])
{
	//建立文件头
	struct fileHeader theFileHeader;
	struct polyHeader tempPolyHeader;

	//显示指定的文件名
	printf("input:%s\n",argv[1]);

	//打开指定的文件
	FILE *fp;
	fp=fopen(argv[1],"rb");

	//读取文件头
	fread(&theFileHeader,sizeof(struct fileHeader),1,fp);
	//如果文件合法
	if(theFileHeader.valid[0]=='P'&&theFileHeader.valid[1]=='O'&&theFileHeader.valid[2]=='L'&&theFileHeader.valid[3]=='Y')
	{
		printf("the file seems to be valid!\n");
	}
	else
	{
		//不合法退出
		printf("invalid file format!\n");
		getchar();
		exit(0);
	}

	//读取模型头
	for(int i=0;i<theFileHeader.polyCount;i++)
	{
		fread(&tempPolyHeader,sizeof(struct polyHeader),1,fp);
	}

	//存储顶点和面数据的空间
	vector<struct vertex> vertexList;
	vector<struct face> faceList;

	//遍历全部的模型
	for(int i=0;i<theFileHeader.polyCount;i++)
	{
		//清空存储空间	
		vertexList.clear();
		faceList.clear();
		//得到顶点头
		struct vertexHeader tempVertexHeader;
		fread(&tempVertexHeader,sizeof(struct vertexHeader),1,fp);
		printf("vertex count [%d]\n",tempVertexHeader.vertexCount);
		//遍历全部的顶点
		for(int e=0;e<tempVertexHeader.vertexCount;e++)
		{
			//保存顶点的数据
			struct vertex tempVertex;
			fread(&tempVertex,sizeof(struct vertex),1,fp);
			vertexList.push_back(tempVertex);
		}
		//读取贴图数据
		struct betweenVertexAndFace tempBetween;
		fread(&tempBetween,sizeof(struct betweenVertexAndFace),1,fp);
		//得到面数据的头部
		struct faceHeader tempFaceHeader;
		fread(&tempFaceHeader,sizeof(struct faceHeader),1,fp);
		printf("face count [%d]\n",tempFaceHeader.faceCount);
		//遍历所有的面
		for(int e=0;e<tempFaceHeader.faceCount;e++)
		{
			//保存数据
			struct face tempFace;
			fread(&tempFace,sizeof(struct face),1,fp);
			faceList.push_back(tempFace);
		}
		//生成obj格式的文件
		char outName[32]={0};
		sprintf(outName,"out%s%d.obj",argv[1],i);
		FILE *outFp;
		outFp=fopen(outName,"w");

		for(int e=0;e<vertexList.size();e++)
		{
			fprintf(outFp,"v %f %f %f \n",vertexList[e].x,vertexList[e].y,vertexList[e].z);
		}

		fprintf(outFp,"\n\n");

		for(int e=0;e<vertexList.size();e++)
		{
			fprintf(outFp,"vt %f %f\n",vertexList[e].u,vertexList[e].v);
		}
	
		fprintf(outFp,"\n\ng model%d\n",i);
	
		for(int e=0;e<faceList.size();e++)
		{
			fprintf(outFp,"f %d/%d %d/%d %d/%d\n",faceList[e].a+1,faceList[e].a+1,faceList[e].b+1,faceList[e].b+1,faceList[e].c+1,faceList[e].c+1);
		}
		fprintf(outFp,"\n\ng\n\n");
		fclose(outFp);
	}
	fclose(fp);
	getchar();
}