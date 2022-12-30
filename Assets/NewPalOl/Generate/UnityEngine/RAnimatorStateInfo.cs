using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.AnimatorStateInfo
	/// </summary>
    public partial class RAnimatorStateInfo : RMember //
    {

		/// <summary>
		/// System.Int32 m_Name
		/// </summary>
		protected RField r_m_Name;
		public virtual RField Rm_Name
		{
			get
			{
				if(r_m_Name == null)
				{
					r_m_Name = new(this, "m_Name");
					r_m_Name.SetBelong(this.instance);
				}
				return r_m_Name;
			}
		}

		/// <summary>
		/// System.Int32 m_Path
		/// </summary>
		protected RField r_m_Path;
		public virtual RField Rm_Path
		{
			get
			{
				if(r_m_Path == null)
				{
					r_m_Path = new(this, "m_Path");
					r_m_Path.SetBelong(this.instance);
				}
				return r_m_Path;
			}
		}

		/// <summary>
		/// System.Int32 m_FullPath
		/// </summary>
		protected RField r_m_FullPath;
		public virtual RField Rm_FullPath
		{
			get
			{
				if(r_m_FullPath == null)
				{
					r_m_FullPath = new(this, "m_FullPath");
					r_m_FullPath.SetBelong(this.instance);
				}
				return r_m_FullPath;
			}
		}

		/// <summary>
		/// System.Single m_NormalizedTime
		/// </summary>
		protected RField r_m_NormalizedTime;
		public virtual RField Rm_NormalizedTime
		{
			get
			{
				if(r_m_NormalizedTime == null)
				{
					r_m_NormalizedTime = new(this, "m_NormalizedTime");
					r_m_NormalizedTime.SetBelong(this.instance);
				}
				return r_m_NormalizedTime;
			}
		}

		/// <summary>
		/// System.Single m_Length
		/// </summary>
		protected RField r_m_Length;
		public virtual RField Rm_Length
		{
			get
			{
				if(r_m_Length == null)
				{
					r_m_Length = new(this, "m_Length");
					r_m_Length.SetBelong(this.instance);
				}
				return r_m_Length;
			}
		}

		/// <summary>
		/// System.Single m_Speed
		/// </summary>
		protected RField r_m_Speed;
		public virtual RField Rm_Speed
		{
			get
			{
				if(r_m_Speed == null)
				{
					r_m_Speed = new(this, "m_Speed");
					r_m_Speed.SetBelong(this.instance);
				}
				return r_m_Speed;
			}
		}

		/// <summary>
		/// System.Single m_SpeedMultiplier
		/// </summary>
		protected RField r_m_SpeedMultiplier;
		public virtual RField Rm_SpeedMultiplier
		{
			get
			{
				if(r_m_SpeedMultiplier == null)
				{
					r_m_SpeedMultiplier = new(this, "m_SpeedMultiplier");
					r_m_SpeedMultiplier.SetBelong(this.instance);
				}
				return r_m_SpeedMultiplier;
			}
		}

		/// <summary>
		/// System.Int32 m_Tag
		/// </summary>
		protected RField r_m_Tag;
		public virtual RField Rm_Tag
		{
			get
			{
				if(r_m_Tag == null)
				{
					r_m_Tag = new(this, "m_Tag");
					r_m_Tag.SetBelong(this.instance);
				}
				return r_m_Tag;
			}
		}

		/// <summary>
		/// System.Int32 m_Loop
		/// </summary>
		protected RField r_m_Loop;
		public virtual RField Rm_Loop
		{
			get
			{
				if(r_m_Loop == null)
				{
					r_m_Loop = new(this, "m_Loop");
					r_m_Loop.SetBelong(this.instance);
				}
				return r_m_Loop;
			}
		}

		/// <summary>
		/// Int32 fullPathHash
		/// </summary>
		protected RProperty r_fullPathHash;
		public virtual RProperty RfullPathHash
		{
			get
			{
				if(r_fullPathHash == null)
				{
					r_fullPathHash = new(this, "fullPathHash", -1);
					r_fullPathHash.SetBelong(this.instance);
				}
				return r_fullPathHash;
			}
		}

		/// <summary>
		/// Int32 nameHash
		/// </summary>
		protected RProperty r_nameHash;
		public virtual RProperty RnameHash
		{
			get
			{
				if(r_nameHash == null)
				{
					r_nameHash = new(this, "nameHash", -1);
					r_nameHash.SetBelong(this.instance);
				}
				return r_nameHash;
			}
		}

		/// <summary>
		/// Int32 shortNameHash
		/// </summary>
		protected RProperty r_shortNameHash;
		public virtual RProperty RshortNameHash
		{
			get
			{
				if(r_shortNameHash == null)
				{
					r_shortNameHash = new(this, "shortNameHash", -1);
					r_shortNameHash.SetBelong(this.instance);
				}
				return r_shortNameHash;
			}
		}

		/// <summary>
		/// Single normalizedTime
		/// </summary>
		protected RProperty r_normalizedTime;
		public virtual RProperty RnormalizedTime
		{
			get
			{
				if(r_normalizedTime == null)
				{
					r_normalizedTime = new(this, "normalizedTime", -1);
					r_normalizedTime.SetBelong(this.instance);
				}
				return r_normalizedTime;
			}
		}

		/// <summary>
		/// Single length
		/// </summary>
		protected RProperty r_length;
		public virtual RProperty Rlength
		{
			get
			{
				if(r_length == null)
				{
					r_length = new(this, "length", -1);
					r_length.SetBelong(this.instance);
				}
				return r_length;
			}
		}

		/// <summary>
		/// Single speed
		/// </summary>
		protected RProperty r_speed;
		public virtual RProperty Rspeed
		{
			get
			{
				if(r_speed == null)
				{
					r_speed = new(this, "speed", -1);
					r_speed.SetBelong(this.instance);
				}
				return r_speed;
			}
		}

		/// <summary>
		/// Single speedMultiplier
		/// </summary>
		protected RProperty r_speedMultiplier;
		public virtual RProperty RspeedMultiplier
		{
			get
			{
				if(r_speedMultiplier == null)
				{
					r_speedMultiplier = new(this, "speedMultiplier", -1);
					r_speedMultiplier.SetBelong(this.instance);
				}
				return r_speedMultiplier;
			}
		}

		/// <summary>
		/// Int32 tagHash
		/// </summary>
		protected RProperty r_tagHash;
		public virtual RProperty RtagHash
		{
			get
			{
				if(r_tagHash == null)
				{
					r_tagHash = new(this, "tagHash", -1);
					r_tagHash.SetBelong(this.instance);
				}
				return r_tagHash;
			}
		}

		/// <summary>
		/// Boolean loop
		/// </summary>
		protected RProperty r_loop;
		public virtual RProperty Rloop
		{
			get
			{
				if(r_loop == null)
				{
					r_loop = new(this, "loop", -1);
					r_loop.SetBelong(this.instance);
				}
				return r_loop;
			}
		}

		/// <summary>
		/// Boolean IsName(System.String)
		/// </summary>
		protected RMethod r_RIsName_String;
		public virtual RMethod RIsName_String
		{
			get
			{
				if(r_RIsName_String == null)
				{
					r_RIsName_String = new(this, "IsName", 0, typeof(System.String));
					r_RIsName_String.SetBelong(this.instance);
				}
				return r_RIsName_String;
			}
		}

		/// <summary>
		/// Boolean IsTag(System.String)
		/// </summary>
		protected RMethod r_RIsTag_String;
		public virtual RMethod RIsTag_String
		{
			get
			{
				if(r_RIsTag_String == null)
				{
					r_RIsTag_String = new(this, "IsTag", 0, typeof(System.String));
					r_RIsTag_String.SetBelong(this.instance);
				}
				return r_RIsTag_String;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}


        public RAnimatorStateInfo() : base("UnityEngine.AnimatorStateInfo")
        {
        }

        public RAnimatorStateInfo(System.Object instance) : base("UnityEngine.AnimatorStateInfo")
		{
            SetInstance(instance);
		}

        public RAnimatorStateInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAnimatorStateInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RIsName_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsTag(System.String  @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RIsTag_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
