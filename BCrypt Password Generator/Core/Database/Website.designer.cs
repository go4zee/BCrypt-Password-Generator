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

namespace BCrypt_Password_Generator.Core.Database
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Website")]
	public partial class WebsiteDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public WebsiteDataContext() : 
				base(global::BCrypt_Password_Generator.Properties.Settings.Default.WebsiteConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WebsiteDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebsiteDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebsiteDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebsiteDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _UserID;
		
		private string _UserName;
		
		private string _Password;
		
		private string _UserFirstName;
		
		private string _UserLastName;
		
		private int _UserAccessLevel;
		
		private string _UserEmailAddress;
		
		private System.Nullable<System.DateTime> _UserCreatedOn;
		
		private System.Nullable<System.DateTime> _UserModifiedOn;
		
		private System.Nullable<System.DateTime> _UserTimeStamp;
		
		private bool _UserActive;
		
		private System.Nullable<System.Guid> _UserCreatedByUserID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(System.Guid value);
    partial void OnUserIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnUserFirstNameChanging(string value);
    partial void OnUserFirstNameChanged();
    partial void OnUserLastNameChanging(string value);
    partial void OnUserLastNameChanged();
    partial void OnUserAccessLevelChanging(int value);
    partial void OnUserAccessLevelChanged();
    partial void OnUserEmailAddressChanging(string value);
    partial void OnUserEmailAddressChanged();
    partial void OnUserCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnUserCreatedOnChanged();
    partial void OnUserModifiedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnUserModifiedOnChanged();
    partial void OnUserTimeStampChanging(System.Nullable<System.DateTime> value);
    partial void OnUserTimeStampChanged();
    partial void OnUserActiveChanging(bool value);
    partial void OnUserActiveChanged();
    partial void OnUserCreatedByUserIDChanging(System.Nullable<System.Guid> value);
    partial void OnUserCreatedByUserIDChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserFirstName", DbType="VarChar(50)")]
		public string UserFirstName
		{
			get
			{
				return this._UserFirstName;
			}
			set
			{
				if ((this._UserFirstName != value))
				{
					this.OnUserFirstNameChanging(value);
					this.SendPropertyChanging();
					this._UserFirstName = value;
					this.SendPropertyChanged("UserFirstName");
					this.OnUserFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserLastName", DbType="VarChar(50)")]
		public string UserLastName
		{
			get
			{
				return this._UserLastName;
			}
			set
			{
				if ((this._UserLastName != value))
				{
					this.OnUserLastNameChanging(value);
					this.SendPropertyChanging();
					this._UserLastName = value;
					this.SendPropertyChanged("UserLastName");
					this.OnUserLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserAccessLevel", DbType="Int NOT NULL")]
		public int UserAccessLevel
		{
			get
			{
				return this._UserAccessLevel;
			}
			set
			{
				if ((this._UserAccessLevel != value))
				{
					this.OnUserAccessLevelChanging(value);
					this.SendPropertyChanging();
					this._UserAccessLevel = value;
					this.SendPropertyChanged("UserAccessLevel");
					this.OnUserAccessLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserEmailAddress", DbType="VarChar(60)")]
		public string UserEmailAddress
		{
			get
			{
				return this._UserEmailAddress;
			}
			set
			{
				if ((this._UserEmailAddress != value))
				{
					this.OnUserEmailAddressChanging(value);
					this.SendPropertyChanging();
					this._UserEmailAddress = value;
					this.SendPropertyChanged("UserEmailAddress");
					this.OnUserEmailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> UserCreatedOn
		{
			get
			{
				return this._UserCreatedOn;
			}
			set
			{
				if ((this._UserCreatedOn != value))
				{
					this.OnUserCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._UserCreatedOn = value;
					this.SendPropertyChanged("UserCreatedOn");
					this.OnUserCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserModifiedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> UserModifiedOn
		{
			get
			{
				return this._UserModifiedOn;
			}
			set
			{
				if ((this._UserModifiedOn != value))
				{
					this.OnUserModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._UserModifiedOn = value;
					this.SendPropertyChanged("UserModifiedOn");
					this.OnUserModifiedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserTimeStamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> UserTimeStamp
		{
			get
			{
				return this._UserTimeStamp;
			}
			set
			{
				if ((this._UserTimeStamp != value))
				{
					this.OnUserTimeStampChanging(value);
					this.SendPropertyChanging();
					this._UserTimeStamp = value;
					this.SendPropertyChanged("UserTimeStamp");
					this.OnUserTimeStampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserActive", DbType="Bit NOT NULL")]
		public bool UserActive
		{
			get
			{
				return this._UserActive;
			}
			set
			{
				if ((this._UserActive != value))
				{
					this.OnUserActiveChanging(value);
					this.SendPropertyChanging();
					this._UserActive = value;
					this.SendPropertyChanged("UserActive");
					this.OnUserActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCreatedByUserID", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> UserCreatedByUserID
		{
			get
			{
				return this._UserCreatedByUserID;
			}
			set
			{
				if ((this._UserCreatedByUserID != value))
				{
					this.OnUserCreatedByUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserCreatedByUserID = value;
					this.SendPropertyChanged("UserCreatedByUserID");
					this.OnUserCreatedByUserIDChanged();
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
