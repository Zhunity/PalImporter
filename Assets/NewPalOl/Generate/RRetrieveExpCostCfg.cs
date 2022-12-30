using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// RetrieveExpCostCfg
	/// </summary>
    public partial class RRetrieveExpCostCfg : RMember //
    {

		/// <summary>
		/// System.Int32 typeID
		/// </summary>
		protected RField r_typeID;
		public virtual RField RtypeID
		{
			get
			{
				if(r_typeID == null)
				{
					r_typeID = new(this, "typeID");
					r_typeID.SetBelong(this.instance);
				}
				return r_typeID;
			}
		}

		/// <summary>
		/// System.Int32 textID
		/// </summary>
		protected RField r_textID;
		public virtual RField RtextID
		{
			get
			{
				if(r_textID == null)
				{
					r_textID = new(this, "textID");
					r_textID.SetBelong(this.instance);
				}
				return r_textID;
			}
		}

		/// <summary>
		/// System.String iconName
		/// </summary>
		protected RField r_iconName;
		public virtual RField RiconName
		{
			get
			{
				if(r_iconName == null)
				{
					r_iconName = new(this, "iconName");
					r_iconName.SetBelong(this.instance);
				}
				return r_iconName;
			}
		}

		/// <summary>
		/// System.String attr1
		/// </summary>
		protected RField r_attr1;
		public virtual RField Rattr1
		{
			get
			{
				if(r_attr1 == null)
				{
					r_attr1 = new(this, "attr1");
					r_attr1.SetBelong(this.instance);
				}
				return r_attr1;
			}
		}

		/// <summary>
		/// System.String attr2
		/// </summary>
		protected RField r_attr2;
		public virtual RField Rattr2
		{
			get
			{
				if(r_attr2 == null)
				{
					r_attr2 = new(this, "attr2");
					r_attr2.SetBelong(this.instance);
				}
				return r_attr2;
			}
		}

		/// <summary>
		/// System.String attr3
		/// </summary>
		protected RField r_attr3;
		public virtual RField Rattr3
		{
			get
			{
				if(r_attr3 == null)
				{
					r_attr3 = new(this, "attr3");
					r_attr3.SetBelong(this.instance);
				}
				return r_attr3;
			}
		}

		/// <summary>
		/// System.String attr4
		/// </summary>
		protected RField r_attr4;
		public virtual RField Rattr4
		{
			get
			{
				if(r_attr4 == null)
				{
					r_attr4 = new(this, "attr4");
					r_attr4.SetBelong(this.instance);
				}
				return r_attr4;
			}
		}

		/// <summary>
		/// System.Int32 index
		/// </summary>
		protected RField r_index;
		public virtual RField Rindex
		{
			get
			{
				if(r_index == null)
				{
					r_index = new(this, "index");
					r_index.SetBelong(this.instance);
				}
				return r_index;
			}
		}

		/// <summary>
		/// System.String GetAttrValue(Int32)
		/// </summary>
		protected RMethod r_RGetAttrValue_Int32;
		public virtual RMethod RGetAttrValue_Int32
		{
			get
			{
				if(r_RGetAttrValue_Int32 == null)
				{
					r_RGetAttrValue_Int32 = new(this, "GetAttrValue", 0, typeof(System.Int32));
					r_RGetAttrValue_Int32.SetBelong(this.instance);
				}
				return r_RGetAttrValue_Int32;
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


        public RRetrieveExpCostCfg() : base("RetrieveExpCostCfg")
        {
        }

        public RRetrieveExpCostCfg(System.Object instance) : base("RetrieveExpCostCfg")
		{
            SetInstance(instance);
		}

        public RRetrieveExpCostCfg(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRetrieveExpCostCfg(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String GetAttrValue(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetAttrValue_Int32.Invoke(___genericsType, ___parameters);

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
