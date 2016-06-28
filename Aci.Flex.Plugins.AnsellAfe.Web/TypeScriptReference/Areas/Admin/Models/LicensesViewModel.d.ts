declare class LicencesViewModel {
    licensePacks: KnockoutObservableArray<Aci.Flex.DataModel.ModelLicense>;
    addingLicense: KnockoutObservable<AddLicensePackModel>;
    modelIdentifier: string;
    load(modelIdentifier: string): Q.Promise<boolean>;
    bindLicenses: () => Q.Promise<boolean>;
    showAddLicense: () => void;
    addLicense: () => void;
}
declare class AddLicensePackModel {
    licenseStorageItem: KnockoutObservable<Aci.Flex.DataModel.StorageItem>;
    modelLicense: KnockoutObservable<Aci.Flex.DataModel.ModelLicense>;
    licenseData: string;
    modelIdentifier: string;
    constructor(modelIdentifier: string);
    load: () => void;
    validateLicense: () => void;
}
declare function BindLicensesViewModel(modelIdentifier: string): void;
