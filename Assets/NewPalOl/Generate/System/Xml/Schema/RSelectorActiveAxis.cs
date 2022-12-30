using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.SelectorActiveAxis
	/// </summary>
    public partial class RSelectorActiveAxis : RMember //
    {

		/// <summary>
		/// System.Xml.Schema.ConstraintStruct cs
		/// </summary>
		protected RSystem.RXml.RSchema.RConstraintStruct r_cs;
		public virtual RSystem.RXml.RSchema.RConstraintStruct Rcs
		{
			get
			{
				if(r_cs == null)
				{
					r_cs = new(this, "cs");
					r_cs.SetBelong(this.instance);
				}
				return r_cs;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList KSs
		/// </summary>
		protected RSystem.RCollections.RArrayList r_KSs;
		public virtual RSystem.RCollections.RArrayList RKSs
		{
			get
			{
				if(r_KSs == null)
				{
					r_KSs = new(this, "KSs");
					r_KSs.SetBelong(this.instance);
				}
				return r_KSs;
			}
		}

		/// <summary>
		/// System.Int32 KSpointer
		/// </summary>
		protected RField r_KSpointer;
		public virtual RField RKSpointer
		{
			get
			{
				if(r_KSpointer == null)
				{
					r_KSpointer = new(this, "KSpointer");
					r_KSpointer.SetBelong(this.instance);
				}
				return r_KSpointer;
			}
		}

		/// <summary>
		/// Boolean EmptyStack
		/// </summary>
		protected RProperty r_EmptyStack;
		public virtual RProperty REmptyStack
		{
			get
			{
				if(r_EmptyStack == null)
				{
					r_EmptyStack = new(this, "EmptyStack", -1);
					r_EmptyStack.SetBelong(this.instance);
				}
				return r_EmptyStack;
			}
		}

		/// <summary>
		/// Int32 lastDepth
		/// </summary>
		protected RProperty r_lastDepth;
		public virtual RProperty RlastDepth
		{
			get
			{
				if(r_lastDepth == null)
				{
					r_lastDepth = new(this, "lastDepth", -1);
					r_lastDepth.SetBelong(this.instance);
				}
				return r_lastDepth;
			}
		}

		/// <summary>
		/// Int32 CurrentDepth
		/// </summary>
		protected RProperty r_CurrentDepth;
		public virtual RProperty RCurrentDepth
		{
			get
			{
				if(r_CurrentDepth == null)
				{
					r_CurrentDepth = new(this, "CurrentDepth", -1);
					r_CurrentDepth.SetBelong(this.instance);
				}
				return r_CurrentDepth;
			}
		}

		/// <summary>
		/// Boolean EndElement(System.String, System.String)
		/// </summary>
		protected RMethod r_REndElement_String_String;
		public virtual RMethod REndElement_String_String
		{
			get
			{
				if(r_REndElement_String_String == null)
				{
					r_REndElement_String_String = new(this, "EndElement", 0, typeof(System.String), typeof(System.String));
					r_REndElement_String_String.SetBelong(this.instance);
				}
				return r_REndElement_String_String;
			}
		}

		/// <summary>
		/// Int32 PushKS(Int32, Int32)
		/// </summary>
		protected RMethod r_RPushKS_Int32_Int32;
		public virtual RMethod RPushKS_Int32_Int32
		{
			get
			{
				if(r_RPushKS_Int32_Int32 == null)
				{
					r_RPushKS_Int32_Int32 = new(this, "PushKS", 0, typeof(System.Int32), typeof(System.Int32));
					r_RPushKS_Int32_Int32.SetBelong(this.instance);
				}
				return r_RPushKS_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Xml.Schema.KeySequence PopKS()
		/// </summary>
		protected RMethod r_RPopKS;
		public virtual RMethod RPopKS
		{
			get
			{
				if(r_RPopKS == null)
				{
					r_RPopKS = new(this, "PopKS", 0);
					r_RPopKS.SetBelong(this.instance);
				}
				return r_RPopKS;
			}
		}

		/// <summary>
		/// Void Reactivate()
		/// </summary>
		protected RMethod r_RReactivate;
		public virtual RMethod RReactivate
		{
			get
			{
				if(r_RReactivate == null)
				{
					r_RReactivate = new(this, "Reactivate", 0);
					r_RReactivate.SetBelong(this.instance);
				}
				return r_RReactivate;
			}
		}

		/// <summary>
		/// Boolean MoveToStartElement(System.String, System.String)
		/// </summary>
		protected RMethod r_RMoveToStartElement_String_String;
		public virtual RMethod RMoveToStartElement_String_String
		{
			get
			{
				if(r_RMoveToStartElement_String_String == null)
				{
					r_RMoveToStartElement_String_String = new(this, "MoveToStartElement", 0, typeof(System.String), typeof(System.String));
					r_RMoveToStartElement_String_String.SetBelong(this.instance);
				}
				return r_RMoveToStartElement_String_String;
			}
		}

		/// <summary>
		/// Boolean MoveToAttribute(System.String, System.String)
		/// </summary>
		protected RMethod r_RMoveToAttribute_String_String;
		public virtual RMethod RMoveToAttribute_String_String
		{
			get
			{
				if(r_RMoveToAttribute_String_String == null)
				{
					r_RMoveToAttribute_String_String = new(this, "MoveToAttribute", 0, typeof(System.String), typeof(System.String));
					r_RMoveToAttribute_String_String.SetBelong(this.instance);
				}
				return r_RMoveToAttribute_String_String;
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


        public RSelectorActiveAxis() : base("System.Xml.Schema.SelectorActiveAxis")
        {
        }

        public RSelectorActiveAxis(System.Object instance) : base("System.Xml.Schema.SelectorActiveAxis")
		{
            SetInstance(instance);
		}

        public RSelectorActiveAxis(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSelectorActiveAxis(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean EndElement(System.String  @localname, System.String  @URN)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localname, @URN};
            var ___result = REndElement_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 PushKS(System.Int32  @errline, System.Int32  @errcol)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@errline, @errcol};
            var ___result = RPushKS_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object PopKS()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPopKS.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Reactivate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReactivate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveToStartElement(System.String  @localname, System.String  @URN)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localname, @URN};
            var ___result = RMoveToStartElement_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToAttribute(System.String  @localname, System.String  @URN)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localname, @URN};
            var ___result = RMoveToAttribute_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
