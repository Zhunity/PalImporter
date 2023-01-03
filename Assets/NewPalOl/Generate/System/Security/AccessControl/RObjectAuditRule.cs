using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.ObjectAuditRule
	/// </summary>
    public partial class RObjectAuditRule : RMember //
    {

		/// <summary>
		/// System.Guid inherited_object_type
		/// </summary>
		protected RSystem.RGuid r_inherited_object_type;
		public virtual RSystem.RGuid Rinherited_object_type
		{
			get
			{
				if(r_inherited_object_type == null)
				{
					r_inherited_object_type = new(this, "inherited_object_type");
					r_inherited_object_type.SetBelong(this.instance);
				}
				return r_inherited_object_type;
			}
		}

		/// <summary>
		/// System.Guid object_type
		/// </summary>
		protected RSystem.RGuid r_object_type;
		public virtual RSystem.RGuid Robject_type
		{
			get
			{
				if(r_object_type == null)
				{
					r_object_type = new(this, "object_type");
					r_object_type.SetBelong(this.instance);
				}
				return r_object_type;
			}
		}

		/// <summary>
		/// System.Guid InheritedObjectType
		/// </summary>
		protected RSystem.RGuid r_InheritedObjectType;
		public virtual RSystem.RGuid RInheritedObjectType
		{
			get
			{
				if(r_InheritedObjectType == null)
				{
					r_InheritedObjectType = new(this, "InheritedObjectType", -1);
					r_InheritedObjectType.SetBelong(this.instance);
				}
				return r_InheritedObjectType;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ObjectAceFlags ObjectFlags
		/// </summary>
		protected RProperty r_ObjectFlags;
		public virtual RProperty RObjectFlags
		{
			get
			{
				if(r_ObjectFlags == null)
				{
					r_ObjectFlags = new(this, "ObjectFlags", -1);
					r_ObjectFlags.SetBelong(this.instance);
				}
				return r_ObjectFlags;
			}
		}

		/// <summary>
		/// System.Guid ObjectType
		/// </summary>
		protected RSystem.RGuid r_ObjectType;
		public virtual RSystem.RGuid RObjectType
		{
			get
			{
				if(r_ObjectType == null)
				{
					r_ObjectType = new(this, "ObjectType", -1);
					r_ObjectType.SetBelong(this.instance);
				}
				return r_ObjectType;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuditFlags AuditFlags
		/// </summary>
		protected RProperty r_AuditFlags;
		public virtual RProperty RAuditFlags
		{
			get
			{
				if(r_AuditFlags == null)
				{
					r_AuditFlags = new(this, "AuditFlags", -1);
					r_AuditFlags.SetBelong(this.instance);
				}
				return r_AuditFlags;
			}
		}

		/// <summary>
		/// System.Security.Principal.IdentityReference IdentityReference
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RIdentityReference r_IdentityReference;
		public virtual RSystem.RSecurity.RPrincipal.RIdentityReference RIdentityReference
		{
			get
			{
				if(r_IdentityReference == null)
				{
					r_IdentityReference = new(this, "IdentityReference", -1);
					r_IdentityReference.SetBelong(this.instance);
				}
				return r_IdentityReference;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.InheritanceFlags InheritanceFlags
		/// </summary>
		protected RProperty r_InheritanceFlags;
		public virtual RProperty RInheritanceFlags
		{
			get
			{
				if(r_InheritanceFlags == null)
				{
					r_InheritanceFlags = new(this, "InheritanceFlags", -1);
					r_InheritanceFlags.SetBelong(this.instance);
				}
				return r_InheritanceFlags;
			}
		}

		/// <summary>
		/// Boolean IsInherited
		/// </summary>
		protected RProperty r_IsInherited;
		public virtual RProperty RIsInherited
		{
			get
			{
				if(r_IsInherited == null)
				{
					r_IsInherited = new(this, "IsInherited", -1);
					r_IsInherited.SetBelong(this.instance);
				}
				return r_IsInherited;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.PropagationFlags PropagationFlags
		/// </summary>
		protected RProperty r_PropagationFlags;
		public virtual RProperty RPropagationFlags
		{
			get
			{
				if(r_PropagationFlags == null)
				{
					r_PropagationFlags = new(this, "PropagationFlags", -1);
					r_PropagationFlags.SetBelong(this.instance);
				}
				return r_PropagationFlags;
			}
		}

		/// <summary>
		/// Int32 AccessMask
		/// </summary>
		protected RProperty r_AccessMask;
		public virtual RProperty RAccessMask
		{
			get
			{
				if(r_AccessMask == null)
				{
					r_AccessMask = new(this, "AccessMask", -1);
					r_AccessMask.SetBelong(this.instance);
				}
				return r_AccessMask;
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


        public RObjectAuditRule() : base("System.Security.AccessControl.ObjectAuditRule")
        {
        }

        public RObjectAuditRule(System.Object instance) : base("System.Security.AccessControl.ObjectAuditRule")
		{
            SetInstance(instance);
		}

        public RObjectAuditRule(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RObjectAuditRule(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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