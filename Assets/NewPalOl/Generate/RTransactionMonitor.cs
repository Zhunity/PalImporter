using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// TransactionMonitor
	/// </summary>
    public partial class RTransactionMonitor : RMember //
    {

		/// <summary>
		/// System.Boolean #a
		/// </summary>
		protected RField r___0__a;
		public virtual RField R__0__a
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
		/// System.Collections.Generic.List`1[TransactionMonitor] children
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RTransactionMonitor> r_children;
		public virtual RSystem.RCollections.RGeneric.RList<RTransactionMonitor> Rchildren
		{
			get
			{
				if(r_children == null)
				{
					r_children = new(this, "children");
					r_children.SetBelong(this.instance);
				}
				return r_children;
			}
		}

		/// <summary>
		/// System.Int32 completed
		/// </summary>
		protected RField r_completed;
		public virtual RField Rcompleted
		{
			get
			{
				if(r_completed == null)
				{
					r_completed = new(this, "completed");
					r_completed.SetBelong(this.instance);
				}
				return r_completed;
			}
		}

		/// <summary>
		/// System.Single endTime
		/// </summary>
		protected RField r_endTime;
		public virtual RField RendTime
		{
			get
			{
				if(r_endTime == null)
				{
					r_endTime = new(this, "endTime");
					r_endTime.SetBelong(this.instance);
				}
				return r_endTime;
			}
		}

		/// <summary>
		/// System.String #b
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
		/// TransactionMonitor parent
		/// </summary>
		protected RTransactionMonitor r_parent;
		public virtual RTransactionMonitor Rparent
		{
			get
			{
				if(r_parent == null)
				{
					r_parent = new(this, "parent");
					r_parent.SetBelong(this.instance);
				}
				return r_parent;
			}
		}

		/// <summary>
		/// System.Single percentComplete
		/// </summary>
		protected RField r_percentComplete;
		public virtual RField RpercentComplete
		{
			get
			{
				if(r_percentComplete == null)
				{
					r_percentComplete = new(this, "percentComplete");
					r_percentComplete.SetBelong(this.instance);
				}
				return r_percentComplete;
			}
		}

		/// <summary>
		/// TransactionMonitor+ExitCondition result
		/// </summary>
		protected RField r_result;
		public virtual RField Rresult
		{
			get
			{
				if(r_result == null)
				{
					r_result = new(this, "result");
					r_result.SetBelong(this.instance);
				}
				return r_result;
			}
		}

		/// <summary>
		/// System.Single startTime
		/// </summary>
		protected RField r_startTime;
		public virtual RField RstartTime
		{
			get
			{
				if(r_startTime == null)
				{
					r_startTime = new(this, "startTime");
					r_startTime.SetBelong(this.instance);
				}
				return r_startTime;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[TransactionMonitor+Step] steps
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RTransactionMonitor.RStep> r_steps;
		public virtual RSystem.RCollections.RGeneric.RList<RTransactionMonitor.RStep> Rsteps
		{
			get
			{
				if(r_steps == null)
				{
					r_steps = new(this, "steps");
					r_steps.SetBelong(this.instance);
				}
				return r_steps;
			}
		}

		/// <summary>
		/// System.Single timeout
		/// </summary>
		protected RField r_timeout;
		public virtual RField Rtimeout
		{
			get
			{
				if(r_timeout == null)
				{
					r_timeout = new(this, "timeout");
					r_timeout.SetBelong(this.instance);
				}
				return r_timeout;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[TransactionMonitor] #c
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RTransactionMonitor> r___0__c;
		public static RSystem.RCollections.RGeneric.RList<RTransactionMonitor> R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new(typeof(TransactionMonitor), "#c");
					r___0__c.SetBelong(null);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// System.Boolean #d
		/// </summary>
		protected static RField r___0__d;
		public static RField R__0__d
		{
			get
			{
				if(r___0__d == null)
				{
					r___0__d = new(typeof(TransactionMonitor), "#d");
					r___0__d.SetBelong(null);
				}
				return r___0__d;
			}
		}

		/// <summary>
		/// System.Int32 #e
		/// </summary>
		protected static RField r___0__e;
		public static RField R__0__e
		{
			get
			{
				if(r___0__e == null)
				{
					r___0__e = new(typeof(TransactionMonitor), "#e");
					r___0__e.SetBelong(null);
				}
				return r___0__e;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected RSystem.RObject r_userData;
		public virtual RSystem.RObject RuserData
		{
			get
			{
				if(r_userData == null)
				{
					r_userData = new(this, "userData");
					r_userData.SetBelong(this.instance);
				}
				return r_userData;
			}
		}

		/// <summary>
		/// System.Single #f
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
		/// System.Collections.Generic.List`1[System.String] #g
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__g;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__g
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
		/// TransactionMonitor+OnCancelDelegate #h
		/// </summary>
		protected RTransactionMonitor.ROnCancelDelegate r___0__h;
		public virtual RTransactionMonitor.ROnCancelDelegate R__0__h
		{
			get
			{
				if(r___0__h == null)
				{
					r___0__h = new(this, "#h");
					r___0__h.SetBelong(this.instance);
				}
				return r___0__h;
			}
		}

		/// <summary>
		/// TransactionMonitor+OnCompleteDelegate #i
		/// </summary>
		protected RTransactionMonitor.ROnCompleteDelegate r___0__i;
		public virtual RTransactionMonitor.ROnCompleteDelegate R__0__i
		{
			get
			{
				if(r___0__i == null)
				{
					r___0__i = new(this, "#i");
					r___0__i.SetBelong(this.instance);
				}
				return r___0__i;
			}
		}

		/// <summary>
		/// System.Func`2[TransactionMonitor+Step,System.Boolean] #j
		/// </summary>
		protected static RSystem.RFunc<RTransactionMonitor.RStep, RField> r___0__j;
		public static RSystem.RFunc<RTransactionMonitor.RStep, RField> R__0__j
		{
			get
			{
				if(r___0__j == null)
				{
					r___0__j = new(typeof(TransactionMonitor), "#j");
					r___0__j.SetBelong(null);
				}
				return r___0__j;
			}
		}

		/// <summary>
		/// System.Func`2[TransactionMonitor+Step,System.String] #k
		/// </summary>
		protected static RSystem.RFunc<RTransactionMonitor.RStep, RField> r___0__k;
		public static RSystem.RFunc<RTransactionMonitor.RStep, RField> R__0__k
		{
			get
			{
				if(r___0__k == null)
				{
					r___0__k = new(typeof(TransactionMonitor), "#k");
					r___0__k.SetBelong(null);
				}
				return r___0__k;
			}
		}

		/// <summary>
		/// System.Func`2[TransactionMonitor+Step,System.Boolean] #l
		/// </summary>
		protected static RSystem.RFunc<RTransactionMonitor.RStep, RField> r___0__l;
		public static RSystem.RFunc<RTransactionMonitor.RStep, RField> R__0__l
		{
			get
			{
				if(r___0__l == null)
				{
					r___0__l = new(typeof(TransactionMonitor), "#l");
					r___0__l.SetBelong(null);
				}
				return r___0__l;
			}
		}

		/// <summary>
		/// System.Func`2[TransactionMonitor+Step,System.String] #m
		/// </summary>
		protected static RSystem.RFunc<RTransactionMonitor.RStep, RField> r___0__m;
		public static RSystem.RFunc<RTransactionMonitor.RStep, RField> R__0__m
		{
			get
			{
				if(r___0__m == null)
				{
					r___0__m = new(typeof(TransactionMonitor), "#m");
					r___0__m.SetBelong(null);
				}
				return r___0__m;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.String] CompletedSteps
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RProperty> r_CompletedSteps;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RProperty> RCompletedSteps
		{
			get
			{
				if(r_CompletedSteps == null)
				{
					r_CompletedSteps = new(this, "CompletedSteps", -1);
					r_CompletedSteps.SetBelong(this.instance);
				}
				return r_CompletedSteps;
			}
		}

		/// <summary>
		/// System.String Id
		/// </summary>
		protected RProperty r_Id;
		public virtual RProperty RId
		{
			get
			{
				if(r_Id == null)
				{
					r_Id = new(this, "Id", -1);
					r_Id.SetBelong(this.instance);
				}
				return r_Id;
			}
		}

		/// <summary>
		/// Boolean IsCompleted
		/// </summary>
		protected RProperty r_IsCompleted;
		public virtual RProperty RIsCompleted
		{
			get
			{
				if(r_IsCompleted == null)
				{
					r_IsCompleted = new(this, "IsCompleted", -1);
					r_IsCompleted.SetBelong(this.instance);
				}
				return r_IsCompleted;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.String] OpenSteps
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RProperty> r_OpenSteps;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RProperty> ROpenSteps
		{
			get
			{
				if(r_OpenSteps == null)
				{
					r_OpenSteps = new(this, "OpenSteps", -1);
					r_OpenSteps.SetBelong(this.instance);
				}
				return r_OpenSteps;
			}
		}

		/// <summary>
		/// Single PercentComplete
		/// </summary>
		protected RProperty r_PercentComplete;
		public virtual RProperty RPercentComplete
		{
			get
			{
				if(r_PercentComplete == null)
				{
					r_PercentComplete = new(this, "PercentComplete", -1);
					r_PercentComplete.SetBelong(this.instance);
				}
				return r_PercentComplete;
			}
		}

		/// <summary>
		/// Int32 StepCount
		/// </summary>
		protected RProperty r_StepCount;
		public virtual RProperty RStepCount
		{
			get
			{
				if(r_StepCount == null)
				{
					r_StepCount = new(this, "StepCount", -1);
					r_StepCount.SetBelong(this.instance);
				}
				return r_StepCount;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[TransactionMonitor+Step] Steps
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RTransactionMonitor.RStep> r_Steps;
		public virtual RSystem.RCollections.RGeneric.RList<RTransactionMonitor.RStep> RSteps
		{
			get
			{
				if(r_Steps == null)
				{
					r_Steps = new(this, "Steps", -1);
					r_Steps.SetBelong(this.instance);
				}
				return r_Steps;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[TransactionMonitor] TransactionHistory
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RTransactionMonitor> r_TransactionHistory;
		public static RSystem.RCollections.RGeneric.RList<RTransactionMonitor> RTransactionHistory
		{
			get
			{
				if(r_TransactionHistory == null)
				{
					r_TransactionHistory = new(typeof(TransactionMonitor), "TransactionHistory", -1);
					r_TransactionHistory.SetBelong(null);
				}
				return r_TransactionHistory;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[TransactionMonitor] Transactions
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RTransactionMonitor> r_Transactions;
		public virtual RSystem.RCollections.RGeneric.RList<RTransactionMonitor> RTransactions
		{
			get
			{
				if(r_Transactions == null)
				{
					r_Transactions = new(this, "Transactions", -1);
					r_Transactions.SetBelong(this.instance);
				}
				return r_Transactions;
			}
		}

		/// <summary>
		/// System.Object UserData
		/// </summary>
		protected RSystem.RObject r_UserData;
		public virtual RSystem.RObject RUserData
		{
			get
			{
				if(r_UserData == null)
				{
					r_UserData = new(this, "UserData", -1);
					r_UserData.SetBelong(this.instance);
				}
				return r_UserData;
			}
		}

		/// <summary>
		/// Single Weight
		/// </summary>
		protected RProperty r_Weight;
		public virtual RProperty RWeight
		{
			get
			{
				if(r_Weight == null)
				{
					r_Weight = new(this, "Weight", -1);
					r_Weight.SetBelong(this.instance);
				}
				return r_Weight;
			}
		}

		/// <summary>
		/// TransactionMonitor+OnCancelDelegate onCancel
		/// </summary>
		protected REvent r_onCancel;
		public virtual REvent RonCancel
		{
			get
			{
				if(r_onCancel == null)
				{
					r_onCancel = new(this, "onCancel");
					r_onCancel.SetBelong(this.instance);
				}
				return r_onCancel;
			}
		}

		/// <summary>
		/// TransactionMonitor+OnCompleteDelegate onComplete
		/// </summary>
		protected REvent r_onComplete;
		public virtual REvent RonComplete
		{
			get
			{
				if(r_onComplete == null)
				{
					r_onComplete = new(this, "onComplete");
					r_onComplete.SetBelong(this.instance);
				}
				return r_onComplete;
			}
		}

		/// <summary>
		/// Void AddChild(TransactionMonitor)
		/// </summary>
		protected RMethod r_RAddChild_TransactionMonitor;
		public virtual RMethod RAddChild_TransactionMonitor
		{
			get
			{
				if(r_RAddChild_TransactionMonitor == null)
				{
					r_RAddChild_TransactionMonitor = new(this, "AddChild", 0, typeof(TransactionMonitor));
					r_RAddChild_TransactionMonitor.SetBelong(this.instance);
				}
				return r_RAddChild_TransactionMonitor;
			}
		}

		/// <summary>
		/// Void AddStep(System.String)
		/// </summary>
		protected RMethod r_RAddStep_String;
		public virtual RMethod RAddStep_String
		{
			get
			{
				if(r_RAddStep_String == null)
				{
					r_RAddStep_String = new(this, "AddStep", 0, typeof(System.String));
					r_RAddStep_String.SetBelong(this.instance);
				}
				return r_RAddStep_String;
			}
		}

		/// <summary>
		/// Void AddStep(System.String, System.String)
		/// </summary>
		protected RMethod r_RAddStep_String_String;
		public virtual RMethod RAddStep_String_String
		{
			get
			{
				if(r_RAddStep_String_String == null)
				{
					r_RAddStep_String_String = new(this, "AddStep", 0, typeof(System.String), typeof(System.String));
					r_RAddStep_String_String.SetBelong(this.instance);
				}
				return r_RAddStep_String_String;
			}
		}

		/// <summary>
		/// Void AddStep(System.String, OnStepDelegate)
		/// </summary>
		protected RMethod r_RAddStep_String_OnStepDelegate;
		public virtual RMethod RAddStep_String_OnStepDelegate
		{
			get
			{
				if(r_RAddStep_String_OnStepDelegate == null)
				{
					r_RAddStep_String_OnStepDelegate = new(this, "AddStep", 0, typeof(System.String),  ReleactionUtils.GetType("TransactionMonitor+OnStepDelegate"));
					r_RAddStep_String_OnStepDelegate.SetBelong(this.instance);
				}
				return r_RAddStep_String_OnStepDelegate;
			}
		}

		/// <summary>
		/// Void AddStep(System.String, OnStepDelegate, System.String)
		/// </summary>
		protected RMethod r_RAddStep_String_OnStepDelegate_String;
		public virtual RMethod RAddStep_String_OnStepDelegate_String
		{
			get
			{
				if(r_RAddStep_String_OnStepDelegate_String == null)
				{
					r_RAddStep_String_OnStepDelegate_String = new(this, "AddStep", 0, typeof(System.String),  ReleactionUtils.GetType("TransactionMonitor+OnStepDelegate"), typeof(System.String));
					r_RAddStep_String_OnStepDelegate_String.SetBelong(this.instance);
				}
				return r_RAddStep_String_OnStepDelegate_String;
			}
		}

		/// <summary>
		/// Void AddStepBundle(System.String, System.String)
		/// </summary>
		protected RMethod r_RAddStepBundle_String_String;
		public virtual RMethod RAddStepBundle_String_String
		{
			get
			{
				if(r_RAddStepBundle_String_String == null)
				{
					r_RAddStepBundle_String_String = new(this, "AddStepBundle", 0, typeof(System.String), typeof(System.String));
					r_RAddStepBundle_String_String.SetBelong(this.instance);
				}
				return r_RAddStepBundle_String_String;
			}
		}

		/// <summary>
		/// Void AddStepDelegate(System.String, OnStepDelegate)
		/// </summary>
		protected RMethod r_RAddStepDelegate_String_OnStepDelegate;
		public virtual RMethod RAddStepDelegate_String_OnStepDelegate
		{
			get
			{
				if(r_RAddStepDelegate_String_OnStepDelegate == null)
				{
					r_RAddStepDelegate_String_OnStepDelegate = new(this, "AddStepDelegate", 0, typeof(System.String),  ReleactionUtils.GetType("TransactionMonitor+OnStepDelegate"));
					r_RAddStepDelegate_String_OnStepDelegate.SetBelong(this.instance);
				}
				return r_RAddStepDelegate_String_OnStepDelegate;
			}
		}

		/// <summary>
		/// Void checkForCompletion()
		/// </summary>
		protected RMethod r_RcheckForCompletion;
		public virtual RMethod RcheckForCompletion
		{
			get
			{
				if(r_RcheckForCompletion == null)
				{
					r_RcheckForCompletion = new(this, "checkForCompletion", 0);
					r_RcheckForCompletion.SetBelong(this.instance);
				}
				return r_RcheckForCompletion;
			}
		}

		/// <summary>
		/// Void CloseTransaction()
		/// </summary>
		protected RMethod r_RCloseTransaction;
		public virtual RMethod RCloseTransaction
		{
			get
			{
				if(r_RCloseTransaction == null)
				{
					r_RCloseTransaction = new(this, "CloseTransaction", 0);
					r_RCloseTransaction.SetBelong(this.instance);
				}
				return r_RCloseTransaction;
			}
		}

		/// <summary>
		/// Void CompleteChildTransaction(TransactionMonitor)
		/// </summary>
		protected RMethod r_RCompleteChildTransaction_TransactionMonitor;
		public virtual RMethod RCompleteChildTransaction_TransactionMonitor
		{
			get
			{
				if(r_RCompleteChildTransaction_TransactionMonitor == null)
				{
					r_RCompleteChildTransaction_TransactionMonitor = new(this, "CompleteChildTransaction", 0, typeof(TransactionMonitor));
					r_RCompleteChildTransaction_TransactionMonitor.SetBelong(this.instance);
				}
				return r_RCompleteChildTransaction_TransactionMonitor;
			}
		}

		/// <summary>
		/// Void CompleteStepSync(System.String)
		/// </summary>
		protected RMethod r_RCompleteStepSync_String;
		public virtual RMethod RCompleteStepSync_String
		{
			get
			{
				if(r_RCompleteStepSync_String == null)
				{
					r_RCompleteStepSync_String = new(this, "CompleteStepSync", 0, typeof(System.String));
					r_RCompleteStepSync_String.SetBelong(this.instance);
				}
				return r_RCompleteStepSync_String;
			}
		}

		/// <summary>
		/// Void CompleteStep(System.String)
		/// </summary>
		protected RMethod r_RCompleteStep_String;
		public virtual RMethod RCompleteStep_String
		{
			get
			{
				if(r_RCompleteStep_String == null)
				{
					r_RCompleteStep_String = new(this, "CompleteStep", 0, typeof(System.String));
					r_RCompleteStep_String.SetBelong(this.instance);
				}
				return r_RCompleteStep_String;
			}
		}

		/// <summary>
		/// Void CompleteStep(System.String, System.String)
		/// </summary>
		protected RMethod r_RCompleteStep_String_String;
		public virtual RMethod RCompleteStep_String_String
		{
			get
			{
				if(r_RCompleteStep_String_String == null)
				{
					r_RCompleteStep_String_String = new(this, "CompleteStep", 0, typeof(System.String), typeof(System.String));
					r_RCompleteStep_String_String.SetBelong(this.instance);
				}
				return r_RCompleteStep_String_String;
			}
		}

		/// <summary>
		/// TransactionMonitor CreateTransactionMonitor(OnCompleteDelegate, Single, System.Object)
		/// </summary>
		protected static RMethod r_RCreateTransactionMonitor_OnCompleteDelegate_Single_Object;
		public static RMethod RCreateTransactionMonitor_OnCompleteDelegate_Single_Object
		{
			get
			{
				if(r_RCreateTransactionMonitor_OnCompleteDelegate_Single_Object == null)
				{
					r_RCreateTransactionMonitor_OnCompleteDelegate_Single_Object = new(typeof(TransactionMonitor), "CreateTransactionMonitor", 0,  ReleactionUtils.GetType("TransactionMonitor+OnCompleteDelegate"), typeof(System.Single), typeof(System.Object));
					r_RCreateTransactionMonitor_OnCompleteDelegate_Single_Object.SetBelong(null);
				}
				return r_RCreateTransactionMonitor_OnCompleteDelegate_Single_Object;
			}
		}

		/// <summary>
		/// TransactionMonitor CreateTransactionMonitor(System.String, OnCompleteDelegate, Single, System.Object)
		/// </summary>
		protected static RMethod r_RCreateTransactionMonitor_String_OnCompleteDelegate_Single_Object;
		public static RMethod RCreateTransactionMonitor_String_OnCompleteDelegate_Single_Object
		{
			get
			{
				if(r_RCreateTransactionMonitor_String_OnCompleteDelegate_Single_Object == null)
				{
					r_RCreateTransactionMonitor_String_OnCompleteDelegate_Single_Object = new(typeof(TransactionMonitor), "CreateTransactionMonitor", 0, typeof(System.String),  ReleactionUtils.GetType("TransactionMonitor+OnCompleteDelegate"), typeof(System.Single), typeof(System.Object));
					r_RCreateTransactionMonitor_String_OnCompleteDelegate_Single_Object.SetBelong(null);
				}
				return r_RCreateTransactionMonitor_String_OnCompleteDelegate_Single_Object;
			}
		}

		/// <summary>
		/// Void DumpStatus()
		/// </summary>
		protected RMethod r_RDumpStatus;
		public virtual RMethod RDumpStatus
		{
			get
			{
				if(r_RDumpStatus == null)
				{
					r_RDumpStatus = new(this, "DumpStatus", 0);
					r_RDumpStatus.SetBelong(this.instance);
				}
				return r_RDumpStatus;
			}
		}

		/// <summary>
		/// Void Fail(System.String)
		/// </summary>
		protected RMethod r_RFail_String;
		public virtual RMethod RFail_String
		{
			get
			{
				if(r_RFail_String == null)
				{
					r_RFail_String = new(this, "Fail", 0, typeof(System.String));
					r_RFail_String.SetBelong(this.instance);
				}
				return r_RFail_String;
			}
		}

		/// <summary>
		/// Void FailStep(System.String, System.String)
		/// </summary>
		protected RMethod r_RFailStep_String_String;
		public virtual RMethod RFailStep_String_String
		{
			get
			{
				if(r_RFailStep_String_String == null)
				{
					r_RFailStep_String_String = new(this, "FailStep", 0, typeof(System.String), typeof(System.String));
					r_RFailStep_String_String.SetBelong(this.instance);
				}
				return r_RFailStep_String_String;
			}
		}

		/// <summary>
		/// Step #UDd(System.String)
		/// </summary>
		protected RMethod r_R__0__UDd_String;
		public virtual RMethod R__0__UDd_String
		{
			get
			{
				if(r_R__0__UDd_String == null)
				{
					r_R__0__UDd_String = new(this, "#UDd", 0, typeof(System.String));
					r_R__0__UDd_String.SetBelong(this.instance);
				}
				return r_R__0__UDd_String;
			}
		}

		/// <summary>
		/// System.String GenerateTransactionId()
		/// </summary>
		protected static RMethod r_RGenerateTransactionId;
		public static RMethod RGenerateTransactionId
		{
			get
			{
				if(r_RGenerateTransactionId == null)
				{
					r_RGenerateTransactionId = new(typeof(TransactionMonitor), "GenerateTransactionId", 0);
					r_RGenerateTransactionId.SetBelong(null);
				}
				return r_RGenerateTransactionId;
			}
		}

		/// <summary>
		/// Boolean HasStep(System.String)
		/// </summary>
		protected RMethod r_RHasStep_String;
		public virtual RMethod RHasStep_String
		{
			get
			{
				if(r_RHasStep_String == null)
				{
					r_RHasStep_String = new(this, "HasStep", 0, typeof(System.String));
					r_RHasStep_String.SetBelong(this.instance);
				}
				return r_RHasStep_String;
			}
		}

		/// <summary>
		/// Boolean IsStepCompleted(System.String)
		/// </summary>
		protected RMethod r_RIsStepCompleted_String;
		public virtual RMethod RIsStepCompleted_String
		{
			get
			{
				if(r_RIsStepCompleted_String == null)
				{
					r_RIsStepCompleted_String = new(this, "IsStepCompleted", 0, typeof(System.String));
					r_RIsStepCompleted_String.SetBelong(this.instance);
				}
				return r_RIsStepCompleted_String;
			}
		}

		/// <summary>
		/// Void MarkComplete()
		/// </summary>
		protected RMethod r_RMarkComplete;
		public virtual RMethod RMarkComplete
		{
			get
			{
				if(r_RMarkComplete == null)
				{
					r_RMarkComplete = new(this, "MarkComplete", 0);
					r_RMarkComplete.SetBelong(this.instance);
				}
				return r_RMarkComplete;
			}
		}

		/// <summary>
		/// Void recalcPercentComplete()
		/// </summary>
		protected RMethod r_RrecalcPercentComplete;
		public virtual RMethod RrecalcPercentComplete
		{
			get
			{
				if(r_RrecalcPercentComplete == null)
				{
					r_RrecalcPercentComplete = new(this, "recalcPercentComplete", 0);
					r_RrecalcPercentComplete.SetBelong(this.instance);
				}
				return r_RrecalcPercentComplete;
			}
		}

		/// <summary>
		/// Void RemoveChild(TransactionMonitor)
		/// </summary>
		protected RMethod r_RRemoveChild_TransactionMonitor;
		public virtual RMethod RRemoveChild_TransactionMonitor
		{
			get
			{
				if(r_RRemoveChild_TransactionMonitor == null)
				{
					r_RRemoveChild_TransactionMonitor = new(this, "RemoveChild", 0, typeof(TransactionMonitor));
					r_RRemoveChild_TransactionMonitor.SetBelong(this.instance);
				}
				return r_RRemoveChild_TransactionMonitor;
			}
		}

		/// <summary>
		/// Void SetStepWeight(System.String, Single)
		/// </summary>
		protected RMethod r_RSetStepWeight_String_Single;
		public virtual RMethod RSetStepWeight_String_Single
		{
			get
			{
				if(r_RSetStepWeight_String_Single == null)
				{
					r_RSetStepWeight_String_Single = new(this, "SetStepWeight", 0, typeof(System.String), typeof(System.Single));
					r_RSetStepWeight_String_Single.SetBelong(this.instance);
				}
				return r_RSetStepWeight_String_Single;
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
		/// Boolean Update()
		/// </summary>
		protected RMethod r_RUpdate;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_RUpdate == null)
				{
					r_RUpdate = new(this, "Update", 0);
					r_RUpdate.SetBelong(this.instance);
				}
				return r_RUpdate;
			}
		}

		/// <summary>
		/// Void UpdateMonitoredTransaction()
		/// </summary>
		protected RMethod r_RUpdateMonitoredTransaction;
		public virtual RMethod RUpdateMonitoredTransaction
		{
			get
			{
				if(r_RUpdateMonitoredTransaction == null)
				{
					r_RUpdateMonitoredTransaction = new(this, "UpdateMonitoredTransaction", 0);
					r_RUpdateMonitoredTransaction.SetBelong(this.instance);
				}
				return r_RUpdateMonitoredTransaction;
			}
		}

		/// <summary>
		/// Boolean #AUr(Step)
		/// </summary>
		protected static RMethod r_R__0__AUr_Step;
		public static RMethod R__0__AUr_Step
		{
			get
			{
				if(r_R__0__AUr_Step == null)
				{
					r_R__0__AUr_Step = new(typeof(TransactionMonitor), "#AUr", 0,  ReleactionUtils.GetType("TransactionMonitor+Step"));
					r_R__0__AUr_Step.SetBelong(null);
				}
				return r_R__0__AUr_Step;
			}
		}

		/// <summary>
		/// System.String #BUr(Step)
		/// </summary>
		protected static RMethod r_R__0__BUr_Step;
		public static RMethod R__0__BUr_Step
		{
			get
			{
				if(r_R__0__BUr_Step == null)
				{
					r_R__0__BUr_Step = new(typeof(TransactionMonitor), "#BUr", 0,  ReleactionUtils.GetType("TransactionMonitor+Step"));
					r_R__0__BUr_Step.SetBelong(null);
				}
				return r_R__0__BUr_Step;
			}
		}

		/// <summary>
		/// Boolean #CUr(Step)
		/// </summary>
		protected static RMethod r_R__0__CUr_Step;
		public static RMethod R__0__CUr_Step
		{
			get
			{
				if(r_R__0__CUr_Step == null)
				{
					r_R__0__CUr_Step = new(typeof(TransactionMonitor), "#CUr", 0,  ReleactionUtils.GetType("TransactionMonitor+Step"));
					r_R__0__CUr_Step.SetBelong(null);
				}
				return r_R__0__CUr_Step;
			}
		}

		/// <summary>
		/// System.String #DUr(Step)
		/// </summary>
		protected static RMethod r_R__0__DUr_Step;
		public static RMethod R__0__DUr_Step
		{
			get
			{
				if(r_R__0__DUr_Step == null)
				{
					r_R__0__DUr_Step = new(typeof(TransactionMonitor), "#DUr", 0,  ReleactionUtils.GetType("TransactionMonitor+Step"));
					r_R__0__DUr_Step.SetBelong(null);
				}
				return r_R__0__DUr_Step;
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


        public RTransactionMonitor() : base("TransactionMonitor")
        {
        }

        public RTransactionMonitor(System.Object instance) : base("TransactionMonitor")
		{
            SetInstance(instance);
		}

        public RTransactionMonitor(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTransactionMonitor(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddChild(TransactionMonitor  @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RAddChild_TransactionMonitor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddStep(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RAddStep_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddStep(System.String  @name, System.String  @notice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @notice};
            var ___result = RAddStep_String_String.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void AddStepBundle(System.String  @name, System.String  @bundlePath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bundlePath};
            var ___result = RAddStepBundle_String_String.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void checkForCompletion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RcheckForCompletion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloseTransaction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCloseTransaction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteChildTransaction(TransactionMonitor  @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RCompleteChildTransaction_TransactionMonitor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteStepSync(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RCompleteStepSync_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteStep(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RCompleteStep_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteStep(System.String  @name, System.String  @updateNotice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @updateNotice};
            var ___result = RCompleteStep_String_String.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void DumpStatus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDumpStatus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Fail(System.String  @error)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@error};
            var ___result = RFail_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FailStep(System.String  @name, System.String  @error)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @error};
            var ___result = RFailStep_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object __0__UDd(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = R__0__UDd_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.String GenerateTransactionId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGenerateTransactionId.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasStep(System.String  @step)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@step};
            var ___result = RHasStep_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsStepCompleted(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RIsStepCompleted_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void MarkComplete()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkComplete.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void recalcPercentComplete()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RrecalcPercentComplete.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveChild(TransactionMonitor  @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RRemoveChild_TransactionMonitor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStepWeight(System.String  @name, System.Single  @newWeight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @newWeight};
            var ___result = RSetStepWeight_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UpdateMonitoredTransaction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateMonitoredTransaction.Invoke(___genericsType, ___parameters);

            
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


    }
}
