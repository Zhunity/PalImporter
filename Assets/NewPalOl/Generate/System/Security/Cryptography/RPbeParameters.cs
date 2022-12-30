using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography
{
	/// <summary>
	/// System.Security.Cryptography.PbeParameters
	/// </summary>
    public partial class RPbeParameters : RMember //
    {

		/// <summary>
		/// System.Security.Cryptography.PbeEncryptionAlgorithm <EncryptionAlgorithm>k__BackingField
		/// </summary>
		protected RField r___2__EncryptionAlgorithm__4__k__BackingField;
		public virtual RField R__2__EncryptionAlgorithm__4__k__BackingField
		{
			get
			{
				if(r___2__EncryptionAlgorithm__4__k__BackingField == null)
				{
					r___2__EncryptionAlgorithm__4__k__BackingField = new(this, "<EncryptionAlgorithm>k__BackingField");
					r___2__EncryptionAlgorithm__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__EncryptionAlgorithm__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName <HashAlgorithm>k__BackingField
		/// </summary>
		protected RSystem.RSecurity.RCryptography.RHashAlgorithmName r___2__HashAlgorithm__4__k__BackingField;
		public virtual RSystem.RSecurity.RCryptography.RHashAlgorithmName R__2__HashAlgorithm__4__k__BackingField
		{
			get
			{
				if(r___2__HashAlgorithm__4__k__BackingField == null)
				{
					r___2__HashAlgorithm__4__k__BackingField = new(this, "<HashAlgorithm>k__BackingField");
					r___2__HashAlgorithm__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__HashAlgorithm__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <IterationCount>k__BackingField
		/// </summary>
		protected RField r___2__IterationCount__4__k__BackingField;
		public virtual RField R__2__IterationCount__4__k__BackingField
		{
			get
			{
				if(r___2__IterationCount__4__k__BackingField == null)
				{
					r___2__IterationCount__4__k__BackingField = new(this, "<IterationCount>k__BackingField");
					r___2__IterationCount__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__IterationCount__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.PbeEncryptionAlgorithm EncryptionAlgorithm
		/// </summary>
		protected RProperty r_EncryptionAlgorithm;
		public virtual RProperty REncryptionAlgorithm
		{
			get
			{
				if(r_EncryptionAlgorithm == null)
				{
					r_EncryptionAlgorithm = new(this, "EncryptionAlgorithm", -1);
					r_EncryptionAlgorithm.SetBelong(this.instance);
				}
				return r_EncryptionAlgorithm;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName HashAlgorithm
		/// </summary>
		protected RSystem.RSecurity.RCryptography.RHashAlgorithmName r_HashAlgorithm;
		public virtual RSystem.RSecurity.RCryptography.RHashAlgorithmName RHashAlgorithm
		{
			get
			{
				if(r_HashAlgorithm == null)
				{
					r_HashAlgorithm = new(this, "HashAlgorithm", -1);
					r_HashAlgorithm.SetBelong(this.instance);
				}
				return r_HashAlgorithm;
			}
		}

		/// <summary>
		/// Int32 IterationCount
		/// </summary>
		protected RProperty r_IterationCount;
		public virtual RProperty RIterationCount
		{
			get
			{
				if(r_IterationCount == null)
				{
					r_IterationCount = new(this, "IterationCount", -1);
					r_IterationCount.SetBelong(this.instance);
				}
				return r_IterationCount;
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


        public RPbeParameters() : base("System.Security.Cryptography.PbeParameters")
        {
        }

        public RPbeParameters(System.Object instance) : base("System.Security.Cryptography.PbeParameters")
		{
            SetInstance(instance);
		}

        public RPbeParameters(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPbeParameters(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
