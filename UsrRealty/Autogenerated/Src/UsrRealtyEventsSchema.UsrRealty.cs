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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,81,111,218,48,16,126,175,212,255,112,141,246,144,72,200,106,95,233,168,84,24,155,144,186,110,42,176,151,169,154,28,231,146,122,115,108,100,59,48,86,245,191,239,28,135,1,161,147,122,15,224,216,223,221,125,223,119,182,230,53,186,21,23,8,11,180,150,59,83,122,54,49,186,148,85,99,185,151,70,159,159,61,159,159,1,69,227,164,174,96,190,117,30,235,235,195,173,195,196,186,54,250,191,135,22,217,84,123,233,37,186,183,96,216,116,141,218,31,67,43,101,114,174,134,195,216,137,221,153,170,162,237,14,242,189,205,220,182,105,119,146,120,106,180,233,92,60,97,205,239,73,38,140,32,89,58,251,128,92,249,109,146,61,198,164,85,147,43,41,64,40,238,28,196,179,87,202,192,16,198,220,225,43,39,177,74,231,81,91,208,202,53,247,8,206,147,127,2,44,242,194,104,181,133,25,145,133,31,138,126,70,64,203,207,92,243,10,45,251,132,62,168,32,166,201,189,241,178,148,162,181,221,37,25,169,58,168,26,105,154,53,121,37,11,132,181,145,5,124,209,115,190,38,253,169,201,127,162,240,224,80,23,104,7,16,105,142,177,36,59,91,178,183,182,114,128,217,190,220,1,223,16,57,105,99,255,170,237,202,96,118,125,12,139,117,131,36,114,137,100,164,113,35,139,9,61,112,129,66,214,92,5,63,68,240,62,102,5,189,139,237,10,139,137,81,77,173,191,113,213,224,251,14,122,147,134,249,124,13,248,229,252,67,210,239,46,75,72,99,177,27,184,186,220,69,118,12,234,9,11,129,108,230,38,92,11,84,88,16,15,111,27,60,178,118,23,97,54,108,166,75,147,38,45,7,144,14,188,49,144,203,234,2,198,141,7,21,111,27,72,13,27,99,127,209,242,162,55,165,93,56,111,3,144,158,150,163,33,47,176,94,169,112,37,70,160,113,67,195,23,92,201,63,60,87,56,111,113,105,103,205,210,161,165,183,167,105,148,116,3,216,3,58,211,88,65,32,99,169,202,0,78,251,132,216,223,233,248,94,146,1,36,39,45,28,107,157,158,185,133,49,99,89,197,175,36,99,11,211,81,120,139,14,226,31,55,216,71,99,107,238,211,158,62,106,124,197,46,199,239,78,38,23,194,63,89,179,105,245,79,127,11,92,5,133,187,252,62,252,101,255,217,45,233,239,229,47,210,41,81,230,170,4,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ac3c12a0-80e2-5d26-426d-2eb7e912ad75"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("8bdcd449-e106-49ab-9a20-405c36ff5afd"),
				CreatedInSchemaUId = new Guid("46aa7942-8bde-411f-846b-d10c07f184f6"),
				ModifiedInSchemaUId = new Guid("46aa7942-8bde-411f-846b-d10c07f184f6")
			};
			return localizableString;
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

