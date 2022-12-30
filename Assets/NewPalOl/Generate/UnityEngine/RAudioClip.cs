using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.AudioClip
	/// </summary>
    public partial class RAudioClip : RMember //
    {

		/// <summary>
		/// UnityEngine.AudioClip+PCMReaderCallback m_PCMReaderCallback
		/// </summary>
		protected RUnityEngine.RAudioClip.RPCMReaderCallback r_m_PCMReaderCallback;
		public virtual RUnityEngine.RAudioClip.RPCMReaderCallback Rm_PCMReaderCallback
		{
			get
			{
				if(r_m_PCMReaderCallback == null)
				{
					r_m_PCMReaderCallback = new(this, "m_PCMReaderCallback");
					r_m_PCMReaderCallback.SetBelong(this.instance);
				}
				return r_m_PCMReaderCallback;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip+PCMSetPositionCallback m_PCMSetPositionCallback
		/// </summary>
		protected RUnityEngine.RAudioClip.RPCMSetPositionCallback r_m_PCMSetPositionCallback;
		public virtual RUnityEngine.RAudioClip.RPCMSetPositionCallback Rm_PCMSetPositionCallback
		{
			get
			{
				if(r_m_PCMSetPositionCallback == null)
				{
					r_m_PCMSetPositionCallback = new(this, "m_PCMSetPositionCallback");
					r_m_PCMSetPositionCallback.SetBelong(this.instance);
				}
				return r_m_PCMSetPositionCallback;
			}
		}

		/// <summary>
		/// Single length
		/// </summary>
		protected RProperty r_length;
		public virtual RProperty Rlength
		{
			get
			{
				if(r_length == null)
				{
					r_length = new(this, "length", -1);
					r_length.SetBelong(this.instance);
				}
				return r_length;
			}
		}

		/// <summary>
		/// Int32 samples
		/// </summary>
		protected RProperty r_samples;
		public virtual RProperty Rsamples
		{
			get
			{
				if(r_samples == null)
				{
					r_samples = new(this, "samples", -1);
					r_samples.SetBelong(this.instance);
				}
				return r_samples;
			}
		}

		/// <summary>
		/// Int32 channels
		/// </summary>
		protected RProperty r_channels;
		public virtual RProperty Rchannels
		{
			get
			{
				if(r_channels == null)
				{
					r_channels = new(this, "channels", -1);
					r_channels.SetBelong(this.instance);
				}
				return r_channels;
			}
		}

		/// <summary>
		/// Int32 frequency
		/// </summary>
		protected RProperty r_frequency;
		public virtual RProperty Rfrequency
		{
			get
			{
				if(r_frequency == null)
				{
					r_frequency = new(this, "frequency", -1);
					r_frequency.SetBelong(this.instance);
				}
				return r_frequency;
			}
		}

		/// <summary>
		/// Boolean isReadyToPlay
		/// </summary>
		protected RProperty r_isReadyToPlay;
		public virtual RProperty RisReadyToPlay
		{
			get
			{
				if(r_isReadyToPlay == null)
				{
					r_isReadyToPlay = new(this, "isReadyToPlay", -1);
					r_isReadyToPlay.SetBelong(this.instance);
				}
				return r_isReadyToPlay;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClipLoadType loadType
		/// </summary>
		protected RProperty r_loadType;
		public virtual RProperty RloadType
		{
			get
			{
				if(r_loadType == null)
				{
					r_loadType = new(this, "loadType", -1);
					r_loadType.SetBelong(this.instance);
				}
				return r_loadType;
			}
		}

		/// <summary>
		/// Boolean preloadAudioData
		/// </summary>
		protected RProperty r_preloadAudioData;
		public virtual RProperty RpreloadAudioData
		{
			get
			{
				if(r_preloadAudioData == null)
				{
					r_preloadAudioData = new(this, "preloadAudioData", -1);
					r_preloadAudioData.SetBelong(this.instance);
				}
				return r_preloadAudioData;
			}
		}

		/// <summary>
		/// Boolean ambisonic
		/// </summary>
		protected RProperty r_ambisonic;
		public virtual RProperty Rambisonic
		{
			get
			{
				if(r_ambisonic == null)
				{
					r_ambisonic = new(this, "ambisonic", -1);
					r_ambisonic.SetBelong(this.instance);
				}
				return r_ambisonic;
			}
		}

		/// <summary>
		/// Boolean loadInBackground
		/// </summary>
		protected RProperty r_loadInBackground;
		public virtual RProperty RloadInBackground
		{
			get
			{
				if(r_loadInBackground == null)
				{
					r_loadInBackground = new(this, "loadInBackground", -1);
					r_loadInBackground.SetBelong(this.instance);
				}
				return r_loadInBackground;
			}
		}

		/// <summary>
		/// UnityEngine.AudioDataLoadState loadState
		/// </summary>
		protected RProperty r_loadState;
		public virtual RProperty RloadState
		{
			get
			{
				if(r_loadState == null)
				{
					r_loadState = new(this, "loadState", -1);
					r_loadState.SetBelong(this.instance);
				}
				return r_loadState;
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
		/// Boolean GetData(UnityEngine.AudioClip, Single[], Int32, Int32)
		/// </summary>
		protected static RMethod r_RGetData_AudioClip_SingleArray_Int32_Int32;
		public static RMethod RGetData_AudioClip_SingleArray_Int32_Int32
		{
			get
			{
				if(r_RGetData_AudioClip_SingleArray_Int32_Int32 == null)
				{
					r_RGetData_AudioClip_SingleArray_Int32_Int32 = new(typeof(UnityEngine.AudioClip), "GetData", 0, typeof(UnityEngine.AudioClip), typeof(System.Single).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RGetData_AudioClip_SingleArray_Int32_Int32.SetBelong(null);
				}
				return r_RGetData_AudioClip_SingleArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean SetData(UnityEngine.AudioClip, Single[], Int32, Int32)
		/// </summary>
		protected static RMethod r_RSetData_AudioClip_SingleArray_Int32_Int32;
		public static RMethod RSetData_AudioClip_SingleArray_Int32_Int32
		{
			get
			{
				if(r_RSetData_AudioClip_SingleArray_Int32_Int32 == null)
				{
					r_RSetData_AudioClip_SingleArray_Int32_Int32 = new(typeof(UnityEngine.AudioClip), "SetData", 0, typeof(UnityEngine.AudioClip), typeof(System.Single).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RSetData_AudioClip_SingleArray_Int32_Int32.SetBelong(null);
				}
				return r_RSetData_AudioClip_SingleArray_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip Construct_Internal()
		/// </summary>
		protected static RMethod r_RConstruct_Internal;
		public static RMethod RConstruct_Internal
		{
			get
			{
				if(r_RConstruct_Internal == null)
				{
					r_RConstruct_Internal = new(typeof(UnityEngine.AudioClip), "Construct_Internal", 0);
					r_RConstruct_Internal.SetBelong(null);
				}
				return r_RConstruct_Internal;
			}
		}

		/// <summary>
		/// System.String GetName()
		/// </summary>
		protected RMethod r_RGetName;
		public virtual RMethod RGetName
		{
			get
			{
				if(r_RGetName == null)
				{
					r_RGetName = new(this, "GetName", 0);
					r_RGetName.SetBelong(this.instance);
				}
				return r_RGetName;
			}
		}

		/// <summary>
		/// Void CreateUserSound(System.String, Int32, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_RCreateUserSound_String_Int32_Int32_Int32_Boolean;
		public virtual RMethod RCreateUserSound_String_Int32_Int32_Int32_Boolean
		{
			get
			{
				if(r_RCreateUserSound_String_Int32_Int32_Int32_Boolean == null)
				{
					r_RCreateUserSound_String_Int32_Int32_Int32_Boolean = new(this, "CreateUserSound", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RCreateUserSound_String_Int32_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RCreateUserSound_String_Int32_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean LoadAudioData()
		/// </summary>
		protected RMethod r_RLoadAudioData;
		public virtual RMethod RLoadAudioData
		{
			get
			{
				if(r_RLoadAudioData == null)
				{
					r_RLoadAudioData = new(this, "LoadAudioData", 0);
					r_RLoadAudioData.SetBelong(this.instance);
				}
				return r_RLoadAudioData;
			}
		}

		/// <summary>
		/// Boolean UnloadAudioData()
		/// </summary>
		protected RMethod r_RUnloadAudioData;
		public virtual RMethod RUnloadAudioData
		{
			get
			{
				if(r_RUnloadAudioData == null)
				{
					r_RUnloadAudioData = new(this, "UnloadAudioData", 0);
					r_RUnloadAudioData.SetBelong(this.instance);
				}
				return r_RUnloadAudioData;
			}
		}

		/// <summary>
		/// Boolean GetData(Single[], Int32)
		/// </summary>
		protected RMethod r_RGetData_SingleArray_Int32;
		public virtual RMethod RGetData_SingleArray_Int32
		{
			get
			{
				if(r_RGetData_SingleArray_Int32 == null)
				{
					r_RGetData_SingleArray_Int32 = new(this, "GetData", 0, typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_RGetData_SingleArray_Int32.SetBelong(this.instance);
				}
				return r_RGetData_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Boolean SetData(Single[], Int32)
		/// </summary>
		protected RMethod r_RSetData_SingleArray_Int32;
		public virtual RMethod RSetData_SingleArray_Int32
		{
			get
			{
				if(r_RSetData_SingleArray_Int32 == null)
				{
					r_RSetData_SingleArray_Int32 = new(this, "SetData", 0, typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_RSetData_SingleArray_Int32.SetBelong(this.instance);
				}
				return r_RSetData_SingleArray_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip Create(System.String, Int32, Int32, Int32, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_RCreate_String_Int32_Int32_Int32_Boolean_Boolean;
		public static RMethod RCreate_String_Int32_Int32_Int32_Boolean_Boolean
		{
			get
			{
				if(r_RCreate_String_Int32_Int32_Int32_Boolean_Boolean == null)
				{
					r_RCreate_String_Int32_Int32_Int32_Boolean_Boolean = new(typeof(UnityEngine.AudioClip), "Create", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
					r_RCreate_String_Int32_Int32_Int32_Boolean_Boolean.SetBelong(null);
				}
				return r_RCreate_String_Int32_Int32_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip Create(System.String, Int32, Int32, Int32, Boolean, Boolean, PCMReaderCallback)
		/// </summary>
		protected static RMethod r_RCreate_String_Int32_Int32_Int32_Boolean_Boolean_PCMReaderCallback;
		public static RMethod RCreate_String_Int32_Int32_Int32_Boolean_Boolean_PCMReaderCallback
		{
			get
			{
				if(r_RCreate_String_Int32_Int32_Int32_Boolean_Boolean_PCMReaderCallback == null)
				{
					r_RCreate_String_Int32_Int32_Int32_Boolean_Boolean_PCMReaderCallback = new(typeof(UnityEngine.AudioClip), "Create", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean),  ReleactionUtils.GetType("UnityEngine.AudioClip+PCMReaderCallback"));
					r_RCreate_String_Int32_Int32_Int32_Boolean_Boolean_PCMReaderCallback.SetBelong(null);
				}
				return r_RCreate_String_Int32_Int32_Int32_Boolean_Boolean_PCMReaderCallback;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip Create(System.String, Int32, Int32, Int32, Boolean, Boolean, PCMReaderCallback, PCMSetPositionCallback)
		/// </summary>
		protected static RMethod r_RCreate_String_Int32_Int32_Int32_Boolean_Boolean_PCMReaderCallback_PCMSetPositionCallback;
		public static RMethod RCreate_String_Int32_Int32_Int32_Boolean_Boolean_PCMReaderCallback_PCMSetPositionCallback
		{
			get
			{
				if(r_RCreate_String_Int32_Int32_Int32_Boolean_Boolean_PCMReaderCallback_PCMSetPositionCallback == null)
				{
					r_RCreate_String_Int32_Int32_Int32_Boolean_Boolean_PCMReaderCallback_PCMSetPositionCallback = new(typeof(UnityEngine.AudioClip), "Create", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean),  ReleactionUtils.GetType("UnityEngine.AudioClip+PCMReaderCallback"),  ReleactionUtils.GetType("UnityEngine.AudioClip+PCMSetPositionCallback"));
					r_RCreate_String_Int32_Int32_Int32_Boolean_Boolean_PCMReaderCallback_PCMSetPositionCallback.SetBelong(null);
				}
				return r_RCreate_String_Int32_Int32_Int32_Boolean_Boolean_PCMReaderCallback_PCMSetPositionCallback;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip Create(System.String, Int32, Int32, Int32, Boolean)
		/// </summary>
		protected static RMethod r_RCreate_String_Int32_Int32_Int32_Boolean;
		public static RMethod RCreate_String_Int32_Int32_Int32_Boolean
		{
			get
			{
				if(r_RCreate_String_Int32_Int32_Int32_Boolean == null)
				{
					r_RCreate_String_Int32_Int32_Int32_Boolean = new(typeof(UnityEngine.AudioClip), "Create", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RCreate_String_Int32_Int32_Int32_Boolean.SetBelong(null);
				}
				return r_RCreate_String_Int32_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip Create(System.String, Int32, Int32, Int32, Boolean, PCMReaderCallback)
		/// </summary>
		protected static RMethod r_RCreate_String_Int32_Int32_Int32_Boolean_PCMReaderCallback;
		public static RMethod RCreate_String_Int32_Int32_Int32_Boolean_PCMReaderCallback
		{
			get
			{
				if(r_RCreate_String_Int32_Int32_Int32_Boolean_PCMReaderCallback == null)
				{
					r_RCreate_String_Int32_Int32_Int32_Boolean_PCMReaderCallback = new(typeof(UnityEngine.AudioClip), "Create", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean),  ReleactionUtils.GetType("UnityEngine.AudioClip+PCMReaderCallback"));
					r_RCreate_String_Int32_Int32_Int32_Boolean_PCMReaderCallback.SetBelong(null);
				}
				return r_RCreate_String_Int32_Int32_Int32_Boolean_PCMReaderCallback;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip Create(System.String, Int32, Int32, Int32, Boolean, PCMReaderCallback, PCMSetPositionCallback)
		/// </summary>
		protected static RMethod r_RCreate_String_Int32_Int32_Int32_Boolean_PCMReaderCallback_PCMSetPositionCallback;
		public static RMethod RCreate_String_Int32_Int32_Int32_Boolean_PCMReaderCallback_PCMSetPositionCallback
		{
			get
			{
				if(r_RCreate_String_Int32_Int32_Int32_Boolean_PCMReaderCallback_PCMSetPositionCallback == null)
				{
					r_RCreate_String_Int32_Int32_Int32_Boolean_PCMReaderCallback_PCMSetPositionCallback = new(typeof(UnityEngine.AudioClip), "Create", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean),  ReleactionUtils.GetType("UnityEngine.AudioClip+PCMReaderCallback"),  ReleactionUtils.GetType("UnityEngine.AudioClip+PCMSetPositionCallback"));
					r_RCreate_String_Int32_Int32_Int32_Boolean_PCMReaderCallback_PCMSetPositionCallback.SetBelong(null);
				}
				return r_RCreate_String_Int32_Int32_Int32_Boolean_PCMReaderCallback_PCMSetPositionCallback;
			}
		}

		/// <summary>
		/// Void InvokePCMReaderCallback_Internal(Single[])
		/// </summary>
		protected RMethod r_RInvokePCMReaderCallback_Internal_SingleArray;
		public virtual RMethod RInvokePCMReaderCallback_Internal_SingleArray
		{
			get
			{
				if(r_RInvokePCMReaderCallback_Internal_SingleArray == null)
				{
					r_RInvokePCMReaderCallback_Internal_SingleArray = new(this, "InvokePCMReaderCallback_Internal", 0, typeof(System.Single).MakeArrayType());
					r_RInvokePCMReaderCallback_Internal_SingleArray.SetBelong(this.instance);
				}
				return r_RInvokePCMReaderCallback_Internal_SingleArray;
			}
		}

		/// <summary>
		/// Void InvokePCMSetPositionCallback_Internal(Int32)
		/// </summary>
		protected RMethod r_RInvokePCMSetPositionCallback_Internal_Int32;
		public virtual RMethod RInvokePCMSetPositionCallback_Internal_Int32
		{
			get
			{
				if(r_RInvokePCMSetPositionCallback_Internal_Int32 == null)
				{
					r_RInvokePCMSetPositionCallback_Internal_Int32 = new(this, "InvokePCMSetPositionCallback_Internal", 0, typeof(System.Int32));
					r_RInvokePCMSetPositionCallback_Internal_Int32.SetBelong(this.instance);
				}
				return r_RInvokePCMSetPositionCallback_Internal_Int32;
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


        public RAudioClip() : base("UnityEngine.AudioClip")
        {
        }

        public RAudioClip(System.Object instance) : base("UnityEngine.AudioClip")
		{
            SetInstance(instance);
		}

        public RAudioClip(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAudioClip(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean GetData(UnityEngine.AudioClip  @clip, System.Single[]  @data, System.Int32  @numSamples, System.Int32  @samplesOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clip, @data, @numSamples, @samplesOffset};
            var ___result = RGetData_AudioClip_SingleArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean SetData(UnityEngine.AudioClip  @clip, System.Single[]  @data, System.Int32  @numsamples, System.Int32  @samplesOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clip, @data, @numsamples, @samplesOffset};
            var ___result = RSetData_AudioClip_SingleArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.AudioClip Construct_Internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RConstruct_Internal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AudioClip)___result;
        }


        public virtual System.String GetName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void CreateUserSound(System.String  @name, System.Int32  @lengthSamples, System.Int32  @channels, System.Int32  @frequency, System.Boolean  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @lengthSamples, @channels, @frequency, @stream};
            var ___result = RCreateUserSound_String_Int32_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean LoadAudioData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadAudioData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnloadAudioData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnloadAudioData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetData(System.Single[]  @data, System.Int32  @offsetSamples)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @offsetSamples};
            var ___result = RGetData_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SetData(System.Single[]  @data, System.Int32  @offsetSamples)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @offsetSamples};
            var ___result = RSetData_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.AudioClip Create(System.String  @name, System.Int32  @lengthSamples, System.Int32  @channels, System.Int32  @frequency, System.Boolean  @_3D, System.Boolean  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @lengthSamples, @channels, @frequency, @_3D, @stream};
            var ___result = RCreate_String_Int32_Int32_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AudioClip)___result;
        }




        public static UnityEngine.AudioClip Create(System.String  @name, System.Int32  @lengthSamples, System.Int32  @channels, System.Int32  @frequency, System.Boolean  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @lengthSamples, @channels, @frequency, @stream};
            var ___result = RCreate_String_Int32_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AudioClip)___result;
        }




        public virtual void InvokePCMReaderCallback_Internal(System.Single[]  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RInvokePCMReaderCallback_Internal_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokePCMSetPositionCallback_Internal(System.Int32  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RInvokePCMSetPositionCallback_Internal_Int32.Invoke(___genericsType, ___parameters);

            
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
