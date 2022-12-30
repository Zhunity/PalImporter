using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.XmlSchemaCollectionEnumerator
	/// </summary>
    public partial class RXmlSchemaCollectionEnumerator : RMember //
    {

		/// <summary>
		/// System.Collections.IDictionaryEnumerator enumerator
		/// </summary>
		protected RSystem.RCollections.RIDictionaryEnumerator r_enumerator;
		public virtual RSystem.RCollections.RIDictionaryEnumerator Renumerator
		{
			get
			{
				if(r_enumerator == null)
				{
					r_enumerator = new(this, "enumerator");
					r_enumerator.SetBelong(this.instance);
				}
				return r_enumerator;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IEnumerator.Current
		/// </summary>
		protected RSystem.RObject r_RSystem__1__Collections__1__IEnumerator__1__get_Current;
		public virtual RSystem.RObject RSystem__1__Collections__1__IEnumerator__1__get_Current
		{
			get
			{
				if(r_RSystem__1__Collections__1__IEnumerator__1__get_Current == null)
				{
					r_RSystem__1__Collections__1__IEnumerator__1__get_Current = new(this, "System.Collections.IEnumerator.Current", -1);
					r_RSystem__1__Collections__1__IEnumerator__1__get_Current.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IEnumerator__1__get_Current;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchema Current
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchema r_Current;
		public virtual RSystem.RXml.RSchema.RXmlSchema RCurrent
		{
			get
			{
				if(r_Current == null)
				{
					r_Current = new(this, "Current", -1);
					r_Current.SetBelong(this.instance);
				}
				return r_Current;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaCollectionNode CurrentNode
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaCollectionNode r_CurrentNode;
		public virtual RSystem.RXml.RSchema.RXmlSchemaCollectionNode RCurrentNode
		{
			get
			{
				if(r_CurrentNode == null)
				{
					r_CurrentNode = new(this, "CurrentNode", -1);
					r_CurrentNode.SetBelong(this.instance);
				}
				return r_CurrentNode;
			}
		}

		/// <summary>
		/// Void System.Collections.IEnumerator.Reset()
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__IEnumerator__1__Reset;
		public virtual RMethod RSystem__1__Collections__1__IEnumerator__1__Reset
		{
			get
			{
				if(r_RSystem__1__Collections__1__IEnumerator__1__Reset == null)
				{
					r_RSystem__1__Collections__1__IEnumerator__1__Reset = new(this, "System.Collections.IEnumerator.Reset", 0);
					r_RSystem__1__Collections__1__IEnumerator__1__Reset.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IEnumerator__1__Reset;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IEnumerator.MoveNext()
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__IEnumerator__1__MoveNext;
		public virtual RMethod RSystem__1__Collections__1__IEnumerator__1__MoveNext
		{
			get
			{
				if(r_RSystem__1__Collections__1__IEnumerator__1__MoveNext == null)
				{
					r_RSystem__1__Collections__1__IEnumerator__1__MoveNext = new(this, "System.Collections.IEnumerator.MoveNext", 0);
					r_RSystem__1__Collections__1__IEnumerator__1__MoveNext.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IEnumerator__1__MoveNext;
			}
		}

		/// <summary>
		/// Boolean MoveNext()
		/// </summary>
		protected RMethod r_RMoveNext;
		public virtual RMethod RMoveNext
		{
			get
			{
				if(r_RMoveNext == null)
				{
					r_RMoveNext = new(this, "MoveNext", 0);
					r_RMoveNext.SetBelong(this.instance);
				}
				return r_RMoveNext;
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


        public RXmlSchemaCollectionEnumerator() : base("System.Xml.Schema.XmlSchemaCollectionEnumerator")
        {
        }

        public RXmlSchemaCollectionEnumerator(System.Object instance) : base("System.Xml.Schema.XmlSchemaCollectionEnumerator")
		{
            SetInstance(instance);
		}

        public RXmlSchemaCollectionEnumerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlSchemaCollectionEnumerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__1__Collections__1__IEnumerator__1__Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__Collections__1__IEnumerator__1__Reset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__1__Collections__1__IEnumerator__1__MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__Collections__1__IEnumerator__1__MoveNext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveNext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
