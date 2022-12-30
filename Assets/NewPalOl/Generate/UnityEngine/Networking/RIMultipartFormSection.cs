using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RNetworking
{
	/// <summary>
	/// UnityEngine.Networking.IMultipartFormSection
	/// </summary>
    public partial class RIMultipartFormSection : RMember //
    {

		/// <summary>
		/// System.String sectionName
		/// </summary>
		protected RProperty r_sectionName;
		public virtual RProperty RsectionName
		{
			get
			{
				if(r_sectionName == null)
				{
					r_sectionName = new(this, "sectionName", -1);
					r_sectionName.SetBelong(this.instance);
				}
				return r_sectionName;
			}
		}

		/// <summary>
		/// Byte[] sectionData
		/// </summary>
		protected RPropertyArray<RProperty> r_sectionData;
		public virtual RPropertyArray<RProperty> RsectionData
		{
			get
			{
				if(r_sectionData == null)
				{
					r_sectionData = new(this, "sectionData", -1);
					r_sectionData.SetBelong(this.instance);
				}
				return r_sectionData;
			}
		}

		/// <summary>
		/// System.String fileName
		/// </summary>
		protected RProperty r_fileName;
		public virtual RProperty RfileName
		{
			get
			{
				if(r_fileName == null)
				{
					r_fileName = new(this, "fileName", -1);
					r_fileName.SetBelong(this.instance);
				}
				return r_fileName;
			}
		}

		/// <summary>
		/// System.String contentType
		/// </summary>
		protected RProperty r_contentType;
		public virtual RProperty RcontentType
		{
			get
			{
				if(r_contentType == null)
				{
					r_contentType = new(this, "contentType", -1);
					r_contentType.SetBelong(this.instance);
				}
				return r_contentType;
			}
		}


        public RIMultipartFormSection() : base("UnityEngine.Networking.IMultipartFormSection")
        {
        }

        public RIMultipartFormSection(System.Object instance) : base("UnityEngine.Networking.IMultipartFormSection")
		{
            SetInstance(instance);
		}

        public RIMultipartFormSection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIMultipartFormSection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
