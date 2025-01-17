﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa_Datos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="monolitico4a")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Inserttbl_producto(tbl_producto instance);
    partial void Updatetbl_producto(tbl_producto instance);
    partial void Deletetbl_producto(tbl_producto instance);
    partial void Inserttbl_proveedor(tbl_proveedor instance);
    partial void Updatetbl_proveedor(tbl_proveedor instance);
    partial void Deletetbl_proveedor(tbl_proveedor instance);
    partial void Inserttbl_tipo_usuario(tbl_tipo_usuario instance);
    partial void Updatetbl_tipo_usuario(tbl_tipo_usuario instance);
    partial void Deletetbl_tipo_usuario(tbl_tipo_usuario instance);
    partial void Inserttbl_usuario(tbl_usuario instance);
    partial void Updatetbl_usuario(tbl_usuario instance);
    partial void Deletetbl_usuario(tbl_usuario instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Capa_Datos.Properties.Settings.Default.monolitico4aConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_producto> tbl_producto
		{
			get
			{
				return this.GetTable<tbl_producto>();
			}
		}
		
		public System.Data.Linq.Table<tbl_proveedor> tbl_proveedor
		{
			get
			{
				return this.GetTable<tbl_proveedor>();
			}
		}
		
		public System.Data.Linq.Table<tbl_tipo_usuario> tbl_tipo_usuario
		{
			get
			{
				return this.GetTable<tbl_tipo_usuario>();
			}
		}
		
		public System.Data.Linq.Table<tbl_usuario> tbl_usuario
		{
			get
			{
				return this.GetTable<tbl_usuario>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_producto")]
	public partial class tbl_producto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pro_id;
		
		private string _pro_nombre;
		
		private System.Nullable<int> _pro_cantidad;
		
		private System.Nullable<char> _pro_estado;
		
		private System.Nullable<int> _prov_id;
		
		private System.Data.Linq.Binary _pro_imagen;
		
		private EntityRef<tbl_proveedor> _tbl_proveedor;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onpro_idChanging(int value);
    partial void Onpro_idChanged();
    partial void Onpro_nombreChanging(string value);
    partial void Onpro_nombreChanged();
    partial void Onpro_cantidadChanging(System.Nullable<int> value);
    partial void Onpro_cantidadChanged();
    partial void Onpro_estadoChanging(System.Nullable<char> value);
    partial void Onpro_estadoChanged();
    partial void Onprov_idChanging(System.Nullable<int> value);
    partial void Onprov_idChanged();
    partial void Onpro_imagenChanging(System.Data.Linq.Binary value);
    partial void Onpro_imagenChanged();
    #endregion
		
		public tbl_producto()
		{
			this._tbl_proveedor = default(EntityRef<tbl_proveedor>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int pro_id
		{
			get
			{
				return this._pro_id;
			}
			set
			{
				if ((this._pro_id != value))
				{
					this.Onpro_idChanging(value);
					this.SendPropertyChanging();
					this._pro_id = value;
					this.SendPropertyChanged("pro_id");
					this.Onpro_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_nombre", DbType="VarChar(50)")]
		public string pro_nombre
		{
			get
			{
				return this._pro_nombre;
			}
			set
			{
				if ((this._pro_nombre != value))
				{
					this.Onpro_nombreChanging(value);
					this.SendPropertyChanging();
					this._pro_nombre = value;
					this.SendPropertyChanged("pro_nombre");
					this.Onpro_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_cantidad", DbType="Int")]
		public System.Nullable<int> pro_cantidad
		{
			get
			{
				return this._pro_cantidad;
			}
			set
			{
				if ((this._pro_cantidad != value))
				{
					this.Onpro_cantidadChanging(value);
					this.SendPropertyChanging();
					this._pro_cantidad = value;
					this.SendPropertyChanged("pro_cantidad");
					this.Onpro_cantidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_estado", DbType="Char(1)")]
		public System.Nullable<char> pro_estado
		{
			get
			{
				return this._pro_estado;
			}
			set
			{
				if ((this._pro_estado != value))
				{
					this.Onpro_estadoChanging(value);
					this.SendPropertyChanging();
					this._pro_estado = value;
					this.SendPropertyChanged("pro_estado");
					this.Onpro_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prov_id", DbType="Int")]
		public System.Nullable<int> prov_id
		{
			get
			{
				return this._prov_id;
			}
			set
			{
				if ((this._prov_id != value))
				{
					if (this._tbl_proveedor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onprov_idChanging(value);
					this.SendPropertyChanging();
					this._prov_id = value;
					this.SendPropertyChanged("prov_id");
					this.Onprov_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_imagen", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary pro_imagen
		{
			get
			{
				return this._pro_imagen;
			}
			set
			{
				if ((this._pro_imagen != value))
				{
					this.Onpro_imagenChanging(value);
					this.SendPropertyChanging();
					this._pro_imagen = value;
					this.SendPropertyChanged("pro_imagen");
					this.Onpro_imagenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_proveedor_tbl_producto", Storage="_tbl_proveedor", ThisKey="prov_id", OtherKey="prov_id", IsForeignKey=true)]
		public tbl_proveedor tbl_proveedor
		{
			get
			{
				return this._tbl_proveedor.Entity;
			}
			set
			{
				tbl_proveedor previousValue = this._tbl_proveedor.Entity;
				if (((previousValue != value) 
							|| (this._tbl_proveedor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_proveedor.Entity = null;
						previousValue.tbl_producto.Remove(this);
					}
					this._tbl_proveedor.Entity = value;
					if ((value != null))
					{
						value.tbl_producto.Add(this);
						this._prov_id = value.prov_id;
					}
					else
					{
						this._prov_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("tbl_proveedor");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_proveedor")]
	public partial class tbl_proveedor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _prov_id;
		
		private string _prov_nombre;
		
		private System.Nullable<char> _prov_estado;
		
		private EntitySet<tbl_producto> _tbl_producto;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onprov_idChanging(int value);
    partial void Onprov_idChanged();
    partial void Onprov_nombreChanging(string value);
    partial void Onprov_nombreChanged();
    partial void Onprov_estadoChanging(System.Nullable<char> value);
    partial void Onprov_estadoChanged();
    #endregion
		
		public tbl_proveedor()
		{
			this._tbl_producto = new EntitySet<tbl_producto>(new Action<tbl_producto>(this.attach_tbl_producto), new Action<tbl_producto>(this.detach_tbl_producto));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prov_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int prov_id
		{
			get
			{
				return this._prov_id;
			}
			set
			{
				if ((this._prov_id != value))
				{
					this.Onprov_idChanging(value);
					this.SendPropertyChanging();
					this._prov_id = value;
					this.SendPropertyChanged("prov_id");
					this.Onprov_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prov_nombre", DbType="VarChar(50)")]
		public string prov_nombre
		{
			get
			{
				return this._prov_nombre;
			}
			set
			{
				if ((this._prov_nombre != value))
				{
					this.Onprov_nombreChanging(value);
					this.SendPropertyChanging();
					this._prov_nombre = value;
					this.SendPropertyChanged("prov_nombre");
					this.Onprov_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prov_estado", DbType="Char(1)")]
		public System.Nullable<char> prov_estado
		{
			get
			{
				return this._prov_estado;
			}
			set
			{
				if ((this._prov_estado != value))
				{
					this.Onprov_estadoChanging(value);
					this.SendPropertyChanging();
					this._prov_estado = value;
					this.SendPropertyChanged("prov_estado");
					this.Onprov_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_proveedor_tbl_producto", Storage="_tbl_producto", ThisKey="prov_id", OtherKey="prov_id")]
		public EntitySet<tbl_producto> tbl_producto
		{
			get
			{
				return this._tbl_producto;
			}
			set
			{
				this._tbl_producto.Assign(value);
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
		
		private void attach_tbl_producto(tbl_producto entity)
		{
			this.SendPropertyChanging();
			entity.tbl_proveedor = this;
		}
		
		private void detach_tbl_producto(tbl_producto entity)
		{
			this.SendPropertyChanging();
			entity.tbl_proveedor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_tipo_usuario")]
	public partial class tbl_tipo_usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _tusu_id;
		
		private string _tusu_nombre;
		
		private System.Nullable<char> _tusu_estado;
		
		private EntitySet<tbl_usuario> _tbl_usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ontusu_idChanging(int value);
    partial void Ontusu_idChanged();
    partial void Ontusu_nombreChanging(string value);
    partial void Ontusu_nombreChanged();
    partial void Ontusu_estadoChanging(System.Nullable<char> value);
    partial void Ontusu_estadoChanged();
    #endregion
		
		public tbl_tipo_usuario()
		{
			this._tbl_usuario = new EntitySet<tbl_usuario>(new Action<tbl_usuario>(this.attach_tbl_usuario), new Action<tbl_usuario>(this.detach_tbl_usuario));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int tusu_id
		{
			get
			{
				return this._tusu_id;
			}
			set
			{
				if ((this._tusu_id != value))
				{
					this.Ontusu_idChanging(value);
					this.SendPropertyChanging();
					this._tusu_id = value;
					this.SendPropertyChanged("tusu_id");
					this.Ontusu_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_nombre", DbType="VarChar(50)")]
		public string tusu_nombre
		{
			get
			{
				return this._tusu_nombre;
			}
			set
			{
				if ((this._tusu_nombre != value))
				{
					this.Ontusu_nombreChanging(value);
					this.SendPropertyChanging();
					this._tusu_nombre = value;
					this.SendPropertyChanged("tusu_nombre");
					this.Ontusu_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_estado", DbType="Char(1)")]
		public System.Nullable<char> tusu_estado
		{
			get
			{
				return this._tusu_estado;
			}
			set
			{
				if ((this._tusu_estado != value))
				{
					this.Ontusu_estadoChanging(value);
					this.SendPropertyChanging();
					this._tusu_estado = value;
					this.SendPropertyChanged("tusu_estado");
					this.Ontusu_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_tipo_usuario_tbl_usuario", Storage="_tbl_usuario", ThisKey="tusu_id", OtherKey="tusu_id")]
		public EntitySet<tbl_usuario> tbl_usuario
		{
			get
			{
				return this._tbl_usuario;
			}
			set
			{
				this._tbl_usuario.Assign(value);
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
		
		private void attach_tbl_usuario(tbl_usuario entity)
		{
			this.SendPropertyChanging();
			entity.tbl_tipo_usuario = this;
		}
		
		private void detach_tbl_usuario(tbl_usuario entity)
		{
			this.SendPropertyChanging();
			entity.tbl_tipo_usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_usuario")]
	public partial class tbl_usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _usu_id;
		
		private string _usu_cedula;
		
		private string _usu_nombre_completo;
		
		private string _usu_direccion;
		
		private System.Nullable<System.DateTime> _usu_fecha_creacion;
		
		private string _usu_contraseña;
		
		private System.Data.Linq.Binary _usu_contra_enc;
		
		private string _usu_correo;
		
		private System.Nullable<char> _usu_estado;
		
		private System.Nullable<int> _tusu_id;
		
		private EntityRef<tbl_tipo_usuario> _tbl_tipo_usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onusu_idChanging(int value);
    partial void Onusu_idChanged();
    partial void Onusu_cedulaChanging(string value);
    partial void Onusu_cedulaChanged();
    partial void Onusu_nombre_completoChanging(string value);
    partial void Onusu_nombre_completoChanged();
    partial void Onusu_direccionChanging(string value);
    partial void Onusu_direccionChanged();
    partial void Onusu_fecha_creacionChanging(System.Nullable<System.DateTime> value);
    partial void Onusu_fecha_creacionChanged();
    partial void Onusu_contraseñaChanging(string value);
    partial void Onusu_contraseñaChanged();
    partial void Onusu_contra_encChanging(System.Data.Linq.Binary value);
    partial void Onusu_contra_encChanged();
    partial void Onusu_correoChanging(string value);
    partial void Onusu_correoChanged();
    partial void Onusu_estadoChanging(System.Nullable<char> value);
    partial void Onusu_estadoChanged();
    partial void Ontusu_idChanging(System.Nullable<int> value);
    partial void Ontusu_idChanged();
    #endregion
		
		public tbl_usuario()
		{
			this._tbl_tipo_usuario = default(EntityRef<tbl_tipo_usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int usu_id
		{
			get
			{
				return this._usu_id;
			}
			set
			{
				if ((this._usu_id != value))
				{
					this.Onusu_idChanging(value);
					this.SendPropertyChanging();
					this._usu_id = value;
					this.SendPropertyChanged("usu_id");
					this.Onusu_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_cedula", DbType="VarChar(10)")]
		public string usu_cedula
		{
			get
			{
				return this._usu_cedula;
			}
			set
			{
				if ((this._usu_cedula != value))
				{
					this.Onusu_cedulaChanging(value);
					this.SendPropertyChanging();
					this._usu_cedula = value;
					this.SendPropertyChanged("usu_cedula");
					this.Onusu_cedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_nombre_completo", DbType="VarChar(100)")]
		public string usu_nombre_completo
		{
			get
			{
				return this._usu_nombre_completo;
			}
			set
			{
				if ((this._usu_nombre_completo != value))
				{
					this.Onusu_nombre_completoChanging(value);
					this.SendPropertyChanging();
					this._usu_nombre_completo = value;
					this.SendPropertyChanged("usu_nombre_completo");
					this.Onusu_nombre_completoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_direccion", DbType="VarChar(100)")]
		public string usu_direccion
		{
			get
			{
				return this._usu_direccion;
			}
			set
			{
				if ((this._usu_direccion != value))
				{
					this.Onusu_direccionChanging(value);
					this.SendPropertyChanging();
					this._usu_direccion = value;
					this.SendPropertyChanged("usu_direccion");
					this.Onusu_direccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_fecha_creacion", DbType="DateTime")]
		public System.Nullable<System.DateTime> usu_fecha_creacion
		{
			get
			{
				return this._usu_fecha_creacion;
			}
			set
			{
				if ((this._usu_fecha_creacion != value))
				{
					this.Onusu_fecha_creacionChanging(value);
					this.SendPropertyChanging();
					this._usu_fecha_creacion = value;
					this.SendPropertyChanged("usu_fecha_creacion");
					this.Onusu_fecha_creacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_contraseña", DbType="VarChar(50)")]
		public string usu_contraseña
		{
			get
			{
				return this._usu_contraseña;
			}
			set
			{
				if ((this._usu_contraseña != value))
				{
					this.Onusu_contraseñaChanging(value);
					this.SendPropertyChanging();
					this._usu_contraseña = value;
					this.SendPropertyChanged("usu_contraseña");
					this.Onusu_contraseñaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_contra_enc", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary usu_contra_enc
		{
			get
			{
				return this._usu_contra_enc;
			}
			set
			{
				if ((this._usu_contra_enc != value))
				{
					this.Onusu_contra_encChanging(value);
					this.SendPropertyChanging();
					this._usu_contra_enc = value;
					this.SendPropertyChanged("usu_contra_enc");
					this.Onusu_contra_encChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_correo", DbType="VarChar(100)")]
		public string usu_correo
		{
			get
			{
				return this._usu_correo;
			}
			set
			{
				if ((this._usu_correo != value))
				{
					this.Onusu_correoChanging(value);
					this.SendPropertyChanging();
					this._usu_correo = value;
					this.SendPropertyChanged("usu_correo");
					this.Onusu_correoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_estado", DbType="Char(1)")]
		public System.Nullable<char> usu_estado
		{
			get
			{
				return this._usu_estado;
			}
			set
			{
				if ((this._usu_estado != value))
				{
					this.Onusu_estadoChanging(value);
					this.SendPropertyChanging();
					this._usu_estado = value;
					this.SendPropertyChanged("usu_estado");
					this.Onusu_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_id", DbType="Int")]
		public System.Nullable<int> tusu_id
		{
			get
			{
				return this._tusu_id;
			}
			set
			{
				if ((this._tusu_id != value))
				{
					if (this._tbl_tipo_usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ontusu_idChanging(value);
					this.SendPropertyChanging();
					this._tusu_id = value;
					this.SendPropertyChanged("tusu_id");
					this.Ontusu_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_tipo_usuario_tbl_usuario", Storage="_tbl_tipo_usuario", ThisKey="tusu_id", OtherKey="tusu_id", IsForeignKey=true)]
		public tbl_tipo_usuario tbl_tipo_usuario
		{
			get
			{
				return this._tbl_tipo_usuario.Entity;
			}
			set
			{
				tbl_tipo_usuario previousValue = this._tbl_tipo_usuario.Entity;
				if (((previousValue != value) 
							|| (this._tbl_tipo_usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_tipo_usuario.Entity = null;
						previousValue.tbl_usuario.Remove(this);
					}
					this._tbl_tipo_usuario.Entity = value;
					if ((value != null))
					{
						value.tbl_usuario.Add(this);
						this._tusu_id = value.tusu_id;
					}
					else
					{
						this._tusu_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("tbl_tipo_usuario");
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
