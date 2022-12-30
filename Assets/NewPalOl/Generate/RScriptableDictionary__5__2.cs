using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// ScriptableDictionary`2
	/// </summary>
    public partial class RScriptableDictionary<T1, T2> : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[T1,T2] _tab
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r__tab;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> R_tab
		{
			get
			{
				if(r__tab == null)
				{
					r__tab = new(this, "_tab");
					r__tab.SetBelong(this.instance);
				}
				return r__tab;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[T1] keys
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_keys;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rkeys
		{
			get
			{
				if(r_keys == null)
				{
					r_keys = new(this, "keys");
					r_keys.SetBelong(this.instance);
				}
				return r_keys;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[T2] values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_values;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rvalues
		{
			get
			{
				if(r_values == null)
				{
					r_values = new(this, "values");
					r_values.SetBelong(this.instance);
				}
				return r_values;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[T1,T2] Tab
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RProperty, RProperty> r_Tab;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RProperty, RProperty> RTab
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
		/// Void Add(T1, T2)
		/// </summary>
		protected RMethod r_RAdd_T1_T2;
		public virtual RMethod RAdd_T1_T2
		{
			get
			{
				if(r_RAdd_T1_T2 == null)
				{
					r_RAdd_T1_T2 = new(this, "Add", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1));
					r_RAdd_T1_T2.SetBelong(this.instance);
				}
				return r_RAdd_T1_T2;
			}
		}

		/// <summary>
		/// Void UpdateValue(T1, T2)
		/// </summary>
		protected RMethod r_RUpdateValue_T1_T2;
		public virtual RMethod RUpdateValue_T1_T2
		{
			get
			{
				if(r_RUpdateValue_T1_T2 == null)
				{
					r_RUpdateValue_T1_T2 = new(this, "UpdateValue", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1));
					r_RUpdateValue_T1_T2.SetBelong(this.instance);
				}
				return r_RUpdateValue_T1_T2;
			}
		}

		/// <summary>
		/// Boolean Remove(T1)
		/// </summary>
		protected RMethod r_RRemove_T1;
		public virtual RMethod RRemove_T1
		{
			get
			{
				if(r_RRemove_T1 == null)
				{
					r_RRemove_T1 = new(this, "Remove", 0, Type.MakeGenericMethodParameter(0));
					r_RRemove_T1.SetBelong(this.instance);
				}
				return r_RRemove_T1;
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


        public RScriptableDictionary() : base("ScriptableDictionary`2")
        {
        }

        public RScriptableDictionary(System.Object instance) : base("ScriptableDictionary`2")
		{
            SetInstance(instance);
		}

        public RScriptableDictionary(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RScriptableDictionary(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Add(T1  @key, T2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RAdd_T1_T2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateValue(T1  @key, T2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RUpdateValue_T1_T2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Remove(T1  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RRemove_T1.Invoke(___genericsType, ___parameters);

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
