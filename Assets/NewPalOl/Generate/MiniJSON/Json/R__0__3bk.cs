using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RMiniJSON
{public partial class RJson
{
	
	/// <summary>
	/// MiniJSON.Json+#3bk
	/// </summary>
    public partial class R__0__3bk : RMember //
    {

		/// <summary>
		/// System.Text.StringBuilder #a
		/// </summary>
		protected RSystem.RText.RStringBuilder r___0__a;
		public virtual RSystem.RText.RStringBuilder R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(this, "#a");
					r___0__a.SetBelong(this.instance);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.String Serialize(System.Object)
		/// </summary>
		protected static RMethod r_RSerialize_Object;
		public static RMethod RSerialize_Object
		{
			get
			{
				if(r_RSerialize_Object == null)
				{
					r_RSerialize_Object = new( ReleactionUtils.GetType("MiniJSON.Json+#3bk"), "Serialize", 0, typeof(System.Object));
					r_RSerialize_Object.SetBelong(null);
				}
				return r_RSerialize_Object;
			}
		}

		/// <summary>
		/// Void #Ybk(System.Object)
		/// </summary>
		protected RMethod r_R__0__Ybk_Object;
		public virtual RMethod R__0__Ybk_Object
		{
			get
			{
				if(r_R__0__Ybk_Object == null)
				{
					r_R__0__Ybk_Object = new(this, "#Ybk", 0, typeof(System.Object));
					r_R__0__Ybk_Object.SetBelong(this.instance);
				}
				return r_R__0__Ybk_Object;
			}
		}

		/// <summary>
		/// Void #Zbk(System.Collections.IDictionary)
		/// </summary>
		protected RMethod r_R__0__Zbk_IDictionary;
		public virtual RMethod R__0__Zbk_IDictionary
		{
			get
			{
				if(r_R__0__Zbk_IDictionary == null)
				{
					r_R__0__Zbk_IDictionary = new(this, "#Zbk", 0, typeof(System.Collections.IDictionary));
					r_R__0__Zbk_IDictionary.SetBelong(this.instance);
				}
				return r_R__0__Zbk_IDictionary;
			}
		}

		/// <summary>
		/// Void #0bk(System.Collections.IList)
		/// </summary>
		protected RMethod r_R__0__0bk_IList;
		public virtual RMethod R__0__0bk_IList
		{
			get
			{
				if(r_R__0__0bk_IList == null)
				{
					r_R__0__0bk_IList = new(this, "#0bk", 0, typeof(System.Collections.IList));
					r_R__0__0bk_IList.SetBelong(this.instance);
				}
				return r_R__0__0bk_IList;
			}
		}

		/// <summary>
		/// Void #1bk(System.String)
		/// </summary>
		protected RMethod r_R__0__1bk_String;
		public virtual RMethod R__0__1bk_String
		{
			get
			{
				if(r_R__0__1bk_String == null)
				{
					r_R__0__1bk_String = new(this, "#1bk", 0, typeof(System.String));
					r_R__0__1bk_String.SetBelong(this.instance);
				}
				return r_R__0__1bk_String;
			}
		}

		/// <summary>
		/// Void #2bk(System.Object)
		/// </summary>
		protected RMethod r_R__0__2bk_Object;
		public virtual RMethod R__0__2bk_Object
		{
			get
			{
				if(r_R__0__2bk_Object == null)
				{
					r_R__0__2bk_Object = new(this, "#2bk", 0, typeof(System.Object));
					r_R__0__2bk_Object.SetBelong(this.instance);
				}
				return r_R__0__2bk_Object;
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


        public R__0__3bk() : base("MiniJSON.Json+#3bk")
        {
        }

        public R__0__3bk(System.Object instance) : base("MiniJSON.Json+#3bk")
		{
            SetInstance(instance);
		}

        public R__0__3bk(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__3bk(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.String Serialize(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RSerialize_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void __0__Ybk(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = R__0__Ybk_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Zbk(System.Collections.IDictionary  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = R__0__Zbk_IDictionary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__0bk(System.Collections.IList  @anArray)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anArray};
            var ___result = R__0__0bk_IList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__1bk(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = R__0__1bk_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__2bk(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = R__0__2bk_Object.Invoke(___genericsType, ___parameters);

            
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