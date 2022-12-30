using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RAudio
{
	/// <summary>
	/// UnityEngine.Audio.AudioMixer
	/// </summary>
    public partial class RAudioMixer : RMember //
    {

		/// <summary>
		/// UnityEngine.Audio.AudioMixerGroup outputAudioMixerGroup
		/// </summary>
		protected RUnityEngine.RAudio.RAudioMixerGroup r_outputAudioMixerGroup;
		public virtual RUnityEngine.RAudio.RAudioMixerGroup RoutputAudioMixerGroup
		{
			get
			{
				if(r_outputAudioMixerGroup == null)
				{
					r_outputAudioMixerGroup = new(this, "outputAudioMixerGroup", -1);
					r_outputAudioMixerGroup.SetBelong(this.instance);
				}
				return r_outputAudioMixerGroup;
			}
		}

		/// <summary>
		/// UnityEngine.Audio.AudioMixerUpdateMode updateMode
		/// </summary>
		protected RProperty r_updateMode;
		public virtual RProperty RupdateMode
		{
			get
			{
				if(r_updateMode == null)
				{
					r_updateMode = new(this, "updateMode", -1);
					r_updateMode.SetBelong(this.instance);
				}
				return r_updateMode;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// UnityEngine.Audio.AudioMixerSnapshot FindSnapshot(System.String)
		/// </summary>
		protected RMethod r_RFindSnapshot_String;
		public virtual RMethod RFindSnapshot_String
		{
			get
			{
				if(r_RFindSnapshot_String == null)
				{
					r_RFindSnapshot_String = new(this, "FindSnapshot", 0, typeof(System.String));
					r_RFindSnapshot_String.SetBelong(this.instance);
				}
				return r_RFindSnapshot_String;
			}
		}

		/// <summary>
		/// UnityEngine.Audio.AudioMixerGroup[] FindMatchingGroups(System.String)
		/// </summary>
		protected RMethod r_RFindMatchingGroups_String;
		public virtual RMethod RFindMatchingGroups_String
		{
			get
			{
				if(r_RFindMatchingGroups_String == null)
				{
					r_RFindMatchingGroups_String = new(this, "FindMatchingGroups", 0, typeof(System.String));
					r_RFindMatchingGroups_String.SetBelong(this.instance);
				}
				return r_RFindMatchingGroups_String;
			}
		}

		/// <summary>
		/// Void TransitionToSnapshot(UnityEngine.Audio.AudioMixerSnapshot, Single)
		/// </summary>
		protected RMethod r_RTransitionToSnapshot_AudioMixerSnapshot_Single;
		public virtual RMethod RTransitionToSnapshot_AudioMixerSnapshot_Single
		{
			get
			{
				if(r_RTransitionToSnapshot_AudioMixerSnapshot_Single == null)
				{
					r_RTransitionToSnapshot_AudioMixerSnapshot_Single = new(this, "TransitionToSnapshot", 0, typeof(UnityEngine.Audio.AudioMixerSnapshot), typeof(System.Single));
					r_RTransitionToSnapshot_AudioMixerSnapshot_Single.SetBelong(this.instance);
				}
				return r_RTransitionToSnapshot_AudioMixerSnapshot_Single;
			}
		}

		/// <summary>
		/// Void TransitionToSnapshotInternal(UnityEngine.Audio.AudioMixerSnapshot, Single)
		/// </summary>
		protected RMethod r_RTransitionToSnapshotInternal_AudioMixerSnapshot_Single;
		public virtual RMethod RTransitionToSnapshotInternal_AudioMixerSnapshot_Single
		{
			get
			{
				if(r_RTransitionToSnapshotInternal_AudioMixerSnapshot_Single == null)
				{
					r_RTransitionToSnapshotInternal_AudioMixerSnapshot_Single = new(this, "TransitionToSnapshotInternal", 0, typeof(UnityEngine.Audio.AudioMixerSnapshot), typeof(System.Single));
					r_RTransitionToSnapshotInternal_AudioMixerSnapshot_Single.SetBelong(this.instance);
				}
				return r_RTransitionToSnapshotInternal_AudioMixerSnapshot_Single;
			}
		}

		/// <summary>
		/// Void TransitionToSnapshots(UnityEngine.Audio.AudioMixerSnapshot[], Single[], Single)
		/// </summary>
		protected RMethod r_RTransitionToSnapshots_AudioMixerSnapshotArray_SingleArray_Single;
		public virtual RMethod RTransitionToSnapshots_AudioMixerSnapshotArray_SingleArray_Single
		{
			get
			{
				if(r_RTransitionToSnapshots_AudioMixerSnapshotArray_SingleArray_Single == null)
				{
					r_RTransitionToSnapshots_AudioMixerSnapshotArray_SingleArray_Single = new(this, "TransitionToSnapshots", 0, typeof(UnityEngine.Audio.AudioMixerSnapshot).MakeArrayType(), typeof(System.Single).MakeArrayType(), typeof(System.Single));
					r_RTransitionToSnapshots_AudioMixerSnapshotArray_SingleArray_Single.SetBelong(this.instance);
				}
				return r_RTransitionToSnapshots_AudioMixerSnapshotArray_SingleArray_Single;
			}
		}

		/// <summary>
		/// Boolean SetFloat(System.String, Single)
		/// </summary>
		protected RMethod r_RSetFloat_String_Single;
		public virtual RMethod RSetFloat_String_Single
		{
			get
			{
				if(r_RSetFloat_String_Single == null)
				{
					r_RSetFloat_String_Single = new(this, "SetFloat", 0, typeof(System.String), typeof(System.Single));
					r_RSetFloat_String_Single.SetBelong(this.instance);
				}
				return r_RSetFloat_String_Single;
			}
		}

		/// <summary>
		/// Boolean ClearFloat(System.String)
		/// </summary>
		protected RMethod r_RClearFloat_String;
		public virtual RMethod RClearFloat_String
		{
			get
			{
				if(r_RClearFloat_String == null)
				{
					r_RClearFloat_String = new(this, "ClearFloat", 0, typeof(System.String));
					r_RClearFloat_String.SetBelong(this.instance);
				}
				return r_RClearFloat_String;
			}
		}

		/// <summary>
		/// Boolean GetFloat(System.String, Single ByRef)
		/// </summary>
		protected RMethod r_RGetFloat_String_Out_Single;
		public virtual RMethod RGetFloat_String_Out_Single
		{
			get
			{
				if(r_RGetFloat_String_Out_Single == null)
				{
					r_RGetFloat_String_Out_Single = new(this, "GetFloat", 0, typeof(System.String), typeof(System.Single).MakeByRefType());
					r_RGetFloat_String_Out_Single.SetBelong(this.instance);
				}
				return r_RGetFloat_String_Out_Single;
			}
		}

		/// <summary>
		/// Single GetAbsoluteAudibilityFromGroup(UnityEngine.Audio.AudioMixerGroup)
		/// </summary>
		protected RMethod r_RGetAbsoluteAudibilityFromGroup_AudioMixerGroup;
		public virtual RMethod RGetAbsoluteAudibilityFromGroup_AudioMixerGroup
		{
			get
			{
				if(r_RGetAbsoluteAudibilityFromGroup_AudioMixerGroup == null)
				{
					r_RGetAbsoluteAudibilityFromGroup_AudioMixerGroup = new(this, "GetAbsoluteAudibilityFromGroup", 0, typeof(UnityEngine.Audio.AudioMixerGroup));
					r_RGetAbsoluteAudibilityFromGroup_AudioMixerGroup.SetBelong(this.instance);
				}
				return r_RGetAbsoluteAudibilityFromGroup_AudioMixerGroup;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
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


        public RAudioMixer() : base("UnityEngine.Audio.AudioMixer")
        {
        }

        public RAudioMixer(System.Object instance) : base("UnityEngine.Audio.AudioMixer")
		{
            SetInstance(instance);
		}

        public RAudioMixer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAudioMixer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.Audio.AudioMixerSnapshot FindSnapshot(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFindSnapshot_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Audio.AudioMixerSnapshot)___result;
        }


        public virtual UnityEngine.Audio.AudioMixerGroup[] FindMatchingGroups(System.String  @subPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subPath};
            var ___result = RFindMatchingGroups_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Audio.AudioMixerGroup[])___result;
        }


        public virtual void TransitionToSnapshot(UnityEngine.Audio.AudioMixerSnapshot  @snapshot, System.Single  @timeToReach)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@snapshot, @timeToReach};
            var ___result = RTransitionToSnapshot_AudioMixerSnapshot_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TransitionToSnapshotInternal(UnityEngine.Audio.AudioMixerSnapshot  @snapshot, System.Single  @timeToReach)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@snapshot, @timeToReach};
            var ___result = RTransitionToSnapshotInternal_AudioMixerSnapshot_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TransitionToSnapshots(UnityEngine.Audio.AudioMixerSnapshot[]  @snapshots, System.Single[]  @weights, System.Single  @timeToReach)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@snapshots, @weights, @timeToReach};
            var ___result = RTransitionToSnapshots_AudioMixerSnapshotArray_SingleArray_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetFloat(System.String  @name, System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetFloat_String_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ClearFloat(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RClearFloat_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetFloat(System.String  @name, out System.Single  @value)
        {
			value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RGetFloat_String_Out_Single.Invoke(___genericsType, ___parameters);
			value = (System.Single)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Single GetAbsoluteAudibilityFromGroup(UnityEngine.Audio.AudioMixerGroup  @group)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@group};
            var ___result = RGetAbsoluteAudibilityFromGroup_AudioMixerGroup.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
