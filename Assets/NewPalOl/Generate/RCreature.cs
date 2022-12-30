using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// Creature
	/// </summary>
    public partial class RCreature : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[#u.#Reb,#u.#Ueb] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, R__0__u.R__0__Ueb> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, R__0__u.R__0__Ueb> R__0__a
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
		/// UnityEngine.GameObject #b
		/// </summary>
		protected RUnityEngine.RGameObject r___0__b;
		public virtual RUnityEngine.RGameObject R__0__b
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
		/// UnityEngine.Transform #c
		/// </summary>
		protected RUnityEngine.RTransform r___0__c;
		public virtual RUnityEngine.RTransform R__0__c
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
		/// UnityEngine.GameObject #d
		/// </summary>
		protected RUnityEngine.RGameObject r___0__d;
		public virtual RUnityEngine.RGameObject R__0__d
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
		/// CreatureBehav #e
		/// </summary>
		protected RCreatureBehav r___0__e;
		public virtual RCreatureBehav R__0__e
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
		/// GameDefineType.ID #f
		/// </summary>
		protected RGameDefineType.RID r___0__f;
		public virtual RGameDefineType.RID R__0__f
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
		/// System.Collections.Generic.Dictionary`2[System.String,#u.#sOb] #g
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, R__0__u.R__0__sOb> r___0__g;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, R__0__u.R__0__sOb> R__0__g
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
		/// UnityEngine.Transform m_ctrlTransform
		/// </summary>
		protected RUnityEngine.RTransform r_R__0__Hdb;
		public virtual RUnityEngine.RTransform R__0__Hdb
		{
			get
			{
				if(r_R__0__Hdb == null)
				{
					r_R__0__Hdb = new(this, "m_ctrlTransform", -1);
					r_R__0__Hdb.SetBelong(this.instance);
				}
				return r_R__0__Hdb;
			}
		}

		/// <summary>
		/// CreatureBehav m_behav
		/// </summary>
		protected RCreatureBehav r_R__0__Idb;
		public virtual RCreatureBehav R__0__Idb
		{
			get
			{
				if(r_R__0__Idb == null)
				{
					r_R__0__Idb = new(this, "m_behav", -1);
					r_R__0__Idb.SetBelong(this.instance);
				}
				return r_R__0__Idb;
			}
		}

		/// <summary>
		/// GameDefineType.ID ID
		/// </summary>
		protected RGameDefineType.RID r_R__0__Mdb;
		public virtual RGameDefineType.RID R__0__Mdb
		{
			get
			{
				if(r_R__0__Mdb == null)
				{
					r_R__0__Mdb = new(this, "ID", -1);
					r_R__0__Mdb.SetBelong(this.instance);
				}
				return r_R__0__Mdb;
			}
		}

		/// <summary>
		/// GameDefineType.ID CareerID
		/// </summary>
		protected RGameDefineType.RID r_R__0__Odb;
		public virtual RGameDefineType.RID R__0__Odb
		{
			get
			{
				if(r_R__0__Odb == null)
				{
					r_R__0__Odb = new(this, "CareerID", -1);
					r_R__0__Odb.SetBelong(this.instance);
				}
				return r_R__0__Odb;
			}
		}

		/// <summary>
		/// #u.#Ueb #Jdb(#u.#Reb)
		/// </summary>
		protected RMethod r_R__0__Jdb___0__Reb;
		public virtual RMethod R__0__Jdb___0__Reb
		{
			get
			{
				if(r_R__0__Jdb___0__Reb == null)
				{
					r_R__0__Jdb___0__Reb = new(this, "#Jdb", 0,  ReleactionUtils.GetType("#u.#Reb"));
					r_R__0__Jdb___0__Reb.SetBelong(this.instance);
				}
				return r_R__0__Jdb___0__Reb;
			}
		}

		/// <summary>
		/// #bk #Jdb[#bk](#u.#Reb)
		/// </summary>
		protected RMethod r_R__0__Jdb_G__0__bk___0__Reb;
		public virtual RMethod R__0__Jdb_G__0__bk___0__Reb
		{
			get
			{
				if(r_R__0__Jdb_G__0__bk___0__Reb == null)
				{
					r_R__0__Jdb_G__0__bk___0__Reb = new(this, "#Jdb", 1,  ReleactionUtils.GetType("#u.#Reb"));
					r_R__0__Jdb_G__0__bk___0__Reb.SetBelong(this.instance);
				}
				return r_R__0__Jdb_G__0__bk___0__Reb;
			}
		}

		/// <summary>
		/// Void #Kdb(#u.#Reb, #u.#Ueb)
		/// </summary>
		protected RMethod r_R__0__Kdb___0__Reb___0__Ueb;
		public virtual RMethod R__0__Kdb___0__Reb___0__Ueb
		{
			get
			{
				if(r_R__0__Kdb___0__Reb___0__Ueb == null)
				{
					r_R__0__Kdb___0__Reb___0__Ueb = new(this, "#Kdb", 0,  ReleactionUtils.GetType("#u.#Reb"),  ReleactionUtils.GetType("#u.#Ueb"));
					r_R__0__Kdb___0__Reb___0__Ueb.SetBelong(this.instance);
				}
				return r_R__0__Kdb___0__Reb___0__Ueb;
			}
		}

		/// <summary>
		/// System.Object GetProperty(System.String)
		/// </summary>
		protected RMethod r_RGetProperty_String;
		public virtual RMethod RGetProperty_String
		{
			get
			{
				if(r_RGetProperty_String == null)
				{
					r_RGetProperty_String = new(this, "GetProperty", 0, typeof(System.String));
					r_RGetProperty_String.SetBelong(this.instance);
				}
				return r_RGetProperty_String;
			}
		}

		/// <summary>
		/// Void #yhd()
		/// </summary>
		protected RMethod r_R__0__yhd;
		public virtual RMethod R__0__yhd
		{
			get
			{
				if(r_R__0__yhd == null)
				{
					r_R__0__yhd = new(this, "#yhd", 0);
					r_R__0__yhd.SetBelong(this.instance);
				}
				return r_R__0__yhd;
			}
		}

		/// <summary>
		/// Void #Pdb(System.String, #u.#sOb)
		/// </summary>
		protected RMethod r_R__0__Pdb_String___0__sOb;
		public virtual RMethod R__0__Pdb_String___0__sOb
		{
			get
			{
				if(r_R__0__Pdb_String___0__sOb == null)
				{
					r_R__0__Pdb_String___0__sOb = new(this, "#Pdb", 0, typeof(System.String),  ReleactionUtils.GetType("#u.#sOb"));
					r_R__0__Pdb_String___0__sOb.SetBelong(this.instance);
				}
				return r_R__0__Pdb_String___0__sOb;
			}
		}

		/// <summary>
		/// Void #i4c(System.String, System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__i4c_String_Object_Object;
		public virtual RMethod R__0__i4c_String_Object_Object
		{
			get
			{
				if(r_R__0__i4c_String_Object_Object == null)
				{
					r_R__0__i4c_String_Object_Object = new(this, "#i4c", 0, typeof(System.String), typeof(System.Object), typeof(System.Object));
					r_R__0__i4c_String_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__i4c_String_Object_Object;
			}
		}

		/// <summary>
		/// Void SetProgressBarOverHead(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RSetProgressBarOverHead_Object_Object;
		public virtual RMethod RSetProgressBarOverHead_Object_Object
		{
			get
			{
				if(r_RSetProgressBarOverHead_Object_Object == null)
				{
					r_RSetProgressBarOverHead_Object_Object = new(this, "SetProgressBarOverHead", 0, typeof(System.Object), typeof(System.Object));
					r_RSetProgressBarOverHead_Object_Object.SetBelong(this.instance);
				}
				return r_RSetProgressBarOverHead_Object_Object;
			}
		}

		/// <summary>
		/// Void SetProgressBarTipOverHead(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RSetProgressBarTipOverHead_Object_Object;
		public virtual RMethod RSetProgressBarTipOverHead_Object_Object
		{
			get
			{
				if(r_RSetProgressBarTipOverHead_Object_Object == null)
				{
					r_RSetProgressBarTipOverHead_Object_Object = new(this, "SetProgressBarTipOverHead", 0, typeof(System.Object), typeof(System.Object));
					r_RSetProgressBarTipOverHead_Object_Object.SetBelong(this.instance);
				}
				return r_RSetProgressBarTipOverHead_Object_Object;
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


        public RCreature() : base("Creature")
        {
        }

        public RCreature(System.Object instance) : base("Creature")
		{
            SetInstance(instance);
		}

        public RCreature(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCreature(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }




        public virtual System.Object GetProperty(System.String  @propName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propName};
            var ___result = RGetProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__yhd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__yhd.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__i4c(System.String  @proptertyName, System.Object  @propertyOldValue, System.Object  @propertyNewValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@proptertyName, @propertyOldValue, @propertyNewValue};
            var ___result = R__0__i4c_String_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetProgressBarOverHead(System.Object  @olddata, System.Object  @newdata)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@olddata, @newdata};
            var ___result = RSetProgressBarOverHead_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetProgressBarTipOverHead(System.Object  @olddata, System.Object  @newdata)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@olddata, @newdata};
            var ___result = RSetProgressBarTipOverHead_Object_Object.Invoke(___genericsType, ___parameters);

            
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
