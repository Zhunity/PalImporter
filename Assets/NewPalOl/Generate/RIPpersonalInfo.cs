using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// IPpersonalInfo
	/// </summary>
    public partial class RIPpersonalInfo : RMember //
    {


        public RIPpersonalInfo() : base("IPpersonalInfo")
        {
        }

        public RIPpersonalInfo(System.Object instance) : base("IPpersonalInfo")
		{
            SetInstance(instance);
		}

        public RIPpersonalInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPpersonalInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
