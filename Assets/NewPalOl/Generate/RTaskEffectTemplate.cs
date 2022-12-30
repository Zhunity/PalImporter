using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// TaskEffectTemplate
	/// </summary>
    public partial class RTaskEffectTemplate : RMember //
    {

		/// <summary>
		/// KeyValueContent m_ItemContent
		/// </summary>
		protected RKeyValueContent r_m_ItemContent;
		public virtual RKeyValueContent Rm_ItemContent
		{
			get
			{
				if(r_m_ItemContent == null)
				{
					r_m_ItemContent = new(this, "m_ItemContent");
					r_m_ItemContent.SetBelong(this.instance);
				}
				return r_m_ItemContent;
			}
		}

		/// <summary>
		/// Void OnLoadTaskEffectConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadTaskEffectConfig_Object;
		public virtual RMethod ROnLoadTaskEffectConfig_Object
		{
			get
			{
				if(r_ROnLoadTaskEffectConfig_Object == null)
				{
					r_ROnLoadTaskEffectConfig_Object = new(this, "OnLoadTaskEffectConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadTaskEffectConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadTaskEffectConfig_Object;
			}
		}

		/// <summary>
		/// System.String GetBeadEffectNameString(Int32, Single ByRef)
		/// </summary>
		protected RMethod r_RGetBeadEffectNameString_Int32_Ref_Single;
		public virtual RMethod RGetBeadEffectNameString_Int32_Ref_Single
		{
			get
			{
				if(r_RGetBeadEffectNameString_Int32_Ref_Single == null)
				{
					r_RGetBeadEffectNameString_Int32_Ref_Single = new(this, "GetBeadEffectNameString", 0, typeof(System.Int32), typeof(System.Single).MakeByRefType());
					r_RGetBeadEffectNameString_Int32_Ref_Single.SetBelong(this.instance);
				}
				return r_RGetBeadEffectNameString_Int32_Ref_Single;
			}
		}

		/// <summary>
		/// System.String GetSelectInfoEffectNameString(Int32, Single ByRef)
		/// </summary>
		protected RMethod r_RGetSelectInfoEffectNameString_Int32_Ref_Single;
		public virtual RMethod RGetSelectInfoEffectNameString_Int32_Ref_Single
		{
			get
			{
				if(r_RGetSelectInfoEffectNameString_Int32_Ref_Single == null)
				{
					r_RGetSelectInfoEffectNameString_Int32_Ref_Single = new(this, "GetSelectInfoEffectNameString", 0, typeof(System.Int32), typeof(System.Single).MakeByRefType());
					r_RGetSelectInfoEffectNameString_Int32_Ref_Single.SetBelong(this.instance);
				}
				return r_RGetSelectInfoEffectNameString_Int32_Ref_Single;
			}
		}

		/// <summary>
		/// Int32 GetTribeLingzhuLevel(Int32)
		/// </summary>
		protected RMethod r_RGetTribeLingzhuLevel_Int32;
		public virtual RMethod RGetTribeLingzhuLevel_Int32
		{
			get
			{
				if(r_RGetTribeLingzhuLevel_Int32 == null)
				{
					r_RGetTribeLingzhuLevel_Int32 = new(this, "GetTribeLingzhuLevel", 0, typeof(System.Int32));
					r_RGetTribeLingzhuLevel_Int32.SetBelong(this.instance);
				}
				return r_RGetTribeLingzhuLevel_Int32;
			}
		}

		/// <summary>
		/// Int32 GetTribeQingbaoLevel(Int32)
		/// </summary>
		protected RMethod r_RGetTribeQingbaoLevel_Int32;
		public virtual RMethod RGetTribeQingbaoLevel_Int32
		{
			get
			{
				if(r_RGetTribeQingbaoLevel_Int32 == null)
				{
					r_RGetTribeQingbaoLevel_Int32 = new(this, "GetTribeQingbaoLevel", 0, typeof(System.Int32));
					r_RGetTribeQingbaoLevel_Int32.SetBelong(this.instance);
				}
				return r_RGetTribeQingbaoLevel_Int32;
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


        public RTaskEffectTemplate() : base("TaskEffectTemplate")
        {
        }

        public RTaskEffectTemplate(System.Object instance) : base("TaskEffectTemplate")
		{
            SetInstance(instance);
		}

        public RTaskEffectTemplate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTaskEffectTemplate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadTaskEffectConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadTaskEffectConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetBeadEffectNameString(System.Int32  @id, ref System.Single  @h)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @h};
            var ___result = RGetBeadEffectNameString_Int32_Ref_Single.Invoke(___genericsType, ___parameters);
			h = (System.Single)___parameters[1];

            return (System.String)___result;
        }


        public virtual System.String GetSelectInfoEffectNameString(System.Int32  @id, ref System.Single  @h)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @h};
            var ___result = RGetSelectInfoEffectNameString_Int32_Ref_Single.Invoke(___genericsType, ___parameters);
			h = (System.Single)___parameters[1];

            return (System.String)___result;
        }


        public virtual System.Int32 GetTribeLingzhuLevel(System.Int32  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RGetTribeLingzhuLevel_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetTribeQingbaoLevel(System.Int32  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RGetTribeQingbaoLevel_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
