using UnityEngine;
using System.Collections;
using System.IO;
using UnityEditor;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;

public class LoadNewPalRes 
{

	// Use this for initialization
	void Start () {
		//CharacBehav
		//AvatarController
		//AnimationController
		//CharacterDownLand
		//CharacterElement
		//CharacterConfigTemplate

		//ConfigDispatch
		//NPCBehav
		// #HRb
		//NpcResStructHold
	}

	[MenuItem("SugarMonth/新仙剑/加载新仙剑代码")]
	static void LoadDll()
	{
		var bytes = File.ReadAllBytes("Assets/Script/NewPal/Assembly-CSharp-firstpass.bytes");
		Debug.Log(bytes.Length);
		var assembly = Assembly.Load(bytes);
		var types = assembly.GetTypes();
		//foreach(var type in types)
		//{
		//	Debug.Log(type);
		//}

		var t = assembly.GetType("#IRb.#HRb");
		Activator.CreateInstance(t);
		Debug.Log(t);
		var member = t.GetMembers(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach(var m in member)
		{
			Debug.Log(m.Name + "  " + m.MemberType);
			if (m.Name == "#d")
			{
				var s = ((FieldInfo)m).GetValue(null) as Dictionary<int, string>;
				foreach(var item in s)
				{
					Debug.Log(item.Key + "  " + item.Value);
				}
			}
		}


		Stream stream = assembly.GetManifestResourceStream("{f8e4f253-a2ae-4040-a5e3-cec8d5572459}");

		try
		{
			do
			{

				int num4 = Convert.ToInt32(stream.Length);

				byte[] length = new byte[num4];
				stream.Read(length, 0, num4);
					Stream stream2 = stream;
				if (7 != 0)
				{
					stream2.Close();
				}
			}
			while (false);
		}
		finally
		{
			if (stream != null)
			{
				stream.Dispose();
			}
		}
	}
}
