﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://www.freesql.net
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace Atlass.Framework.Models
{

	[JsonObject(MemberSerialization.OptIn)]
	public partial class cms_template
	{
		[JsonProperty,Column(IsPrimary =true,IsIdentity =true)]
		public int id { get; set; }
		[JsonProperty]
		public long edit_id { get; set; }

		[JsonProperty, Column(DbType = "datetime")]
		public DateTime edit_time { get; set; }

		/// <summary>
		/// 生成的文件名，单页模板使用
		/// </summary>
		[JsonProperty]
		public string file_name { get; set; } = string.Empty;

		[JsonProperty]
		public long insert_id { get; set; }

		[JsonProperty, Column(DbType = "datetime")]
		public DateTime insert_time { get; set; }

		/// <summary>
		/// 1-首页，2-栏目模板，3-内容模板，4-单页模板
		/// </summary>
		[JsonProperty]
		public int pid { get; set; }
		/// <summary>
		/// 模板名称
		/// </summary>
		[JsonProperty]
		public string template_name { get; set; } = string.Empty;
		/// <summary>
		/// 模板文件
		/// </summary>
		[JsonProperty]
		public string template_file { get; set; } = string.Empty;
		/// <summary>
		/// 模板内容
		/// </summary>
		[JsonProperty, Column(DbType = "longtext")]
		public string template_content { get; set; } = string.Empty;


		/// <summary>
		/// 1-首页，2-栏目模板，3-内容模板，4-单页模板
		/// </summary>
		[JsonProperty, Column(DbType = "int(10)")]
		public int template_mode { get; set; }

		/// <summary>
		/// 是否为默认模板 0-否，1-是
		/// </summary>
		[JsonProperty]
		public int is_default { get; set; }

	}

}

