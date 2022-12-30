using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// ConfigDic
	/// </summary>
    public partial class RConfigDic : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.Object] Tab
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RProperty, RUnityEngine.RObject> r_Tab;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RProperty, RUnityEngine.RObject> RTab
		{
			get
			{
				if(r_Tab == null)
				{
					r_Tab = new(this, "Tab", -1);
					r_Tab.SetBelong(this.instance);
				}
				return r_Tab;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Void Add(System.String, UnityEngine.Object)
		/// </summary>
		protected RMethod r_RAdd_String_Object;
		public virtual RMethod RAdd_String_Object
		{
			get
			{
				if(r_RAdd_String_Object == null)
				{
					r_RAdd_String_Object = new(this, "Add", 0, typeof(System.String), typeof(UnityEngine.Object));
					r_RAdd_String_Object.SetBelong(this.instance);
				}
				return r_RAdd_String_Object;
			}
		}

		/// <summary>
		/// Void UpdateValue(System.String, UnityEngine.Object)
		/// </summary>
		protected RMethod r_RUpdateValue_String_Object;
		public virtual RMethod RUpdateValue_String_Object
		{
			get
			{
				if(r_RUpdateValue_String_Object == null)
				{
					r_RUpdateValue_String_Object = new(this, "UpdateValue", 0, typeof(System.String), typeof(UnityEngine.Object));
					r_RUpdateValue_String_Object.SetBelong(this.instance);
				}
				return r_RUpdateValue_String_Object;
			}
		}

		/// <summary>
		/// Boolean Remove(System.String)
		/// </summary>
		protected RMethod r_RRemove_String;
		public virtual RMethod RRemove_String
		{
			get
			{
				if(r_RRemove_String == null)
				{
					r_RRemove_String = new(this, "Remove", 0, typeof(System.String));
					r_RRemove_String.SetBelong(this.instance);
				}
				return r_RRemove_String;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_RSetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_RSetDirty == null)
				{
					r_RSetDirty = new(this, "SetDirty", 0);
					r_RSetDirty.SetBelong(this.instance);
				}
				return r_RSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
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


        public RConfigDic() : base("ConfigDic")
        {
        }

        public RConfigDic(System.Object instance) : base("ConfigDic")
		{
            SetInstance(instance);
		}

        public RConfigDic(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RConfigDic(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Add(System.String  @key, UnityEngine.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RAdd_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateValue(System.String  @key, UnityEngine.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RUpdateValue_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Remove(System.String  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RRemove_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
