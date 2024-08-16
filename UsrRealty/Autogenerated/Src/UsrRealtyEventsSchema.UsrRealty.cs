namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("46aa7942-8bde-411f-846b-d10c07f184f6");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8bdcd449-e106-49ab-9a20-405c36ff5afd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,40,206,207,77,85,112,86,86,72,206,79,73,85,240,112,244,112,84,4,0,223,2,135,172,19,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("46aa7942-8bde-411f-846b-d10c07f184f6"));
		}

		#endregion

	}

	#endregion

}

