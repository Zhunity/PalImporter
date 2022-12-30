using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// LoginFake
	/// </summary>
    public partial class RLoginFake : RMember //
    {

		/// <summary>
		/// LoginFake #a
		/// </summary>
		protected static RLoginFake r___0__a;
		public static RLoginFake R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(typeof(LoginFake), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.String #b
		/// </summary>
		protected RField r___0__b;
		public virtual RField R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new(this, "#b");
					r___0__b.SetBelong(this.instance);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.Int32 #c
		/// </summary>
		protected RField r___0__c;
		public virtual RField R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new(this, "#c");
					r___0__c.SetBelong(this.instance);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// System.Int64 #d
		/// </summary>
		protected RField r___0__d;
		public virtual RField R__0__d
		{
			get
			{
				if(r___0__d == null)
				{
					r___0__d = new(this, "#d");
					r___0__d.SetBelong(this.instance);
				}
				return r___0__d;
			}
		}

		/// <summary>
		/// System.String #e
		/// </summary>
		protected RField r___0__e;
		public virtual RField R__0__e
		{
			get
			{
				if(r___0__e == null)
				{
					r___0__e = new(this, "#e");
					r___0__e.SetBelong(this.instance);
				}
				return r___0__e;
			}
		}

		/// <summary>
		/// System.Int32 #f
		/// </summary>
		protected RField r___0__f;
		public virtual RField R__0__f
		{
			get
			{
				if(r___0__f == null)
				{
					r___0__f = new(this, "#f");
					r___0__f.SetBelong(this.instance);
				}
				return r___0__f;
			}
		}

		/// <summary>
		/// System.String #g
		/// </summary>
		protected RField r___0__g;
		public virtual RField R__0__g
		{
			get
			{
				if(r___0__g == null)
				{
					r___0__g = new(this, "#g");
					r___0__g.SetBelong(this.instance);
				}
				return r___0__g;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] #h
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__h;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__h
		{
			get
			{
				if(r___0__h == null)
				{
					r___0__h = new(this, "#h");
					r___0__h.SetBelong(this.instance);
				}
				return r___0__h;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] #i
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__i;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__i
		{
			get
			{
				if(r___0__i == null)
				{
					r___0__i = new(typeof(LoginFake), "#i");
					r___0__i.SetBelong(null);
				}
				return r___0__i;
			}
		}

		/// <summary>
		/// LoginFake Inst
		/// </summary>
		protected static RLoginFake r_Inst;
		public static RLoginFake RInst
		{
			get
			{
				if(r_Inst == null)
				{
					r_Inst = new(typeof(LoginFake), "Inst", -1);
					r_Inst.SetBelong(null);
				}
				return r_Inst;
			}
		}

		/// <summary>
		/// Void SetHttpGet(System.String)
		/// </summary>
		protected RMethod r_RSetHttpGet_String;
		public virtual RMethod RSetHttpGet_String
		{
			get
			{
				if(r_RSetHttpGet_String == null)
				{
					r_RSetHttpGet_String = new(this, "SetHttpGet", 0, typeof(System.String));
					r_RSetHttpGet_String.SetBelong(this.instance);
				}
				return r_RSetHttpGet_String;
			}
		}

		/// <summary>
		/// Int64 GetAccount()
		/// </summary>
		protected RMethod r_RGetAccount;
		public virtual RMethod RGetAccount
		{
			get
			{
				if(r_RGetAccount == null)
				{
					r_RGetAccount = new(this, "GetAccount", 0);
					r_RGetAccount.SetBelong(this.instance);
				}
				return r_RGetAccount;
			}
		}

		/// <summary>
		/// System.String GetNewName()
		/// </summary>
		protected RMethod r_RGetNewName;
		public virtual RMethod RGetNewName
		{
			get
			{
				if(r_RGetNewName == null)
				{
					r_RGetNewName = new(this, "GetNewName", 0);
					r_RGetNewName.SetBelong(this.instance);
				}
				return r_RGetNewName;
			}
		}

		/// <summary>
		/// Int32 GetCareer()
		/// </summary>
		protected RMethod r_RGetCareer;
		public virtual RMethod RGetCareer
		{
			get
			{
				if(r_RGetCareer == null)
				{
					r_RGetCareer = new(this, "GetCareer", 0);
					r_RGetCareer.SetBelong(this.instance);
				}
				return r_RGetCareer;
			}
		}

		/// <summary>
		/// Void OverWriteKey(System.String ByRef)
		/// </summary>
		protected RMethod r_ROverWriteKey_Ref_String;
		public virtual RMethod ROverWriteKey_Ref_String
		{
			get
			{
				if(r_ROverWriteKey_Ref_String == null)
				{
					r_ROverWriteKey_Ref_String = new(this, "OverWriteKey", 0, typeof(System.String).MakeByRefType());
					r_ROverWriteKey_Ref_String.SetBelong(this.instance);
				}
				return r_ROverWriteKey_Ref_String;
			}
		}

		/// <summary>
		/// Void OverWriteLoginPort(System.String ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_ROverWriteLoginPort_Ref_String_Ref_Int32;
		public virtual RMethod ROverWriteLoginPort_Ref_String_Ref_Int32
		{
			get
			{
				if(r_ROverWriteLoginPort_Ref_String_Ref_Int32 == null)
				{
					r_ROverWriteLoginPort_Ref_String_Ref_Int32 = new(this, "OverWriteLoginPort", 0, typeof(System.String).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_ROverWriteLoginPort_Ref_String_Ref_Int32.SetBelong(this.instance);
				}
				return r_ROverWriteLoginPort_Ref_String_Ref_Int32;
			}
		}

		/// <summary>
		/// Boolean IsFakeAccount()
		/// </summary>
		protected RMethod r_RIsFakeAccount;
		public virtual RMethod RIsFakeAccount
		{
			get
			{
				if(r_RIsFakeAccount == null)
				{
					r_RIsFakeAccount = new(this, "IsFakeAccount", 0);
					r_RIsFakeAccount.SetBelong(this.instance);
				}
				return r_RIsFakeAccount;
			}
		}

		/// <summary>
		/// Void TryFakeLoginInfo()
		/// </summary>
		protected RMethod r_RTryFakeLoginInfo;
		public virtual RMethod RTryFakeLoginInfo
		{
			get
			{
				if(r_RTryFakeLoginInfo == null)
				{
					r_RTryFakeLoginInfo = new(this, "TryFakeLoginInfo", 0);
					r_RTryFakeLoginInfo.SetBelong(this.instance);
				}
				return r_RTryFakeLoginInfo;
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


        public RLoginFake() : base("LoginFake")
        {
        }

        public RLoginFake(System.Object instance) : base("LoginFake")
		{
            SetInstance(instance);
		}

        public RLoginFake(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLoginFake(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetHttpGet(System.String  @getInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@getInfo};
            var ___result = RSetHttpGet_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int64 GetAccount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAccount.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.String GetNewName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNewName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetCareer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCareer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void OverWriteKey(ref System.String  @loginKey)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@loginKey};
            var ___result = ROverWriteKey_Ref_String.Invoke(___genericsType, ___parameters);
			loginKey = (System.String)___parameters[0];

            
        }


        public virtual void OverWriteLoginPort(ref System.String  @loginAddress, ref System.Int32  @loginPort)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@loginAddress, @loginPort};
            var ___result = ROverWriteLoginPort_Ref_String_Ref_Int32.Invoke(___genericsType, ___parameters);
			loginAddress = (System.String)___parameters[0];
			loginPort = (System.Int32)___parameters[1];

            
        }


        public virtual System.Boolean IsFakeAccount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsFakeAccount.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void TryFakeLoginInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTryFakeLoginInfo.Invoke(___genericsType, ___parameters);

            
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
