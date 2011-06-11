﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ivanov.Build.Server.Cqrs.DataModel
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="cqrstestdb")]
	public partial class DataModelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertJob(Job instance);
    partial void UpdateJob(Job instance);
    partial void DeleteJob(Job instance);
    partial void InsertJobConfiguration(JobConfiguration instance);
    partial void UpdateJobConfiguration(JobConfiguration instance);
    partial void DeleteJobConfiguration(JobConfiguration instance);
    #endregion
		
		public DataModelDataContext() : 
				base(global::Ivanov.Build.Server.Cqrs.Properties.Settings.Default.cqrstestdbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Job> Jobs
		{
			get
			{
				return this.GetTable<Job>();
			}
		}
		
		public System.Data.Linq.Table<JobConfiguration> JobConfigurations
		{
			get
			{
				return this.GetTable<JobConfiguration>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Jobs")]
	public partial class Job : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _JobName;
		
		private System.Nullable<int> _Status;
		
		private System.Nullable<System.DateTime> _LastRun;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnJobNameChanging(string value);
    partial void OnJobNameChanged();
    partial void OnStatusChanging(System.Nullable<int> value);
    partial void OnStatusChanged();
    partial void OnLastRunChanging(System.Nullable<System.DateTime> value);
    partial void OnLastRunChanged();
    #endregion
		
		public Job()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string JobName
		{
			get
			{
				return this._JobName;
			}
			set
			{
				if ((this._JobName != value))
				{
					this.OnJobNameChanging(value);
					this.SendPropertyChanging();
					this._JobName = value;
					this.SendPropertyChanged("JobName");
					this.OnJobNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int")]
		public System.Nullable<int> Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastRun", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastRun
		{
			get
			{
				return this._LastRun;
			}
			set
			{
				if ((this._LastRun != value))
				{
					this.OnLastRunChanging(value);
					this.SendPropertyChanging();
					this._LastRun = value;
					this.SendPropertyChanged("LastRun");
					this.OnLastRunChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.JobConfigurations")]
	public partial class JobConfiguration : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _BatchName;
		
		private string _JobName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnBatchNameChanging(string value);
    partial void OnBatchNameChanged();
    partial void OnJobNameChanging(string value);
    partial void OnJobNameChanged();
    #endregion
		
		public JobConfiguration()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BatchName", DbType="NVarChar(MAX)")]
		public string BatchName
		{
			get
			{
				return this._BatchName;
			}
			set
			{
				if ((this._BatchName != value))
				{
					this.OnBatchNameChanging(value);
					this.SendPropertyChanging();
					this._BatchName = value;
					this.SendPropertyChanged("BatchName");
					this.OnBatchNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string JobName
		{
			get
			{
				return this._JobName;
			}
			set
			{
				if ((this._JobName != value))
				{
					this.OnJobNameChanging(value);
					this.SendPropertyChanging();
					this._JobName = value;
					this.SendPropertyChanged("JobName");
					this.OnJobNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
