using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// CareerDesTemplate
	/// </summary>
    public partial class RCareerDesTemplate : RMember //
    {

		/// <summary>
		/// KeyValueContent m_kCareerDesContent
		/// </summary>
		protected RKeyValueContent r_m_kCareerDesContent;
		public virtual RKeyValueContent Rm_kCareerDesContent
		{
			get
			{
				if(r_m_kCareerDesContent == null)
				{
					r_m_kCareerDesContent = new(this, "m_kCareerDesContent");
					r_m_kCareerDesContent.SetBelong(this.instance);
				}
				return r_m_kCareerDesContent;
			}
		}

		/// <summary>
		/// System.String DES_ID
		/// </summary>
		protected static RField r_DES_ID;
		public static RField RDES_ID
		{
			get
			{
				if(r_DES_ID == null)
				{
					r_DES_ID = new( ReleactionUtils.GetType("CareerDesTemplate"), "DES_ID");
					r_DES_ID.SetBelong(null);
				}
				return r_DES_ID;
			}
		}

		/// <summary>
		/// System.String DESCRIPTION_INFO
		/// </summary>
		protected static RField r_DESCRIPTION_INFO;
		public static RField RDESCRIPTION_INFO
		{
			get
			{
				if(r_DESCRIPTION_INFO == null)
				{
					r_DESCRIPTION_INFO = new( ReleactionUtils.GetType("CareerDesTemplate"), "DESCRIPTION_INFO");
					r_DESCRIPTION_INFO.SetBelong(null);
				}
				return r_DESCRIPTION_INFO;
			}
		}

		/// <summary>
		/// Boolean IsReadyToUse
		/// </summary>
		protected RProperty r_IsReadyToUse;
		public virtual RProperty RIsReadyToUse
		{
			get
			{
				if(r_IsReadyToUse == null)
				{
					r_IsReadyToUse = new(this, "IsReadyToUse", -1);
					r_IsReadyToUse.SetBelong(this.instance);
				}
				return r_IsReadyToUse;
			}
		}

		/// <summary>
		/// Void OnLoadCareerDesConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadCareerDesConfig_Object;
		public virtual RMethod ROnLoadCareerDesConfig_Object
		{
			get
			{
				if(r_ROnLoadCareerDesConfig_Object == null)
				{
					r_ROnLoadCareerDesConfig_Object = new(this, "OnLoadCareerDesConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadCareerDesConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadCareerDesConfig_Object;
			}
		}

		/// <summary>
		/// System.String GetCareerDesContent(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetCareerDesContent_ID;
		public virtual RMethod RGetCareerDesContent_ID
		{
			get
			{
				if(r_RGetCareerDesContent_ID == null)
				{
					r_RGetCareerDesContent_ID = new(this, "GetCareerDesContent", 0, typeof(GameDefineType.ID));
					r_RGetCareerDesContent_ID.SetBelong(this.instance);
				}
				return r_RGetCareerDesContent_ID;
			}
		}

		/// <summary>
		/// System.String GetCareerDesValue(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_RGetCareerDesValue_ID_String;
		public virtual RMethod RGetCareerDesValue_ID_String
		{
			get
			{
				if(r_RGetCareerDesValue_ID_String == null)
				{
					r_RGetCareerDesValue_ID_String = new(this, "GetCareerDesValue", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_RGetCareerDesValue_ID_String.SetBelong(this.instance);
				}
				return r_RGetCareerDesValue_ID_String;
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


        public RCareerDesTemplate() : base("CareerDesTemplate")
        {
        }

        public RCareerDesTemplate(System.Object instance) : base("CareerDesTemplate")
		{
            SetInstance(instance);
		}

        public RCareerDesTemplate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCareerDesTemplate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadCareerDesConfig(UnityEngine.Object  @fileAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileAsset};
            var ___result = ROnLoadCareerDesConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetCareerDesContent(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetCareerDesContent_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetCareerDesValue(GameDefineType.ID  @id, System.String  @proName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @proName};
            var ___result = RGetCareerDesValue_ID_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
