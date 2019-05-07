using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using UnityEngine.Profiling;

public class xj3Model : MonoBehaviour
{
	//https://www.cnblogs.com/mahatmasmile/p/4221523.html
	/// <summary> 
	/// 将一个object对象序列化，返回一个byte[]         
	/// </summary> 
	/// <param name="obj">能序列化的对象</param>         
	/// <returns></returns> 
	public static byte[] ObjectToBytes(object obj)
	{
		using (MemoryStream ms = new MemoryStream())
		{
			IFormatter formatter = new BinaryFormatter(); formatter.Serialize(ms, obj); return ms.GetBuffer();
		}
	}

	/// <summary> 
	/// 将一个序列化后的byte[]数组还原         
	/// </summary>
	/// <param name="Bytes"></param>         
	/// <returns></returns> 
	public static object BytesToObject(byte[] Bytes)
	{
		for(int i = 0; i < Bytes.Length; i ++)
		{
			Debug.Log(i + "  " + Bytes[i]);
		}
		using (MemoryStream ms = new MemoryStream(Bytes))
		{
			IFormatter formatter = new BinaryFormatter();
			return formatter.Deserialize(ms);
		}
	}

	//定义文件头
	[StructLayout(LayoutKind.Explicit)]
	class fileHeader
	{
		//文件合法性判断
		[FieldOffset(0)]
		public char[] valid = new char[4];
		//未知
		[FieldOffset(4)]
		public int iDontKnow;
		//模型计数
		[FieldOffset(8)]
		public int polyCount;
	};

	//模型头
	class polyHeader
	{
		public char[] iDontKnow = new char[52];
	};

	//顶点头
	class vertexHeader
	{
		public char[] iDontKnow = new char[28];
		public int vertexCount;
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
	class betweenVertexAndFace
	{
		//贴图数据区，固定长度
		public char[] iDontKnow = new char[144];
	};

	//面数据区头
	class faceHeader
	{
		public int[] iDontKnow = new int[2];
		public int whoCares;
		public int faceCount;
	};

	//三角面数据
	struct face
	{
		short a;
		short b;
		short c;
	};

	[MenuItem("Assets/生成仙剑3模型", false, 1)]
    public static void Pal3Model()
	{
		//建立文件头
		fileHeader theFileHeader = new fileHeader();
		polyHeader tempPolyHeader = new polyHeader();

		string path = AssetDatabase.GetAssetPath(Selection.activeObject);
		//打开指定的文件
		FileStream fp = new FileStream(path, FileMode.Open);
		try
		{
			fp.Seek(0, SeekOrigin.Begin);
			// nameof typeof sizeof
			//读取文件头
			int size = Marshal.SizeOf(theFileHeader);// sizeof(fileHeader);
			byte[] content = new byte[size];
			fp.Read(content, 0, size);
			Debug.Log(path + "   " + size + "   " + content.ToString());
			BytesToObject(content);
			//theFileHeader = BytesToObject(content) as fileHeader;
			//Debug.Log(theFileHeader.valid);
		}
		catch(Exception e)
		{
			Debug.LogError(e.ToString());
		}
		finally
		{
			if(fp != null)
			{
				fp.Close();
			}	
		}

		
//		//如果文件合法
//		if(theFileHeader.valid[0]=='P'&&theFileHeader.valid[1]=='O'&&theFileHeader.valid[2]=='L'&&theFileHeader.valid[3]=='Y')
//		{
//			printf("the file seems to be valid!\n");
//	}
//	else
//	{
//		//不合法退出
//		printf("invalid file format!\n");
//		return;
//	}

//	//读取模型头
//	for(int i=0;i<theFileHeader.polyCount;i++)
//	{
//		fread(&tempPolyHeader,sizeof(struct polyHeader),1,fp);
//	}

//	//存储顶点和面数据的空间
//	vector<struct vertex> vertexList;
//	vector<struct face> faceList;

//	//遍历全部的模型
//	for(int i=0;i<theFileHeader.polyCount;i++)
//	{
//		//清空存储空间	
//		vertexList.clear();
//		faceList.clear();
//		//得到顶点头
//		struct vertexHeader tempVertexHeader;
//		fread(&tempVertexHeader,sizeof(struct vertexHeader),1,fp);
//		printf("vertex count [%d]\n", tempVertexHeader.vertexCount);
//		//遍历全部的顶点
//		for(int e=0;e<tempVertexHeader.vertexCount;e++)
//		{
//			//保存顶点的数据
//			struct vertex tempVertex;
//			fread(&tempVertex,sizeof(struct vertex),1,fp);
//			vertexList.push_back(tempVertex);
//		}
//		//读取贴图数据
//		struct betweenVertexAndFace tempBetween;
//		fread(&tempBetween,sizeof(struct betweenVertexAndFace),1,fp);
//		//得到面数据的头部
//		struct faceHeader tempFaceHeader;
//		fread(&tempFaceHeader,sizeof(struct faceHeader),1,fp);
//		printf("face count [%d]\n", tempFaceHeader.faceCount);
//		//遍历所有的面
//		for(int e=0;e<tempFaceHeader.faceCount;e++)
//		{
//			//保存数据
//			struct face tempFace;
//			fread(&tempFace,sizeof(struct face),1,fp);
//			faceList.push_back(tempFace);
//		}
//		//生成obj格式的文件
//		char outName[32] = { 0 };
//sprintf(outName,"out%s%d.obj", argv[1], i);
//FILE* outFp;
//outFp=fopen(outName,"w");

//		for(int e=0;e<vertexList.size();e++)
//		{
//			fprintf(outFp,"v %f %f %f \n", vertexList[e].x, vertexList[e].y, vertexList[e].z);
//		}

//		fprintf(outFp,"\n\n");

//		for(int e=0;e<vertexList.size();e++)
//		{
//			fprintf(outFp,"vt %f %f\n", vertexList[e].u, vertexList[e].v);
//		}
	
//		fprintf(outFp,"\n\ng model%d\n", i);
	
//		for(int e=0;e<faceList.size();e++)
//		{
//			fprintf(outFp,"f %d/%d %d/%d %d/%d\n", faceList[e].a+1, faceList[e].a+1, faceList[e].b+1, faceList[e].b+1, faceList[e].c+1, faceList[e].c+1);
//		}
//		fprintf(outFp,"\n\ng\n\n");
//fclose(outFp);
//	}
//	fclose(fp);
//getchar();
	}
}
