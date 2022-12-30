using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet
{
	/// <summary>
	/// System.Net.ICredentials
	/// </summary>
    public partial class RICredentials : RMember //
    {

		/// <summary>
		/// System.Net.NetworkCredential GetCredential(System.Uri, System.String)
		/// </summary>
		protected RMethod r_RGetCredential_Uri_String;
		public virtual RMethod RGetCredential_Uri_String
		{
			get
			{
				if(r_RGetCredential_Uri_String == null)
				{
					r_RGetCredential_Uri_String = new(this, "GetCredential", 0, typeof(System.Uri), typeof(System.String));
					r_RGetCredential_Uri_String.SetBelong(this.instance);
				}
				return r_RGetCredential_Uri_String;
			}
		}


        public RICredentials() : base("System.Net.ICredentials")
        {
        }

        public RICredentials(System.Object instance) : base("System.Net.ICredentials")
		{
            SetInstance(instance);
		}

        public RICredentials(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RICredentials(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Net.NetworkCredential GetCredential(System.Uri  @uri, System.String  @authType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @authType};
            var ___result = RGetCredential_Uri_String.Invoke(___genericsType, ___parameters);

            return (System.Net.NetworkCredential)___result;
        }


    }
}
