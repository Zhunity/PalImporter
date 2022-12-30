using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlNodeList
	/// </summary>
    public partial class RXmlNodeList : RMember //
    {

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode ItemOf [Int32]
		/// </summary>
		protected RSystem.RXml.RXmlNode r_ItemOf_Int32;
		public virtual RSystem.RXml.RXmlNode RItemOf_Int32
		{
			get
			{
				if(r_ItemOf_Int32 == null)
				{
					r_ItemOf_Int32 = new(this, "ItemOf", -1, typeof(System.Int32));
					r_ItemOf_Int32.SetBelong(this.instance);
				}
				return r_ItemOf_Int32;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode Item(Int32)
		/// </summary>
		protected RMethod r_RItem_Int32;
		public virtual RMethod RItem_Int32
		{
			get
			{
				if(r_RItem_Int32 == null)
				{
					r_RItem_Int32 = new(this, "Item", 0, typeof(System.Int32));
					r_RItem_Int32.SetBelong(this.instance);
				}
				return r_RItem_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_RGetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_RGetEnumerator == null)
				{
					r_RGetEnumerator = new(this, "GetEnumerator", 0);
					r_RGetEnumerator.SetBelong(this.instance);
				}
				return r_RGetEnumerator;
			}
		}

		/// <summary>
		/// Void System.IDisposable.Dispose()
		/// </summary>
		protected RMethod r_RSystem__1__IDisposable__1__Dispose;
		public virtual RMethod RSystem__1__IDisposable__1__Dispose
		{
			get
			{
				if(r_RSystem__1__IDisposable__1__Dispose == null)
				{
					r_RSystem__1__IDisposable__1__Dispose = new(this, "System.IDisposable.Dispose", 0);
					r_RSystem__1__IDisposable__1__Dispose.SetBelong(this.instance);
				}
				return r_RSystem__1__IDisposable__1__Dispose;
			}
		}

		/// <summary>
		/// Void PrivateDisposeNodeList()
		/// </summary>
		protected RMethod r_RPrivateDisposeNodeList;
		public virtual RMethod RPrivateDisposeNodeList
		{
			get
			{
				if(r_RPrivateDisposeNodeList == null)
				{
					r_RPrivateDisposeNodeList = new(this, "PrivateDisposeNodeList", 0);
					r_RPrivateDisposeNodeList.SetBelong(this.instance);
				}
				return r_RPrivateDisposeNodeList;
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


        public RXmlNodeList() : base("System.Xml.XmlNodeList")
        {
        }

        public RXmlNodeList(System.Object instance) : base("System.Xml.XmlNodeList")
		{
            SetInstance(instance);
		}

        public RXmlNodeList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlNodeList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Xml.XmlNode Item(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RItem_Int32.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void System__1__IDisposable__1__Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__IDisposable__1__Dispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrivateDisposeNodeList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPrivateDisposeNodeList.Invoke(___genericsType, ___parameters);

            
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
