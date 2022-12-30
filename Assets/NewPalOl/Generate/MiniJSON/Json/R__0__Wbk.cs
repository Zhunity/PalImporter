using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RMiniJSON
{public partial class RJson
{
	
	/// <summary>
	/// MiniJSON.Json+#Wbk
	/// </summary>
    public partial class R__0__Wbk : RMember //
    {

		/// <summary>
		/// System.String #a
		/// </summary>
		protected static RField r___0__a;
		public static RField R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new( ReleactionUtils.GetType("MiniJSON.Json+#Wbk"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.IO.StringReader #b
		/// </summary>
		protected RSystem.RIO.RStringReader r___0__b;
		public virtual RSystem.RIO.RStringReader R__0__b
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
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] #c
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__c;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new( ReleactionUtils.GetType("MiniJSON.Json+#Wbk"), "#c");
					r___0__c.SetBelong(null);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// Char PeekChar
		/// </summary>
		protected RProperty r_R__0__Sbk;
		public virtual RProperty R__0__Sbk
		{
			get
			{
				if(r_R__0__Sbk == null)
				{
					r_R__0__Sbk = new(this, "PeekChar", -1);
					r_R__0__Sbk.SetBelong(this.instance);
				}
				return r_R__0__Sbk;
			}
		}

		/// <summary>
		/// Char NextChar
		/// </summary>
		protected RProperty r_R__0__Tbk;
		public virtual RProperty R__0__Tbk
		{
			get
			{
				if(r_R__0__Tbk == null)
				{
					r_R__0__Tbk = new(this, "NextChar", -1);
					r_R__0__Tbk.SetBelong(this.instance);
				}
				return r_R__0__Tbk;
			}
		}

		/// <summary>
		/// System.String NextWord
		/// </summary>
		protected RProperty r_R__0__Ubk;
		public virtual RProperty R__0__Ubk
		{
			get
			{
				if(r_R__0__Ubk == null)
				{
					r_R__0__Ubk = new(this, "NextWord", -1);
					r_R__0__Ubk.SetBelong(this.instance);
				}
				return r_R__0__Ubk;
			}
		}

		/// <summary>
		/// #Xbk NextToken
		/// </summary>
		protected RProperty r_R__0__Vbk;
		public virtual RProperty R__0__Vbk
		{
			get
			{
				if(r_R__0__Vbk == null)
				{
					r_R__0__Vbk = new(this, "NextToken", -1);
					r_R__0__Vbk.SetBelong(this.instance);
				}
				return r_R__0__Vbk;
			}
		}

		/// <summary>
		/// Boolean #Kbk(Char)
		/// </summary>
		protected static RMethod r_R__0__Kbk_Char;
		public static RMethod R__0__Kbk_Char
		{
			get
			{
				if(r_R__0__Kbk_Char == null)
				{
					r_R__0__Kbk_Char = new( ReleactionUtils.GetType("MiniJSON.Json+#Wbk"), "#Kbk", 0, typeof(System.Char));
					r_R__0__Kbk_Char.SetBelong(null);
				}
				return r_R__0__Kbk_Char;
			}
		}

		/// <summary>
		/// System.Object Parse(System.String)
		/// </summary>
		protected static RMethod r_RParse_String;
		public static RMethod RParse_String
		{
			get
			{
				if(r_RParse_String == null)
				{
					r_RParse_String = new( ReleactionUtils.GetType("MiniJSON.Json+#Wbk"), "Parse", 0, typeof(System.String));
					r_RParse_String.SetBelong(null);
				}
				return r_RParse_String;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Object] #Lbk()
		/// </summary>
		protected RMethod r_R__0__Lbk;
		public virtual RMethod R__0__Lbk
		{
			get
			{
				if(r_R__0__Lbk == null)
				{
					r_R__0__Lbk = new(this, "#Lbk", 0);
					r_R__0__Lbk.SetBelong(this.instance);
				}
				return r_R__0__Lbk;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Object] #Mbk()
		/// </summary>
		protected RMethod r_R__0__Mbk;
		public virtual RMethod R__0__Mbk
		{
			get
			{
				if(r_R__0__Mbk == null)
				{
					r_R__0__Mbk = new(this, "#Mbk", 0);
					r_R__0__Mbk.SetBelong(this.instance);
				}
				return r_R__0__Mbk;
			}
		}

		/// <summary>
		/// System.Object #Nbk()
		/// </summary>
		protected RMethod r_R__0__Nbk;
		public virtual RMethod R__0__Nbk
		{
			get
			{
				if(r_R__0__Nbk == null)
				{
					r_R__0__Nbk = new(this, "#Nbk", 0);
					r_R__0__Nbk.SetBelong(this.instance);
				}
				return r_R__0__Nbk;
			}
		}

		/// <summary>
		/// System.Object #Obk(#Xbk)
		/// </summary>
		protected RMethod r_R__0__Obk___0__Xbk;
		public virtual RMethod R__0__Obk___0__Xbk
		{
			get
			{
				if(r_R__0__Obk___0__Xbk == null)
				{
					r_R__0__Obk___0__Xbk = new(this, "#Obk", 0,  ReleactionUtils.GetType("MiniJSON.Json+#Wbk+#Xbk"));
					r_R__0__Obk___0__Xbk.SetBelong(this.instance);
				}
				return r_R__0__Obk___0__Xbk;
			}
		}

		/// <summary>
		/// System.String #Pbk()
		/// </summary>
		protected RMethod r_R__0__Pbk;
		public virtual RMethod R__0__Pbk
		{
			get
			{
				if(r_R__0__Pbk == null)
				{
					r_R__0__Pbk = new(this, "#Pbk", 0);
					r_R__0__Pbk.SetBelong(this.instance);
				}
				return r_R__0__Pbk;
			}
		}

		/// <summary>
		/// System.Object #Qbk()
		/// </summary>
		protected RMethod r_R__0__Qbk;
		public virtual RMethod R__0__Qbk
		{
			get
			{
				if(r_R__0__Qbk == null)
				{
					r_R__0__Qbk = new(this, "#Qbk", 0);
					r_R__0__Qbk.SetBelong(this.instance);
				}
				return r_R__0__Qbk;
			}
		}

		/// <summary>
		/// Void #Rbk()
		/// </summary>
		protected RMethod r_R__0__Rbk;
		public virtual RMethod R__0__Rbk
		{
			get
			{
				if(r_R__0__Rbk == null)
				{
					r_R__0__Rbk = new(this, "#Rbk", 0);
					r_R__0__Rbk.SetBelong(this.instance);
				}
				return r_R__0__Rbk;
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


        public R__0__Wbk() : base("MiniJSON.Json+#Wbk")
        {
        }

        public R__0__Wbk(System.Object instance) : base("MiniJSON.Json+#Wbk")
		{
            SetInstance(instance);
		}

        public R__0__Wbk(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Wbk(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean __0__Kbk(System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = R__0__Kbk_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Object Parse(System.String  @jsonString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@jsonString};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.Dictionary<System.String, System.Object> __0__Lbk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Lbk.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<System.String, System.Object>)___result;
        }


        public virtual System.Collections.Generic.List<System.Object> __0__Mbk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Mbk.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.Object>)___result;
        }


        public virtual System.Object __0__Nbk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Nbk.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual System.String __0__Pbk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Pbk.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object __0__Qbk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Qbk.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__Rbk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Rbk.Invoke(___genericsType, ___parameters);

            
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
}