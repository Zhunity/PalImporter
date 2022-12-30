using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.ReaderWriterLock
	/// </summary>
    public partial class RReaderWriterLock : RMember //
    {

		/// <summary>
		/// System.Int32 seq_num
		/// </summary>
		protected RField r_seq_num;
		public virtual RField Rseq_num
		{
			get
			{
				if(r_seq_num == null)
				{
					r_seq_num = new(this, "seq_num");
					r_seq_num.SetBelong(this.instance);
				}
				return r_seq_num;
			}
		}

		/// <summary>
		/// System.Int32 state
		/// </summary>
		protected RField r_state;
		public virtual RField Rstate
		{
			get
			{
				if(r_state == null)
				{
					r_state = new(this, "state");
					r_state.SetBelong(this.instance);
				}
				return r_state;
			}
		}

		/// <summary>
		/// System.Int32 readers
		/// </summary>
		protected RField r_readers;
		public virtual RField Rreaders
		{
			get
			{
				if(r_readers == null)
				{
					r_readers = new(this, "readers");
					r_readers.SetBelong(this.instance);
				}
				return r_readers;
			}
		}

		/// <summary>
		/// System.Int32 writer_lock_owner
		/// </summary>
		protected RField r_writer_lock_owner;
		public virtual RField Rwriter_lock_owner
		{
			get
			{
				if(r_writer_lock_owner == null)
				{
					r_writer_lock_owner = new(this, "writer_lock_owner");
					r_writer_lock_owner.SetBelong(this.instance);
				}
				return r_writer_lock_owner;
			}
		}

		/// <summary>
		/// System.Threading.LockQueue writer_queue
		/// </summary>
		protected RSystem.RThreading.RLockQueue r_writer_queue;
		public virtual RSystem.RThreading.RLockQueue Rwriter_queue
		{
			get
			{
				if(r_writer_queue == null)
				{
					r_writer_queue = new(this, "writer_queue");
					r_writer_queue.SetBelong(this.instance);
				}
				return r_writer_queue;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable reader_locks
		/// </summary>
		protected RSystem.RCollections.RHashtable r_reader_locks;
		public virtual RSystem.RCollections.RHashtable Rreader_locks
		{
			get
			{
				if(r_reader_locks == null)
				{
					r_reader_locks = new(this, "reader_locks");
					r_reader_locks.SetBelong(this.instance);
				}
				return r_reader_locks;
			}
		}

		/// <summary>
		/// Boolean IsReaderLockHeld
		/// </summary>
		protected RProperty r_IsReaderLockHeld;
		public virtual RProperty RIsReaderLockHeld
		{
			get
			{
				if(r_IsReaderLockHeld == null)
				{
					r_IsReaderLockHeld = new(this, "IsReaderLockHeld", -1);
					r_IsReaderLockHeld.SetBelong(this.instance);
				}
				return r_IsReaderLockHeld;
			}
		}

		/// <summary>
		/// Boolean IsWriterLockHeld
		/// </summary>
		protected RProperty r_IsWriterLockHeld;
		public virtual RProperty RIsWriterLockHeld
		{
			get
			{
				if(r_IsWriterLockHeld == null)
				{
					r_IsWriterLockHeld = new(this, "IsWriterLockHeld", -1);
					r_IsWriterLockHeld.SetBelong(this.instance);
				}
				return r_IsWriterLockHeld;
			}
		}

		/// <summary>
		/// Int32 WriterSeqNum
		/// </summary>
		protected RProperty r_WriterSeqNum;
		public virtual RProperty RWriterSeqNum
		{
			get
			{
				if(r_WriterSeqNum == null)
				{
					r_WriterSeqNum = new(this, "WriterSeqNum", -1);
					r_WriterSeqNum.SetBelong(this.instance);
				}
				return r_WriterSeqNum;
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
		/// Void AcquireReaderLock(Int32)
		/// </summary>
		protected RMethod r_RAcquireReaderLock_Int32;
		public virtual RMethod RAcquireReaderLock_Int32
		{
			get
			{
				if(r_RAcquireReaderLock_Int32 == null)
				{
					r_RAcquireReaderLock_Int32 = new(this, "AcquireReaderLock", 0, typeof(System.Int32));
					r_RAcquireReaderLock_Int32.SetBelong(this.instance);
				}
				return r_RAcquireReaderLock_Int32;
			}
		}

		/// <summary>
		/// Void AcquireReaderLock(Int32, Int32)
		/// </summary>
		protected RMethod r_RAcquireReaderLock_Int32_Int32;
		public virtual RMethod RAcquireReaderLock_Int32_Int32
		{
			get
			{
				if(r_RAcquireReaderLock_Int32_Int32 == null)
				{
					r_RAcquireReaderLock_Int32_Int32 = new(this, "AcquireReaderLock", 0, typeof(System.Int32), typeof(System.Int32));
					r_RAcquireReaderLock_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAcquireReaderLock_Int32_Int32;
			}
		}

		/// <summary>
		/// Void AcquireReaderLock(System.TimeSpan)
		/// </summary>
		protected RMethod r_RAcquireReaderLock_TimeSpan;
		public virtual RMethod RAcquireReaderLock_TimeSpan
		{
			get
			{
				if(r_RAcquireReaderLock_TimeSpan == null)
				{
					r_RAcquireReaderLock_TimeSpan = new(this, "AcquireReaderLock", 0, typeof(System.TimeSpan));
					r_RAcquireReaderLock_TimeSpan.SetBelong(this.instance);
				}
				return r_RAcquireReaderLock_TimeSpan;
			}
		}

		/// <summary>
		/// Void AcquireWriterLock(Int32)
		/// </summary>
		protected RMethod r_RAcquireWriterLock_Int32;
		public virtual RMethod RAcquireWriterLock_Int32
		{
			get
			{
				if(r_RAcquireWriterLock_Int32 == null)
				{
					r_RAcquireWriterLock_Int32 = new(this, "AcquireWriterLock", 0, typeof(System.Int32));
					r_RAcquireWriterLock_Int32.SetBelong(this.instance);
				}
				return r_RAcquireWriterLock_Int32;
			}
		}

		/// <summary>
		/// Void AcquireWriterLock(Int32, Int32)
		/// </summary>
		protected RMethod r_RAcquireWriterLock_Int32_Int32;
		public virtual RMethod RAcquireWriterLock_Int32_Int32
		{
			get
			{
				if(r_RAcquireWriterLock_Int32_Int32 == null)
				{
					r_RAcquireWriterLock_Int32_Int32 = new(this, "AcquireWriterLock", 0, typeof(System.Int32), typeof(System.Int32));
					r_RAcquireWriterLock_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAcquireWriterLock_Int32_Int32;
			}
		}

		/// <summary>
		/// Void AcquireWriterLock(System.TimeSpan)
		/// </summary>
		protected RMethod r_RAcquireWriterLock_TimeSpan;
		public virtual RMethod RAcquireWriterLock_TimeSpan
		{
			get
			{
				if(r_RAcquireWriterLock_TimeSpan == null)
				{
					r_RAcquireWriterLock_TimeSpan = new(this, "AcquireWriterLock", 0, typeof(System.TimeSpan));
					r_RAcquireWriterLock_TimeSpan.SetBelong(this.instance);
				}
				return r_RAcquireWriterLock_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean AnyWritersSince(Int32)
		/// </summary>
		protected RMethod r_RAnyWritersSince_Int32;
		public virtual RMethod RAnyWritersSince_Int32
		{
			get
			{
				if(r_RAnyWritersSince_Int32 == null)
				{
					r_RAnyWritersSince_Int32 = new(this, "AnyWritersSince", 0, typeof(System.Int32));
					r_RAnyWritersSince_Int32.SetBelong(this.instance);
				}
				return r_RAnyWritersSince_Int32;
			}
		}

		/// <summary>
		/// Void DowngradeFromWriterLock(System.Threading.LockCookie ByRef)
		/// </summary>
		protected RMethod r_RDowngradeFromWriterLock_Ref_LockCookie;
		public virtual RMethod RDowngradeFromWriterLock_Ref_LockCookie
		{
			get
			{
				if(r_RDowngradeFromWriterLock_Ref_LockCookie == null)
				{
					r_RDowngradeFromWriterLock_Ref_LockCookie = new(this, "DowngradeFromWriterLock", 0, typeof(System.Threading.LockCookie).MakeByRefType());
					r_RDowngradeFromWriterLock_Ref_LockCookie.SetBelong(this.instance);
				}
				return r_RDowngradeFromWriterLock_Ref_LockCookie;
			}
		}

		/// <summary>
		/// System.Threading.LockCookie ReleaseLock()
		/// </summary>
		protected RMethod r_RReleaseLock;
		public virtual RMethod RReleaseLock
		{
			get
			{
				if(r_RReleaseLock == null)
				{
					r_RReleaseLock = new(this, "ReleaseLock", 0);
					r_RReleaseLock.SetBelong(this.instance);
				}
				return r_RReleaseLock;
			}
		}

		/// <summary>
		/// Void ReleaseReaderLock()
		/// </summary>
		protected RMethod r_RReleaseReaderLock;
		public virtual RMethod RReleaseReaderLock
		{
			get
			{
				if(r_RReleaseReaderLock == null)
				{
					r_RReleaseReaderLock = new(this, "ReleaseReaderLock", 0);
					r_RReleaseReaderLock.SetBelong(this.instance);
				}
				return r_RReleaseReaderLock;
			}
		}

		/// <summary>
		/// Void ReleaseReaderLock(Int32, Int32)
		/// </summary>
		protected RMethod r_RReleaseReaderLock_Int32_Int32;
		public virtual RMethod RReleaseReaderLock_Int32_Int32
		{
			get
			{
				if(r_RReleaseReaderLock_Int32_Int32 == null)
				{
					r_RReleaseReaderLock_Int32_Int32 = new(this, "ReleaseReaderLock", 0, typeof(System.Int32), typeof(System.Int32));
					r_RReleaseReaderLock_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReleaseReaderLock_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ReleaseWriterLock()
		/// </summary>
		protected RMethod r_RReleaseWriterLock;
		public virtual RMethod RReleaseWriterLock
		{
			get
			{
				if(r_RReleaseWriterLock == null)
				{
					r_RReleaseWriterLock = new(this, "ReleaseWriterLock", 0);
					r_RReleaseWriterLock.SetBelong(this.instance);
				}
				return r_RReleaseWriterLock;
			}
		}

		/// <summary>
		/// Void ReleaseWriterLock(Int32)
		/// </summary>
		protected RMethod r_RReleaseWriterLock_Int32;
		public virtual RMethod RReleaseWriterLock_Int32
		{
			get
			{
				if(r_RReleaseWriterLock_Int32 == null)
				{
					r_RReleaseWriterLock_Int32 = new(this, "ReleaseWriterLock", 0, typeof(System.Int32));
					r_RReleaseWriterLock_Int32.SetBelong(this.instance);
				}
				return r_RReleaseWriterLock_Int32;
			}
		}

		/// <summary>
		/// Void RestoreLock(System.Threading.LockCookie ByRef)
		/// </summary>
		protected RMethod r_RRestoreLock_Ref_LockCookie;
		public virtual RMethod RRestoreLock_Ref_LockCookie
		{
			get
			{
				if(r_RRestoreLock_Ref_LockCookie == null)
				{
					r_RRestoreLock_Ref_LockCookie = new(this, "RestoreLock", 0, typeof(System.Threading.LockCookie).MakeByRefType());
					r_RRestoreLock_Ref_LockCookie.SetBelong(this.instance);
				}
				return r_RRestoreLock_Ref_LockCookie;
			}
		}

		/// <summary>
		/// System.Threading.LockCookie UpgradeToWriterLock(Int32)
		/// </summary>
		protected RMethod r_RUpgradeToWriterLock_Int32;
		public virtual RMethod RUpgradeToWriterLock_Int32
		{
			get
			{
				if(r_RUpgradeToWriterLock_Int32 == null)
				{
					r_RUpgradeToWriterLock_Int32 = new(this, "UpgradeToWriterLock", 0, typeof(System.Int32));
					r_RUpgradeToWriterLock_Int32.SetBelong(this.instance);
				}
				return r_RUpgradeToWriterLock_Int32;
			}
		}

		/// <summary>
		/// System.Threading.LockCookie UpgradeToWriterLock(System.TimeSpan)
		/// </summary>
		protected RMethod r_RUpgradeToWriterLock_TimeSpan;
		public virtual RMethod RUpgradeToWriterLock_TimeSpan
		{
			get
			{
				if(r_RUpgradeToWriterLock_TimeSpan == null)
				{
					r_RUpgradeToWriterLock_TimeSpan = new(this, "UpgradeToWriterLock", 0, typeof(System.TimeSpan));
					r_RUpgradeToWriterLock_TimeSpan.SetBelong(this.instance);
				}
				return r_RUpgradeToWriterLock_TimeSpan;
			}
		}

		/// <summary>
		/// System.Threading.LockCookie GetLockCookie()
		/// </summary>
		protected RMethod r_RGetLockCookie;
		public virtual RMethod RGetLockCookie
		{
			get
			{
				if(r_RGetLockCookie == null)
				{
					r_RGetLockCookie = new(this, "GetLockCookie", 0);
					r_RGetLockCookie.SetBelong(this.instance);
				}
				return r_RGetLockCookie;
			}
		}

		/// <summary>
		/// Boolean HasWriterLock()
		/// </summary>
		protected RMethod r_RHasWriterLock;
		public virtual RMethod RHasWriterLock
		{
			get
			{
				if(r_RHasWriterLock == null)
				{
					r_RHasWriterLock = new(this, "HasWriterLock", 0);
					r_RHasWriterLock.SetBelong(this.instance);
				}
				return r_RHasWriterLock;
			}
		}

		/// <summary>
		/// Int32 CheckTimeout(System.TimeSpan)
		/// </summary>
		protected RMethod r_RCheckTimeout_TimeSpan;
		public virtual RMethod RCheckTimeout_TimeSpan
		{
			get
			{
				if(r_RCheckTimeout_TimeSpan == null)
				{
					r_RCheckTimeout_TimeSpan = new(this, "CheckTimeout", 0, typeof(System.TimeSpan));
					r_RCheckTimeout_TimeSpan.SetBelong(this.instance);
				}
				return r_RCheckTimeout_TimeSpan;
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


        public RReaderWriterLock() : base("System.Threading.ReaderWriterLock")
        {
        }

        public RReaderWriterLock(System.Object instance) : base("System.Threading.ReaderWriterLock")
		{
            SetInstance(instance);
		}

        public RReaderWriterLock(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReaderWriterLock(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AcquireReaderLock(System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RAcquireReaderLock_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AcquireReaderLock(System.Int32  @millisecondsTimeout, System.Int32  @initialLockCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @initialLockCount};
            var ___result = RAcquireReaderLock_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AcquireReaderLock(System.TimeSpan  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RAcquireReaderLock_TimeSpan.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AcquireWriterLock(System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RAcquireWriterLock_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AcquireWriterLock(System.Int32  @millisecondsTimeout, System.Int32  @initialLockCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @initialLockCount};
            var ___result = RAcquireWriterLock_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AcquireWriterLock(System.TimeSpan  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RAcquireWriterLock_TimeSpan.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AnyWritersSince(System.Int32  @seqNum)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@seqNum};
            var ___result = RAnyWritersSince_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DowngradeFromWriterLock(ref System.Threading.LockCookie  @lockCookie)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lockCookie};
            var ___result = RDowngradeFromWriterLock_Ref_LockCookie.Invoke(___genericsType, ___parameters);
			lockCookie = (System.Threading.LockCookie)___parameters[0];

            
        }


        public virtual System.Threading.LockCookie ReleaseLock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReleaseLock.Invoke(___genericsType, ___parameters);

            return (System.Threading.LockCookie)___result;
        }


        public virtual void ReleaseReaderLock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReleaseReaderLock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleaseReaderLock(System.Int32  @currentCount, System.Int32  @releaseCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currentCount, @releaseCount};
            var ___result = RReleaseReaderLock_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleaseWriterLock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReleaseWriterLock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleaseWriterLock(System.Int32  @releaseCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@releaseCount};
            var ___result = RReleaseWriterLock_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestoreLock(ref System.Threading.LockCookie  @lockCookie)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lockCookie};
            var ___result = RRestoreLock_Ref_LockCookie.Invoke(___genericsType, ___parameters);
			lockCookie = (System.Threading.LockCookie)___parameters[0];

            
        }


        public virtual System.Threading.LockCookie UpgradeToWriterLock(System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RUpgradeToWriterLock_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.LockCookie)___result;
        }


        public virtual System.Threading.LockCookie UpgradeToWriterLock(System.TimeSpan  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RUpgradeToWriterLock_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Threading.LockCookie)___result;
        }


        public virtual System.Threading.LockCookie GetLockCookie()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLockCookie.Invoke(___genericsType, ___parameters);

            return (System.Threading.LockCookie)___result;
        }


        public virtual System.Boolean HasWriterLock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasWriterLock.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 CheckTimeout(System.TimeSpan  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RCheckTimeout_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
