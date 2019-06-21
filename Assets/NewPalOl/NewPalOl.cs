using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NewPalOl : MonoBehaviour
{
	[MenuItem("Assets/读取新仙剑ol ab", false, 1)]
	public static void ReadNewPalOlAb()
    {
		string bundlePath = AssetDatabase.GetAssetPath(Selection.activeObject);
		AssetBundle bundle = AssetBundle.LoadFromFile(bundlePath);
		if (bundle == null)
		{
			Debug.LogError("Can not find bundle " + bundlePath);
		}
		var list = bundle.GetAllAssetNames();
		foreach(var item in list)
		{
			Debug.Log(item);
		}
		bundle.Unload(true);
	}
}
