using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#jig
	/// </summary>
    public partial class R__0__jig : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,Creature] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RCreature> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RCreature> R__0__a
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
		/// System.Int32 #b
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
		/// System.Collections.Generic.List`1[GameDefineType.ID] #d
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> r___0__d;
		public virtual RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> R__0__d
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
		/// System.Single #e
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
		/// System.Boolean #f
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
		/// Void Initial()
		/// </summary>
		protected RMethod r_RInitial;
		public virtual RMethod RInitial
		{
			get
			{
				if(r_RInitial == null)
				{
					r_RInitial = new(this, "Initial", 0);
					r_RInitial.SetBelong(this.instance);
				}
				return r_RInitial;
			}
		}

		/// <summary>
		/// Void #odg()
		/// </summary>
		protected RMethod r_R__0__odg;
		public virtual RMethod R__0__odg
		{
			get
			{
				if(r_R__0__odg == null)
				{
					r_R__0__odg = new(this, "#odg", 0);
					r_R__0__odg.SetBelong(this.instance);
				}
				return r_R__0__odg;
			}
		}

		/// <summary>
		/// Void #3hg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__3hg_Object___0__Isb;
		public virtual RMethod R__0__3hg_Object___0__Isb
		{
			get
			{
				if(r_R__0__3hg_Object___0__Isb == null)
				{
					r_R__0__3hg_Object___0__Isb = new(this, "#3hg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__3hg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__3hg_Object___0__Isb;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #5hg(Int32)
		/// </summary>
		protected RMethod r_R__0__5hg_Int32;
		public virtual RMethod R__0__5hg_Int32
		{
			get
			{
				if(r_R__0__5hg_Int32 == null)
				{
					r_R__0__5hg_Int32 = new(this, "#5hg", 0, typeof(System.Int32));
					r_R__0__5hg_Int32.SetBelong(this.instance);
				}
				return r_R__0__5hg_Int32;
			}
		}

		/// <summary>
		/// Void #6hg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__6hg_Object___0__Isb;
		public virtual RMethod R__0__6hg_Object___0__Isb
		{
			get
			{
				if(r_R__0__6hg_Object___0__Isb == null)
				{
					r_R__0__6hg_Object___0__Isb = new(this, "#6hg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__6hg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__6hg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #7hg(System.Object)
		/// </summary>
		protected RMethod r_R__0__7hg_Object;
		public virtual RMethod R__0__7hg_Object
		{
			get
			{
				if(r_R__0__7hg_Object == null)
				{
					r_R__0__7hg_Object = new(this, "#7hg", 0, typeof(System.Object));
					r_R__0__7hg_Object.SetBelong(this.instance);
				}
				return r_R__0__7hg_Object;
			}
		}

		/// <summary>
		/// Void #8hg(System.Object)
		/// </summary>
		protected RMethod r_R__0__8hg_Object;
		public virtual RMethod R__0__8hg_Object
		{
			get
			{
				if(r_R__0__8hg_Object == null)
				{
					r_R__0__8hg_Object = new(this, "#8hg", 0, typeof(System.Object));
					r_R__0__8hg_Object.SetBelong(this.instance);
				}
				return r_R__0__8hg_Object;
			}
		}

		/// <summary>
		/// Void #4Lg(System.Object)
		/// </summary>
		protected RMethod r_R__0__4Lg_Object;
		public virtual RMethod R__0__4Lg_Object
		{
			get
			{
				if(r_R__0__4Lg_Object == null)
				{
					r_R__0__4Lg_Object = new(this, "#4Lg", 0, typeof(System.Object));
					r_R__0__4Lg_Object.SetBelong(this.instance);
				}
				return r_R__0__4Lg_Object;
			}
		}

		/// <summary>
		/// Void #9hg()
		/// </summary>
		protected RMethod r_R__0__9hg;
		public virtual RMethod R__0__9hg
		{
			get
			{
				if(r_R__0__9hg == null)
				{
					r_R__0__9hg = new(this, "#9hg", 0);
					r_R__0__9hg.SetBelong(this.instance);
				}
				return r_R__0__9hg;
			}
		}

		/// <summary>
		/// Void #aig()
		/// </summary>
		protected RMethod r_R__0__aig;
		public virtual RMethod R__0__aig
		{
			get
			{
				if(r_R__0__aig == null)
				{
					r_R__0__aig = new(this, "#aig", 0);
					r_R__0__aig.SetBelong(this.instance);
				}
				return r_R__0__aig;
			}
		}

		/// <summary>
		/// Void #big()
		/// </summary>
		protected RMethod r_R__0__big;
		public virtual RMethod R__0__big
		{
			get
			{
				if(r_R__0__big == null)
				{
					r_R__0__big = new(this, "#big", 0);
					r_R__0__big.SetBelong(this.instance);
				}
				return r_R__0__big;
			}
		}

		/// <summary>
		/// Boolean #cig()
		/// </summary>
		protected RMethod r_R__0__cig;
		public virtual RMethod R__0__cig
		{
			get
			{
				if(r_R__0__cig == null)
				{
					r_R__0__cig = new(this, "#cig", 0);
					r_R__0__cig.SetBelong(this.instance);
				}
				return r_R__0__cig;
			}
		}

		/// <summary>
		/// Void #dig(Int32)
		/// </summary>
		protected RMethod r_R__0__dig_Int32;
		public virtual RMethod R__0__dig_Int32
		{
			get
			{
				if(r_R__0__dig_Int32 == null)
				{
					r_R__0__dig_Int32 = new(this, "#dig", 0, typeof(System.Int32));
					r_R__0__dig_Int32.SetBelong(this.instance);
				}
				return r_R__0__dig_Int32;
			}
		}

		/// <summary>
		/// Void #eig(Int32)
		/// </summary>
		protected RMethod r_R__0__eig_Int32;
		public virtual RMethod R__0__eig_Int32
		{
			get
			{
				if(r_R__0__eig_Int32 == null)
				{
					r_R__0__eig_Int32 = new(this, "#eig", 0, typeof(System.Int32));
					r_R__0__eig_Int32.SetBelong(this.instance);
				}
				return r_R__0__eig_Int32;
			}
		}

		/// <summary>
		/// Void #fig()
		/// </summary>
		protected RMethod r_R__0__fig;
		public virtual RMethod R__0__fig
		{
			get
			{
				if(r_R__0__fig == null)
				{
					r_R__0__fig = new(this, "#fig", 0);
					r_R__0__fig.SetBelong(this.instance);
				}
				return r_R__0__fig;
			}
		}

		/// <summary>
		/// Void ContinueZazen(System.Object)
		/// </summary>
		protected RMethod r_RContinueZazen_Object;
		public virtual RMethod RContinueZazen_Object
		{
			get
			{
				if(r_RContinueZazen_Object == null)
				{
					r_RContinueZazen_Object = new(this, "ContinueZazen", 0, typeof(System.Object));
					r_RContinueZazen_Object.SetBelong(this.instance);
				}
				return r_RContinueZazen_Object;
			}
		}

		/// <summary>
		/// Void CancelDoubleZazen(System.Object, Boolean)
		/// </summary>
		protected RMethod r_RCancelDoubleZazen_Object_Boolean;
		public virtual RMethod RCancelDoubleZazen_Object_Boolean
		{
			get
			{
				if(r_RCancelDoubleZazen_Object_Boolean == null)
				{
					r_RCancelDoubleZazen_Object_Boolean = new(this, "CancelDoubleZazen", 0, typeof(System.Object), typeof(System.Boolean));
					r_RCancelDoubleZazen_Object_Boolean.SetBelong(this.instance);
				}
				return r_RCancelDoubleZazen_Object_Boolean;
			}
		}

		/// <summary>
		/// Void #gig(Int32)
		/// </summary>
		protected RMethod r_R__0__gig_Int32;
		public virtual RMethod R__0__gig_Int32
		{
			get
			{
				if(r_R__0__gig_Int32 == null)
				{
					r_R__0__gig_Int32 = new(this, "#gig", 0, typeof(System.Int32));
					r_R__0__gig_Int32.SetBelong(this.instance);
				}
				return r_R__0__gig_Int32;
			}
		}

		/// <summary>
		/// Void #hig(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__hig_Object_Object;
		public virtual RMethod R__0__hig_Object_Object
		{
			get
			{
				if(r_R__0__hig_Object_Object == null)
				{
					r_R__0__hig_Object_Object = new(this, "#hig", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__hig_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__hig_Object_Object;
			}
		}

		/// <summary>
		/// Void #9cg(Int64)
		/// </summary>
		protected RMethod r_R__0__9cg_Int64;
		public virtual RMethod R__0__9cg_Int64
		{
			get
			{
				if(r_R__0__9cg_Int64 == null)
				{
					r_R__0__9cg_Int64 = new(this, "#9cg", 0, typeof(System.Int64));
					r_R__0__9cg_Int64.SetBelong(this.instance);
				}
				return r_R__0__9cg_Int64;
			}
		}

		/// <summary>
		/// Character #Rih(System.String)
		/// </summary>
		protected RMethod r_R__0__Rih_String;
		public virtual RMethod R__0__Rih_String
		{
			get
			{
				if(r_R__0__Rih_String == null)
				{
					r_R__0__Rih_String = new(this, "#Rih", 0, typeof(System.String));
					r_R__0__Rih_String.SetBelong(this.instance);
				}
				return r_R__0__Rih_String;
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


        public R__0__jig() : base("#u.#jig")
        {
        }

        public R__0__jig(System.Object instance) : base("#u.#jig")
		{
            SetInstance(instance);
		}

        public R__0__jig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__jig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__odg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__odg.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Collections.IEnumerator __0__5hg(System.Int32  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = R__0__5hg_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }



        public virtual void __0__7hg(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__7hg_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__8hg(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__8hg_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__4Lg(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__4Lg_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__9hg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__9hg.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__aig()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__aig.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__big()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__big.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__cig()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__cig.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__dig(System.Int32  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = R__0__dig_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__eig(System.Int32  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = R__0__eig_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__fig()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__fig.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ContinueZazen(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RContinueZazen_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelDoubleZazen(System.Object  @data, System.Boolean  @isCheck)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @isCheck};
            var ___result = RCancelDoubleZazen_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__gig(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__gig_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__hig(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__hig_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__9cg(System.Int64  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = R__0__9cg_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object __0__Rih(System.String  @loverName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@loverName};
            var ___result = R__0__Rih_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
