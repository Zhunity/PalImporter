using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SerializableDictionary`2
	/// </summary>
    public partial class RSerializableDictionary<T1, T2> : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[T1,T2] _map
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r__map;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> R_map
		{
			get
			{
				if(r__map == null)
				{
					r__map = new(this, "_map");
					r__map.SetBelong(this.instance);
				}
				return r__map;
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
		/// System.Collections.Generic.Dictionary`2[T1,T2] DictionaryMap
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RProperty, RProperty> r_DictionaryMap;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RProperty, RProperty> RDictionaryMap
		{
			get
			{
				if(r_DictionaryMap == null)
				{
					r_DictionaryMap = new(this, "DictionaryMap", -1);
					r_DictionaryMap.SetBelong(this.instance);
				}
				return r_DictionaryMap;
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


        public RSerializableDictionary() : base("SerializableDictionary`2")
        {
        }

        public RSerializableDictionary(System.Object instance) : base("SerializableDictionary`2")
		{
            SetInstance(instance);
		}

        public RSerializableDictionary(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSerializableDictionary(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Add(T1  @key, T2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RAdd_T1_T2.Invoke(___genericsType, ___parameters);

            
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
