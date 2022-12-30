using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{public partial class R__0__Kib
{
	
	/// <summary>
	/// #u.#Kib+#Sib
	/// </summary>
    public partial class R__0__Sib : RMember //
    {

		/// <summary>
		/// GameDefineType.ID #a
		/// </summary>
		protected RGameDefineType.RID r___0__a;
		public virtual RGameDefineType.RID R__0__a
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
		/// GameDefineType.ID[] #b
		/// </summary>
		protected RFieldArray<RGameDefineType.RID> r___0__b;
		public virtual RFieldArray<RGameDefineType.RID> R__0__b
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
		/// UnityEngine.Vector3 #d
		/// </summary>
		protected RUnityEngine.RVector3 r___0__d;
		public virtual RUnityEngine.RVector3 R__0__d
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
		/// System.Collections.Generic.List`1[UnityEngine.Vector3] #e
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RVector3> r___0__e;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RVector3> R__0__e
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
		/// Boolean #vib(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_R__0__vib_Vector3;
		public virtual RMethod R__0__vib_Vector3
		{
			get
			{
				if(r_R__0__vib_Vector3 == null)
				{
					r_R__0__vib_Vector3 = new(this, "#vib", 0, typeof(UnityEngine.Vector3));
					r_R__0__vib_Vector3.SetBelong(this.instance);
				}
				return r_R__0__vib_Vector3;
			}
		}

		/// <summary>
		/// Boolean #Qib(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_R__0__Qib_Vector3_Vector3;
		public virtual RMethod R__0__Qib_Vector3_Vector3
		{
			get
			{
				if(r_R__0__Qib_Vector3_Vector3 == null)
				{
					r_R__0__Qib_Vector3_Vector3 = new(this, "#Qib", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_R__0__Qib_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_R__0__Qib_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void #Rib()
		/// </summary>
		protected RMethod r_R__0__Rib;
		public virtual RMethod R__0__Rib
		{
			get
			{
				if(r_R__0__Rib == null)
				{
					r_R__0__Rib = new(this, "#Rib", 0);
					r_R__0__Rib.SetBelong(this.instance);
				}
				return r_R__0__Rib;
			}
		}

		/// <summary>
		/// Void Reset(Single)
		/// </summary>
		protected RMethod r_RReset_Single;
		public virtual RMethod RReset_Single
		{
			get
			{
				if(r_RReset_Single == null)
				{
					r_RReset_Single = new(this, "Reset", 0, typeof(System.Single));
					r_RReset_Single.SetBelong(this.instance);
				}
				return r_RReset_Single;
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


        public R__0__Sib() : base("#u.#Kib+#Sib")
        {
        }

        public R__0__Sib(System.Object instance) : base("#u.#Kib+#Sib")
		{
            SetInstance(instance);
		}

        public R__0__Sib(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Sib(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean __0__vib(UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = R__0__vib_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__Qib(UnityEngine.Vector3  @pos1, UnityEngine.Vector3  @pos2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos1, @pos2};
            var ___result = R__0__Qib_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__Rib()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Rib.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset(System.Single  @spd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spd};
            var ___result = RReset_Single.Invoke(___genericsType, ___parameters);

            
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