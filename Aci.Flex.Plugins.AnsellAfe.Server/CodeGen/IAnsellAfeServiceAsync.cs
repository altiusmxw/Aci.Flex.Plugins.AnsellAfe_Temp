using System;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ServiceModel;


namespace Aci.Flex.Plugins.AnsellAfe.Server.Interfaces
{
	[ServiceContract(Name = "IAnsellAfeService")]
	public partial interface IAnsellAfeServiceAsync :  IAnsellAfeService
	{
		[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<bool> DummyDatabaseCallAsync();

			[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<System.Collections.Generic.IEnumerable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Division>> GetDivisionsAsync();

			[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<System.Collections.Generic.IEnumerable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Function>> GetFunctionsAsync();

			[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<System.Collections.Generic.IEnumerable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Site>> GetSitesAsync();

			[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<System.Collections.Generic.IEnumerable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Nature>> GetNaturesAsync();

			[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<System.Collections.Generic.IEnumerable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Purpose>> GetPurposesAsync();

			[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<System.Collections.Generic.IEnumerable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Currency>> GetCurrenciesAsync();

			[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<decimal> GetExchangeRateAsync(int fromCurrencyId,int toCurrencyId);

			[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<System.Collections.Generic.IEnumerable<System.Tuple<int, decimal>>> GetUsdExchangeRateAsync();

			[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<decimal> GetBudgetAsync(int divisionId,int functionId,int siteId,int year);

			[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<decimal> GetPreviousAfeCostsAsync(int divisionId,int functionId,int siteId,int year);

			[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<Aci.Flex.Plugins.AnsellAfe.Server.Objects.SaveAfeReturnDetails> SaveAfeAsync(System.Guid userIdentifier,Aci.Flex.Plugins.AnsellAfe.Server.Objects.AfeSubmitData afeData,bool isDraft);

			[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<System.Collections.Generic.IEnumerable<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe>> FindAfesAsync(string searchTerm);

			[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Afe> GetAfeAsync(long afeId);

			[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<System.Collections.Generic.IEnumerable<Aci.Flex.Core.PersonInfo>> FindUsersAsync(string ntId,string firstname,string lastname,string email);

			[OperationContract]
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
			Task<System.Collections.Generic.IEnumerable<Aci.Flex.Core.PersonInfo>> GetAuthorizationChainAsync(int natureId,int divisionId,int functionId,decimal amount);

			 
	}
}
