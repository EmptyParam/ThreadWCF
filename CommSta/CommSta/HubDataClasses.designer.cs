﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommSta
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Hub")]
	public partial class HubDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public HubDataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["HubConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HubDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HubDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HubDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HubDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GroupAccess_Save")]
		public int GroupAccess_Save([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> groupID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(4028)")] string exception, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(4028)")] string innerException)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), groupID, exception, innerException);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Exception_Save")]
		public int Exception_Save([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string methodName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(MAX)")] string note, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(MAX)")] string exMessage, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(MAX)")] string exInnerExceptionMessage, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(MAX)")] string exHelpLink, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> exHResult, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(MAX)")] string exSource, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(MAX)")] string exStackTrace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), methodName, note, exMessage, exInnerExceptionMessage, exHelpLink, exHResult, exSource, exStackTrace);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Comm_ReadForSta")]
		public ISingleResult<Comm_ReadForStaResult> Comm_ReadForSta([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsNewComm", DbType="Bit")] System.Nullable<bool> isNewComm)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), isNewComm);
			return ((ISingleResult<Comm_ReadForStaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Comm_Set")]
		public int Comm_Set([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(512)")] string link, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> groupID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(256)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(512)")] string photoLink)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), link, groupID, name, photoLink);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.StaCommVKDaily_Save")]
		public int StaCommVKDaily_Save([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> groupID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> dayDate, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> commViews, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> commVisitors, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> commReach, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> commReachSubscribers, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> commSubscribed, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> commUnsubscribed, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> commLikes, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> commComments, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> commReposts, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> commPostCount, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> commMembers)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), groupID, dayDate, commViews, commVisitors, commReach, commReachSubscribers, commSubscribed, commUnsubscribed, commLikes, commComments, commReposts, commPostCount, commMembers);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class Comm_ReadForStaResult
	{
		
		private System.Nullable<long> _groupID;
		
		private string _link;
		
		public Comm_ReadForStaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_groupID", DbType="BigInt")]
		public System.Nullable<long> groupID
		{
			get
			{
				return this._groupID;
			}
			set
			{
				if ((this._groupID != value))
				{
					this._groupID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_link", DbType="VarChar(512)")]
		public string link
		{
			get
			{
				return this._link;
			}
			set
			{
				if ((this._link != value))
				{
					this._link = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
