using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.IDtdEntityInfo
	/// </summary>
    public partial class RIDtdEntityInfo : RMember //
    {

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
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
		/// Boolean IsExternal
		/// </summary>
		protected RProperty r_IsExternal;
		public virtual RProperty RIsExternal
		{
			get
			{
				if(r_IsExternal == null)
				{
					r_IsExternal = new(this, "IsExternal", -1);
					r_IsExternal.SetBelong(this.instance);
				}
				return r_IsExternal;
			}
		}

		/// <summary>
		/// Boolean IsDeclaredInExternal
		/// </summary>
		protected RProperty r_IsDeclaredInExternal;
		public virtual RProperty RIsDeclaredInExternal
		{
			get
			{
				if(r_IsDeclaredInExternal == null)
				{
					r_IsDeclaredInExternal = new(this, "IsDeclaredInExternal", -1);
					r_IsDeclaredInExternal.SetBelong(this.instance);
				}
				return r_IsDeclaredInExternal;
			}
		}

		/// <summary>
		/// Boolean IsUnparsedEntity
		/// </summary>
		protected RProperty r_IsUnparsedEntity;
		public virtual RProperty RIsUnparsedEntity
		{
			get
			{
				if(r_IsUnparsedEntity == null)
				{
					r_IsUnparsedEntity = new(this, "IsUnparsedEntity", -1);
					r_IsUnparsedEntity.SetBelong(this.instance);
				}
				return r_IsUnparsedEntity;
			}
		}

		/// <summary>
		/// Boolean IsParameterEntity
		/// </summary>
		protected RProperty r_IsParameterEntity;
		public virtual RProperty RIsParameterEntity
		{
			get
			{
				if(r_IsParameterEntity == null)
				{
					r_IsParameterEntity = new(this, "IsParameterEntity", -1);
					r_IsParameterEntity.SetBelong(this.instance);
				}
				return r_IsParameterEntity;
			}
		}

		/// <summary>
		/// System.String BaseUriString
		/// </summary>
		protected RProperty r_BaseUriString;
		public virtual RProperty RBaseUriString
		{
			get
			{
				if(r_BaseUriString == null)
				{
					r_BaseUriString = new(this, "BaseUriString", -1);
					r_BaseUriString.SetBelong(this.instance);
				}
				return r_BaseUriString;
			}
		}

		/// <summary>
		/// System.String DeclaredUriString
		/// </summary>
		protected RProperty r_DeclaredUriString;
		public virtual RProperty RDeclaredUriString
		{
			get
			{
				if(r_DeclaredUriString == null)
				{
					r_DeclaredUriString = new(this, "DeclaredUriString", -1);
					r_DeclaredUriString.SetBelong(this.instance);
				}
				return r_DeclaredUriString;
			}
		}

		/// <summary>
		/// System.String SystemId
		/// </summary>
		protected RProperty r_SystemId;
		public virtual RProperty RSystemId
		{
			get
			{
				if(r_SystemId == null)
				{
					r_SystemId = new(this, "SystemId", -1);
					r_SystemId.SetBelong(this.instance);
				}
				return r_SystemId;
			}
		}

		/// <summary>
		/// System.String PublicId
		/// </summary>
		protected RProperty r_PublicId;
		public virtual RProperty RPublicId
		{
			get
			{
				if(r_PublicId == null)
				{
					r_PublicId = new(this, "PublicId", -1);
					r_PublicId.SetBelong(this.instance);
				}
				return r_PublicId;
			}
		}

		/// <summary>
		/// System.String Text
		/// </summary>
		protected RProperty r_Text;
		public virtual RProperty RText
		{
			get
			{
				if(r_Text == null)
				{
					r_Text = new(this, "Text", -1);
					r_Text.SetBelong(this.instance);
				}
				return r_Text;
			}
		}

		/// <summary>
		/// Int32 LineNumber
		/// </summary>
		protected RProperty r_LineNumber;
		public virtual RProperty RLineNumber
		{
			get
			{
				if(r_LineNumber == null)
				{
					r_LineNumber = new(this, "LineNumber", -1);
					r_LineNumber.SetBelong(this.instance);
				}
				return r_LineNumber;
			}
		}

		/// <summary>
		/// Int32 LinePosition
		/// </summary>
		protected RProperty r_LinePosition;
		public virtual RProperty RLinePosition
		{
			get
			{
				if(r_LinePosition == null)
				{
					r_LinePosition = new(this, "LinePosition", -1);
					r_LinePosition.SetBelong(this.instance);
				}
				return r_LinePosition;
			}
		}


        public RIDtdEntityInfo() : base("System.Xml.IDtdEntityInfo")
        {
        }

        public RIDtdEntityInfo(System.Object instance) : base("System.Xml.IDtdEntityInfo")
		{
            SetInstance(instance);
		}

        public RIDtdEntityInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIDtdEntityInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
