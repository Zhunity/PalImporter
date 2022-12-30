using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// WebLeaveManager
	/// </summary>
    public partial class RWebLeaveManager : RMember //
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
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Int32] m_TaskLeftCount
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r_m_TaskLeftCount;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> Rm_TaskLeftCount
		{
			get
			{
				if(r_m_TaskLeftCount == null)
				{
					r_m_TaskLeftCount = new(this, "m_TaskLeftCount");
					r_m_TaskLeftCount.SetBelong(this.instance);
				}
				return r_m_TaskLeftCount;
			}
		}

		/// <summary>
		/// System.String LeaveStr
		/// </summary>
		protected RField r_LeaveStr;
		public virtual RField RLeaveStr
		{
			get
			{
				if(r_LeaveStr == null)
				{
					r_LeaveStr = new(this, "LeaveStr");
					r_LeaveStr.SetBelong(this.instance);
				}
				return r_LeaveStr;
			}
		}

		/// <summary>
		/// System.Comparison`1[System.Collections.Generic.KeyValuePair`2[System.Int32,System.String]] <>f__am$cache3
		/// </summary>
		protected static RSystem.RComparison<RSystem.RCollections.RGeneric.RKeyValuePair<RField, RField>> r___2____4__f__am__9__cache3;
		public static RSystem.RComparison<RSystem.RCollections.RGeneric.RKeyValuePair<RField, RField>> R__2____4__f__am__9__cache3
		{
			get
			{
				if(r___2____4__f__am__9__cache3 == null)
				{
					r___2____4__f__am__9__cache3 = new( ReleactionUtils.GetType("WebLeaveManager"), "<>f__am$cache3");
					r___2____4__f__am__9__cache3.SetBelong(null);
				}
				return r___2____4__f__am__9__cache3;
			}
		}

		/// <summary>
		/// Void Initial()
		/// </summary>
		protected RMethod r_RInitial;
		public virtual RMethod RInitial
		{
			get
			{
				if(r_RInitial == null)
				{
					r_RInitial = new(this, "Initial", 0);
					r_RInitial.SetBelong(this.instance);
				}
				return r_RInitial;
			}
		}

		/// <summary>
		/// Void OnLoadWebLeaveConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadWebLeaveConfig_Object;
		public virtual RMethod ROnLoadWebLeaveConfig_Object
		{
			get
			{
				if(r_ROnLoadWebLeaveConfig_Object == null)
				{
					r_ROnLoadWebLeaveConfig_Object = new(this, "OnLoadWebLeaveConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadWebLeaveConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadWebLeaveConfig_Object;
			}
		}

		/// <summary>
		/// Void InitLeaveNotice(System.String)
		/// </summary>
		protected RMethod r_RInitLeaveNotice_String;
		public virtual RMethod RInitLeaveNotice_String
		{
			get
			{
				if(r_RInitLeaveNotice_String == null)
				{
					r_RInitLeaveNotice_String = new(this, "InitLeaveNotice", 0, typeof(System.String));
					r_RInitLeaveNotice_String.SetBelong(this.instance);
				}
				return r_RInitLeaveNotice_String;
			}
		}

		/// <summary>
		/// Void UpdateWebLeaveNotice(Int32, Int32)
		/// </summary>
		protected RMethod r_RUpdateWebLeaveNotice_Int32_Int32;
		public virtual RMethod RUpdateWebLeaveNotice_Int32_Int32
		{
			get
			{
				if(r_RUpdateWebLeaveNotice_Int32_Int32 == null)
				{
					r_RUpdateWebLeaveNotice_Int32_Int32 = new(this, "UpdateWebLeaveNotice", 0, typeof(System.Int32), typeof(System.Int32));
					r_RUpdateWebLeaveNotice_Int32_Int32.SetBelong(this.instance);
				}
				return r_RUpdateWebLeaveNotice_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String GetNoticeString()
		/// </summary>
		protected RMethod r_RGetNoticeString;
		public virtual RMethod RGetNoticeString
		{
			get
			{
				if(r_RGetNoticeString == null)
				{
					r_RGetNoticeString = new(this, "GetNoticeString", 0);
					r_RGetNoticeString.SetBelong(this.instance);
				}
				return r_RGetNoticeString;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetNoticeList()
		/// </summary>
		protected RMethod r_RGetNoticeList;
		public virtual RMethod RGetNoticeList
		{
			get
			{
				if(r_RGetNoticeList == null)
				{
					r_RGetNoticeList = new(this, "GetNoticeList", 0);
					r_RGetNoticeList.SetBelong(this.instance);
				}
				return r_RGetNoticeList;
			}
		}

		/// <summary>
		/// Void OnLeaveNotice(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnLeaveNotice_Object___0__Isb;
		public virtual RMethod ROnLeaveNotice_Object___0__Isb
		{
			get
			{
				if(r_ROnLeaveNotice_Object___0__Isb == null)
				{
					r_ROnLeaveNotice_Object___0__Isb = new(this, "OnLeaveNotice", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnLeaveNotice_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnLeaveNotice_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnLeaveNoticeQuery(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnLeaveNoticeQuery_Object___0__Isb;
		public virtual RMethod ROnLeaveNoticeQuery_Object___0__Isb
		{
			get
			{
				if(r_ROnLeaveNoticeQuery_Object___0__Isb == null)
				{
					r_ROnLeaveNoticeQuery_Object___0__Isb = new(this, "OnLeaveNoticeQuery", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnLeaveNoticeQuery_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnLeaveNoticeQuery_Object___0__Isb;
			}
		}

		/// <summary>
		/// Int32 <GetNoticeList>m__266(System.Collections.Generic.KeyValuePair`2[System.Int32,System.String], System.Collections.Generic.KeyValuePair`2[System.Int32,System.String])
		/// </summary>
		protected static RMethod r_R__2__GetNoticeList__4__m__266_KeyValuePair_d_Int32_String_p__KeyValuePair_d_Int32_String_p_;
		public static RMethod R__2__GetNoticeList__4__m__266_KeyValuePair_d_Int32_String_p__KeyValuePair_d_Int32_String_p_
		{
			get
			{
				if(r_R__2__GetNoticeList__4__m__266_KeyValuePair_d_Int32_String_p__KeyValuePair_d_Int32_String_p_ == null)
				{
					r_R__2__GetNoticeList__4__m__266_KeyValuePair_d_Int32_String_p__KeyValuePair_d_Int32_String_p_ = new( ReleactionUtils.GetType("WebLeaveManager"), "<GetNoticeList>m__266", 0, typeof(System.Collections.Generic.KeyValuePair<, >).MakeGenericType(typeof(System.Int32), typeof(System.String)), typeof(System.Collections.Generic.KeyValuePair<, >).MakeGenericType(typeof(System.Int32), typeof(System.String)));
					r_R__2__GetNoticeList__4__m__266_KeyValuePair_d_Int32_String_p__KeyValuePair_d_Int32_String_p_.SetBelong(null);
				}
				return r_R__2__GetNoticeList__4__m__266_KeyValuePair_d_Int32_String_p__KeyValuePair_d_Int32_String_p_;
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


        public RWebLeaveManager() : base("WebLeaveManager")
        {
        }

        public RWebLeaveManager(System.Object instance) : base("WebLeaveManager")
		{
            SetInstance(instance);
		}

        public RWebLeaveManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWebLeaveManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadWebLeaveConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadWebLeaveConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitLeaveNotice(System.String  @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info};
            var ___result = RInitLeaveNotice_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWebLeaveNotice(System.Int32  @type, System.Int32  @num)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @num};
            var ___result = RUpdateWebLeaveNotice_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetNoticeString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNoticeString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Collections.Generic.List<System.String> GetNoticeList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNoticeList.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.String>)___result;
        }




        public static System.Int32 __2__GetNoticeList__4__m__266(System.Collections.Generic.KeyValuePair<System.Int32, System.String>  @a, System.Collections.Generic.KeyValuePair<System.Int32, System.String>  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = R__2__GetNoticeList__4__m__266_KeyValuePair_d_Int32_String_p__KeyValuePair_d_Int32_String_p_.Invoke(___genericsType, ___parameters);

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
