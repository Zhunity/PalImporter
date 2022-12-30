using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.IDtdInfo
	/// </summary>
    public partial class RIDtdInfo : RMember //
    {

		/// <summary>
		/// System.Xml.XmlQualifiedName Name
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_Name;
		public virtual RSystem.RXml.RXmlQualifiedName RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// System.String InternalDtdSubset
		/// </summary>
		protected RProperty r_InternalDtdSubset;
		public virtual RProperty RInternalDtdSubset
		{
			get
			{
				if(r_InternalDtdSubset == null)
				{
					r_InternalDtdSubset = new(this, "InternalDtdSubset", -1);
					r_InternalDtdSubset.SetBelong(this.instance);
				}
				return r_InternalDtdSubset;
			}
		}

		/// <summary>
		/// Boolean HasDefaultAttributes
		/// </summary>
		protected RProperty r_HasDefaultAttributes;
		public virtual RProperty RHasDefaultAttributes
		{
			get
			{
				if(r_HasDefaultAttributes == null)
				{
					r_HasDefaultAttributes = new(this, "HasDefaultAttributes", -1);
					r_HasDefaultAttributes.SetBelong(this.instance);
				}
				return r_HasDefaultAttributes;
			}
		}

		/// <summary>
		/// Boolean HasNonCDataAttributes
		/// </summary>
		protected RProperty r_HasNonCDataAttributes;
		public virtual RProperty RHasNonCDataAttributes
		{
			get
			{
				if(r_HasNonCDataAttributes == null)
				{
					r_HasNonCDataAttributes = new(this, "HasNonCDataAttributes", -1);
					r_HasNonCDataAttributes.SetBelong(this.instance);
				}
				return r_HasNonCDataAttributes;
			}
		}

		/// <summary>
		/// System.Xml.IDtdAttributeListInfo LookupAttributeList(System.String, System.String)
		/// </summary>
		protected RMethod r_RLookupAttributeList_String_String;
		public virtual RMethod RLookupAttributeList_String_String
		{
			get
			{
				if(r_RLookupAttributeList_String_String == null)
				{
					r_RLookupAttributeList_String_String = new(this, "LookupAttributeList", 0, typeof(System.String), typeof(System.String));
					r_RLookupAttributeList_String_String.SetBelong(this.instance);
				}
				return r_RLookupAttributeList_String_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Xml.IDtdAttributeListInfo] GetAttributeLists()
		/// </summary>
		protected RMethod r_RGetAttributeLists;
		public virtual RMethod RGetAttributeLists
		{
			get
			{
				if(r_RGetAttributeLists == null)
				{
					r_RGetAttributeLists = new(this, "GetAttributeLists", 0);
					r_RGetAttributeLists.SetBelong(this.instance);
				}
				return r_RGetAttributeLists;
			}
		}

		/// <summary>
		/// System.Xml.IDtdEntityInfo LookupEntity(System.String)
		/// </summary>
		protected RMethod r_RLookupEntity_String;
		public virtual RMethod RLookupEntity_String
		{
			get
			{
				if(r_RLookupEntity_String == null)
				{
					r_RLookupEntity_String = new(this, "LookupEntity", 0, typeof(System.String));
					r_RLookupEntity_String.SetBelong(this.instance);
				}
				return r_RLookupEntity_String;
			}
		}


        public RIDtdInfo() : base("System.Xml.IDtdInfo")
        {
        }

        public RIDtdInfo(System.Object instance) : base("System.Xml.IDtdInfo")
		{
            SetInstance(instance);
		}

        public RIDtdInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIDtdInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object LookupAttributeList(System.String  @prefix, System.String  @localName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName};
            var ___result = RLookupAttributeList_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetAttributeLists()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAttributeLists.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LookupEntity(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RLookupEntity_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
