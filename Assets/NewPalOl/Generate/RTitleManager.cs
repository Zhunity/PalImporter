using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// TitleManager
	/// </summary>
    public partial class RTitleManager : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,TITLE_INFO] m_TitleDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RTITLE_INFO> r_m_TitleDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RTITLE_INFO> Rm_TitleDict
		{
			get
			{
				if(r_m_TitleDict == null)
				{
					r_m_TitleDict = new(this, "m_TitleDict");
					r_m_TitleDict.SetBelong(this.instance);
				}
				return r_m_TitleDict;
			}
		}

		/// <summary>
		/// System.Int32 FAMILY_POST_IDOFFSET
		/// </summary>
		protected RField r_FAMILY_POST_IDOFFSET;
		public virtual RField RFAMILY_POST_IDOFFSET
		{
			get
			{
				if(r_FAMILY_POST_IDOFFSET == null)
				{
					r_FAMILY_POST_IDOFFSET = new(this, "FAMILY_POST_IDOFFSET");
					r_FAMILY_POST_IDOFFSET.SetBelong(this.instance);
				}
				return r_FAMILY_POST_IDOFFSET;
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
		/// Void OnLoadTitleConfig(System.Object)
		/// </summary>
		protected RMethod r_ROnLoadTitleConfig_Object;
		public virtual RMethod ROnLoadTitleConfig_Object
		{
			get
			{
				if(r_ROnLoadTitleConfig_Object == null)
				{
					r_ROnLoadTitleConfig_Object = new(this, "OnLoadTitleConfig", 0, typeof(System.Object));
					r_ROnLoadTitleConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadTitleConfig_Object;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,TITLE_INFO] GetTitleDict()
		/// </summary>
		protected RMethod r_RGetTitleDict;
		public virtual RMethod RGetTitleDict
		{
			get
			{
				if(r_RGetTitleDict == null)
				{
					r_RGetTitleDict = new(this, "GetTitleDict", 0);
					r_RGetTitleDict.SetBelong(this.instance);
				}
				return r_RGetTitleDict;
			}
		}

		/// <summary>
		/// TITLE_INFO GetTitleInfo(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetTitleInfo_ID;
		public virtual RMethod RGetTitleInfo_ID
		{
			get
			{
				if(r_RGetTitleInfo_ID == null)
				{
					r_RGetTitleInfo_ID = new(this, "GetTitleInfo", 0, typeof(GameDefineType.ID));
					r_RGetTitleInfo_ID.SetBelong(this.instance);
				}
				return r_RGetTitleInfo_ID;
			}
		}

		/// <summary>
		/// System.String GetPostName(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetPostName_ID;
		public virtual RMethod RGetPostName_ID
		{
			get
			{
				if(r_RGetPostName_ID == null)
				{
					r_RGetPostName_ID = new(this, "GetPostName", 0, typeof(GameDefineType.ID));
					r_RGetPostName_ID.SetBelong(this.instance);
				}
				return r_RGetPostName_ID;
			}
		}

		/// <summary>
		/// GameDefineType.ID GetMyFamilyPost()
		/// </summary>
		protected RMethod r_RGetMyFamilyPost;
		public virtual RMethod RGetMyFamilyPost
		{
			get
			{
				if(r_RGetMyFamilyPost == null)
				{
					r_RGetMyFamilyPost = new(this, "GetMyFamilyPost", 0);
					r_RGetMyFamilyPost.SetBelong(this.instance);
				}
				return r_RGetMyFamilyPost;
			}
		}

		/// <summary>
		/// Void UpdateCurrTitle(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_RUpdateCurrTitle_ID_String;
		public virtual RMethod RUpdateCurrTitle_ID_String
		{
			get
			{
				if(r_RUpdateCurrTitle_ID_String == null)
				{
					r_RUpdateCurrTitle_ID_String = new(this, "UpdateCurrTitle", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_RUpdateCurrTitle_ID_String.SetBelong(this.instance);
				}
				return r_RUpdateCurrTitle_ID_String;
			}
		}

		/// <summary>
		/// Void OnTitleinfo(System.Object, System.Object)
		/// </summary>
		protected RMethod r_ROnTitleinfo_Object_Object;
		public virtual RMethod ROnTitleinfo_Object_Object
		{
			get
			{
				if(r_ROnTitleinfo_Object_Object == null)
				{
					r_ROnTitleinfo_Object_Object = new(this, "OnTitleinfo", 0, typeof(System.Object), typeof(System.Object));
					r_ROnTitleinfo_Object_Object.SetBelong(this.instance);
				}
				return r_ROnTitleinfo_Object_Object;
			}
		}

		/// <summary>
		/// Void SendSetTitle(System.String)
		/// </summary>
		protected RMethod r_RSendSetTitle_String;
		public virtual RMethod RSendSetTitle_String
		{
			get
			{
				if(r_RSendSetTitle_String == null)
				{
					r_RSendSetTitle_String = new(this, "SendSetTitle", 0, typeof(System.String));
					r_RSendSetTitle_String.SetBelong(this.instance);
				}
				return r_RSendSetTitle_String;
			}
		}

		/// <summary>
		/// Void SendQueryTitle(Int32)
		/// </summary>
		protected RMethod r_RSendQueryTitle_Int32;
		public virtual RMethod RSendQueryTitle_Int32
		{
			get
			{
				if(r_RSendQueryTitle_Int32 == null)
				{
					r_RSendQueryTitle_Int32 = new(this, "SendQueryTitle", 0, typeof(System.Int32));
					r_RSendQueryTitle_Int32.SetBelong(this.instance);
				}
				return r_RSendQueryTitle_Int32;
			}
		}

		/// <summary>
		/// Void OnTitleQuery(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTitleQuery_Object___0__Isb;
		public virtual RMethod ROnTitleQuery_Object___0__Isb
		{
			get
			{
				if(r_ROnTitleQuery_Object___0__Isb == null)
				{
					r_ROnTitleQuery_Object___0__Isb = new(this, "OnTitleQuery", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTitleQuery_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTitleQuery_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTitleProgressUpdate(#Pfb.#5sb)
		/// </summary>
		protected RMethod r_ROnTitleProgressUpdate___0__5sb;
		public virtual RMethod ROnTitleProgressUpdate___0__5sb
		{
			get
			{
				if(r_ROnTitleProgressUpdate___0__5sb == null)
				{
					r_ROnTitleProgressUpdate___0__5sb = new(this, "OnTitleProgressUpdate", 0,  ReleactionUtils.GetType("#Pfb.#5sb"));
					r_ROnTitleProgressUpdate___0__5sb.SetBelong(this.instance);
				}
				return r_ROnTitleProgressUpdate___0__5sb;
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


        public RTitleManager() : base("TitleManager")
        {
        }

        public RTitleManager(System.Object instance) : base("TitleManager")
		{
            SetInstance(instance);
		}

        public RTitleManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTitleManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadTitleConfig(System.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadTitleConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.Dictionary<GameDefineType.ID, TITLE_INFO> GetTitleDict()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTitleDict.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<GameDefineType.ID, TITLE_INFO>)___result;
        }


        public virtual TITLE_INFO GetTitleInfo(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetTitleInfo_ID.Invoke(___genericsType, ___parameters);

            return (TITLE_INFO)___result;
        }


        public virtual System.String GetPostName(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetPostName_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual GameDefineType.ID GetMyFamilyPost()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMyFamilyPost.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual void UpdateCurrTitle(GameDefineType.ID  @playerid, System.String  @idstr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@playerid, @idstr};
            var ___result = RUpdateCurrTitle_ID_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnTitleinfo(System.Object  @oldvalue, System.Object  @newvalue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldvalue, @newvalue};
            var ___result = ROnTitleinfo_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendSetTitle(System.String  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSendSetTitle_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendQueryTitle(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSendQueryTitle_Int32.Invoke(___genericsType, ___parameters);

            
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
