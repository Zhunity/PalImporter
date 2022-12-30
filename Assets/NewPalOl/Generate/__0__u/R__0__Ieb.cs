using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#Ieb
	/// </summary>
    public partial class R__0__Ieb : RMember //
    {

		/// <summary>
		/// Creature #a
		/// </summary>
		protected RCreature r___0__a;
		public virtual RCreature R__0__a
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
		/// System.Collections.Generic.Dictionary`2[System.String,System.Object] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RObject> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RObject> R__0__b
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
		/// System.Collections.Generic.List`1[System.String] #c
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RField> r___0__c;
		public static RSystem.RCollections.RGeneric.RList<RField> R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new( ReleactionUtils.GetType("#u.#Ieb"), "#c");
					r___0__c.SetBelong(null);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// System.Boolean #d
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
		/// Creature Owner
		/// </summary>
		protected RCreature r_R__0__Eeb;
		public virtual RCreature R__0__Eeb
		{
			get
			{
				if(r_R__0__Eeb == null)
				{
					r_R__0__Eeb = new(this, "Owner", -1);
					r_R__0__Eeb.SetBelong(this.instance);
				}
				return r_R__0__Eeb;
			}
		}

		/// <summary>
		/// Int32 ComponentID
		/// </summary>
		protected RProperty r_R__0__Seb;
		public virtual RProperty R__0__Seb
		{
			get
			{
				if(r_R__0__Seb == null)
				{
					r_R__0__Seb = new(this, "ComponentID", -1);
					r_R__0__Seb.SetBelong(this.instance);
				}
				return r_R__0__Seb;
			}
		}

		/// <summary>
		/// System.Object #Feb(System.String)
		/// </summary>
		protected RMethod r_R__0__Feb_String;
		public virtual RMethod R__0__Feb_String
		{
			get
			{
				if(r_R__0__Feb_String == null)
				{
					r_R__0__Feb_String = new(this, "#Feb", 0, typeof(System.String));
					r_R__0__Feb_String.SetBelong(this.instance);
				}
				return r_R__0__Feb_String;
			}
		}

		/// <summary>
		/// System.Object #Geb(System.String)
		/// </summary>
		protected RMethod r_R__0__Geb_String;
		public virtual RMethod R__0__Geb_String
		{
			get
			{
				if(r_R__0__Geb_String == null)
				{
					r_R__0__Geb_String = new(this, "#Geb", 0, typeof(System.String));
					r_R__0__Geb_String.SetBelong(this.instance);
				}
				return r_R__0__Geb_String;
			}
		}

		/// <summary>
		/// Void #Heb(System.String, System.Object)
		/// </summary>
		protected RMethod r_R__0__Heb_String_Object;
		public virtual RMethod R__0__Heb_String_Object
		{
			get
			{
				if(r_R__0__Heb_String_Object == null)
				{
					r_R__0__Heb_String_Object = new(this, "#Heb", 0, typeof(System.String), typeof(System.Object));
					r_R__0__Heb_String_Object.SetBelong(this.instance);
				}
				return r_R__0__Heb_String_Object;
			}
		}

		/// <summary>
		/// Void #dyi(System.String, System.Object)
		/// </summary>
		protected RMethod r_R__0__dyi_String_Object;
		public virtual RMethod R__0__dyi_String_Object
		{
			get
			{
				if(r_R__0__dyi_String_Object == null)
				{
					r_R__0__dyi_String_Object = new(this, "#dyi", 0, typeof(System.String), typeof(System.Object));
					r_R__0__dyi_String_Object.SetBelong(this.instance);
				}
				return r_R__0__dyi_String_Object;
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


        public R__0__Ieb() : base("#u.#Ieb")
        {
        }

        public R__0__Ieb(System.Object instance) : base("#u.#Ieb")
		{
            SetInstance(instance);
		}

        public R__0__Ieb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Ieb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object __0__Feb(System.String  @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName};
            var ___result = R__0__Feb_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__Geb(System.String  @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName};
            var ___result = R__0__Geb_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__Heb(System.String  @propertyName, System.Object  @propertyValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @propertyValue};
            var ___result = R__0__Heb_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__dyi(System.String  @propertyName, System.Object  @propertyValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @propertyValue};
            var ___result = R__0__dyi_String_Object.Invoke(___genericsType, ___parameters);

            
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
