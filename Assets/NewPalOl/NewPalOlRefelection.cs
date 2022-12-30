using SMFrame.Editor.Refleaction;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

public class NewPalOlReflection 
{
	[MenuItem("SugarMonth/新仙剑/反射新仙剑代码")]
	static void RefelectionDll()
	{
		var bytes = File.ReadAllBytes("Assets/Script/NewPal/Assembly-CSharp-firstpass.bytes");
		Debug.Log(bytes.Length);
		var assembly = Assembly.Load(bytes);
		var types = assembly.GetTypes();

		var t = assembly.GetType("#u.#eNb");

		//var g = t.GetGenericArguments();
		//Debug.Log(t.FullName + "  " + t.IsGenericType + "  " + t.DeclaringType + "  " + g.Length + "  " + g[0]);
		//foreach (var item in g)
		//{
		//	Debug.Log(item.Name);
		//}

		//var UnityCSReflectionPath = $"{Application.dataPath}/Script/NewPal/";
		//string jsonFile = UnityCSReflectionPath + "FrameWork/Generate/Config/Replace.txt";
		//LegalNameConfig.LoadReplace(jsonFile);
		//Debug.Log(t.ToDeclareName() + "  " + t.ToClassName());
		GenerateInput.UnityCSReflectionPath = $"{Application.dataPath}/Script/NewPal/";
		GenerateInput.Generate(types);
	}
}
