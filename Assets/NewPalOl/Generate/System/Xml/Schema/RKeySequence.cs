using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.KeySequence
	/// </summary>
    public partial class RKeySequence : RMember //
    {

		/// <summary>
		/// System.Xml.Schema.TypedObject[] ks
		/// </summary>
		protected RFieldArray<RSystem.RXml.RSchema.RTypedObject> r_ks;
		public virtual RFieldArray<RSystem.RXml.RSchema.RTypedObject> Rks
		{
			get
			{
				if(r_ks == null)
				{
					r_ks = new(this, "ks");
					r_ks.SetBelong(this.instance);
				}
				return r_ks;
			}
		}

		/// <summary>
		/// System.Int32 dim
		/// </summary>
		protected RField r_dim;
		public virtual RField Rdim
		{
			get
			{
				if(r_dim == null)
				{
					r_dim = new(this, "dim");
					r_dim.SetBelong(this.instance);
				}
				return r_dim;
			}
		}

		/// <summary>
		/// System.Int32 hashcode
		/// </summary>
		protected RField r_hashcode;
		public virtual RField Rhashcode
		{
			get
			{
				if(r_hashcode == null)
				{
					r_hashcode = new(this, "hashcode");
					r_hashcode.SetBelong(this.instance);
				}
				return r_hashcode;
			}
		}

		/// <summary>
		/// System.Int32 posline
		/// </summary>
		protected RField r_posline;
		public virtual RField Rposline
		{
			get
			{
				if(r_posline == null)
				{
					r_posline = new(this, "posline");
					r_posline.SetBelong(this.instance);
				}
				return r_posline;
			}
		}

		/// <summary>
		/// System.Int32 poscol
		/// </summary>
		protected RField r_poscol;
		public virtual RField Rposcol
		{
			get
			{
				if(r_poscol == null)
				{
					r_poscol = new(this, "poscol");
					r_poscol.SetBelong(this.instance);
				}
				return r_poscol;
			}
		}

		/// <summary>
		/// Int32 PosLine
		/// </summary>
		protected RProperty r_PosLine;
		public virtual RProperty RPosLine
		{
			get
			{
				if(r_PosLine == null)
				{
					r_PosLine = new(this, "PosLine", -1);
					r_PosLine.SetBelong(this.instance);
				}
				return r_PosLine;
			}
		}

		/// <summary>
		/// Int32 PosCol
		/// </summary>
		protected RProperty r_PosCol;
		public virtual RProperty RPosCol
		{
			get
			{
				if(r_PosCol == null)
				{
					r_PosCol = new(this, "PosCol", -1);
					r_PosCol.SetBelong(this.instance);
				}
				return r_PosCol;
			}
		}

		/// <summary>
		/// System.Object Item [Int32]
		/// </summary>
		protected RSystem.RObject r_Item_Int32;
		public virtual RSystem.RObject RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// Boolean IsQualified()
		/// </summary>
		protected RMethod r_RIsQualified;
		public virtual RMethod RIsQualified
		{
			get
			{
				if(r_RIsQualified == null)
				{
					r_RIsQualified = new(this, "IsQualified", 0);
					r_RIsQualified.SetBelong(this.instance);
				}
				return r_RIsQualified;
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


        public RKeySequence() : base("System.Xml.Schema.KeySequence")
        {
        }

        public RKeySequence(System.Object instance) : base("System.Xml.Schema.KeySequence")
		{
            SetInstance(instance);
		}

        public RKeySequence(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RKeySequence(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsQualified()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsQualified.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
