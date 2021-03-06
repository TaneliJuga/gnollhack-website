//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Spell</summary>
	[PublishedModel("spell")]
	public partial class Spell : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "spell";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Spell, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Spell(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Long Description: Long description of the spell
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("longDescription")]
		public string LongDescription => this.Value<string>("longDescription");

		///<summary>
		/// Mana Cost: How much mana the spell costs
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("manaCost")]
		public int ManaCost => this.Value<int>("manaCost");

		///<summary>
		/// New or Changed: Whether the spell is new or changed.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("newOrChanged")]
		public bool NewOrChanged => this.Value<bool>("newOrChanged");

		///<summary>
		/// Short Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("shortDescription")]
		public string ShortDescription => this.Value<string>("shortDescription");

		///<summary>
		/// Spell Level: Level of the spell
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("spellLevel")]
		public int SpellLevel => this.Value<int>("spellLevel");
	}
}
