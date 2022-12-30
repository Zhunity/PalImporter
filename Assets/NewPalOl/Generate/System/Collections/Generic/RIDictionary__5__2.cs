using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.IDictionary`2
	/// </summary>
    public partial class RIDictionary<TKey, TValue> : RMember //
    {

		/// <summary>
		/// TValue Item [TKey]
		/// </summary>
		protected RProperty r_Item_TKey;
		public virtual RProperty RItem_TKey
		{
			get
			{
				if(r_Item_TKey == null)
				{
					r_Item_TKey = new(this, "Item", -1, Type.MakeGenericMethodParameter(0));
					r_Item_TKey.SetBelong(this.instance);
				}
				return r_Item_TKey;
			}
		}

		/// <summary>
		/// System.Collections.Generic.ICollection`1[TKey] Keys
		/// </summary>
		protected RSystem.RCollections.RGeneric.RICollection<RProperty> r_Keys;
		public virtual RSystem.RCollections.RGeneric.RICollection<RProperty> RKeys
		{
			get
			{
				if(r_Keys == null)
				{
					r_Keys = new(this, "Keys", -1);
					r_Keys.SetBelong(this.instance);
				}
				return r_Keys;
			}
		}

		/// <summary>
		/// System.Collections.Generic.ICollection`1[TValue] Values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RICollection<RProperty> r_Values;
		public virtual RSystem.RCollections.RGeneric.RICollection<RProperty> RValues
		{
			get
			{
				if(r_Values == null)
				{
					r_Values = new(this, "Values", -1);
					r_Values.SetBelong(this.instance);
				}
				return r_Values;
			}
		}

		/// <summary>
		/// Boolean ContainsKey(TKey)
		/// </summary>
		protected RMethod r_RContainsKey_TKey;
		public virtual RMethod RContainsKey_TKey
		{
			get
			{
				if(r_RContainsKey_TKey == null)
				{
					r_RContainsKey_TKey = new(this, "ContainsKey", 0, Type.MakeGenericMethodParameter(0));
					r_RContainsKey_TKey.SetBelong(this.instance);
				}
				return r_RContainsKey_TKey;
			}
		}

		/// <summary>
		/// Void Add(TKey, TValue)
		/// </summary>
		protected RMethod r_RAdd_TKey_TValue;
		public virtual RMethod RAdd_TKey_TValue
		{
			get
			{
				if(r_RAdd_TKey_TValue == null)
				{
					r_RAdd_TKey_TValue = new(this, "Add", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1));
					r_RAdd_TKey_TValue.SetBelong(this.instance);
				}
				return r_RAdd_TKey_TValue;
			}
		}

		/// <summary>
		/// Boolean Remove(TKey)
		/// </summary>
		protected RMethod r_RRemove_TKey;
		public virtual RMethod RRemove_TKey
		{
			get
			{
				if(r_RRemove_TKey == null)
				{
					r_RRemove_TKey = new(this, "Remove", 0, Type.MakeGenericMethodParameter(0));
					r_RRemove_TKey.SetBelong(this.instance);
				}
				return r_RRemove_TKey;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(TKey, TValue ByRef)
		/// </summary>
		protected RMethod r_RTryGetValue_TKey_Out_TValue;
		public virtual RMethod RTryGetValue_TKey_Out_TValue
		{
			get
			{
				if(r_RTryGetValue_TKey_Out_TValue == null)
				{
					r_RTryGetValue_TKey_Out_TValue = new(this, "TryGetValue", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1).MakeByRefType());
					r_RTryGetValue_TKey_Out_TValue.SetBelong(this.instance);
				}
				return r_RTryGetValue_TKey_Out_TValue;
			}
		}


        public RIDictionary() : base("System.Collections.Generic.IDictionary`2")
        {
        }

        public RIDictionary(System.Object instance) : base("System.Collections.Generic.IDictionary`2")
		{
            SetInstance(instance);
		}

        public RIDictionary(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIDictionary(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean ContainsKey(TKey  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RContainsKey_TKey.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Add(TKey  @key, TValue  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RAdd_TKey_TValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Remove(TKey  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RRemove_TKey.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(TKey  @key, out TValue  @value)
        {
			value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RTryGetValue_TKey_Out_TValue.Invoke(___genericsType, ___parameters);
			value = (TValue)___parameters[1];

            return (System.Boolean)___result;
        }


    }
}
