interface JQuery {
    bootstrapValidator(form?, options?): BootstrapValidator;
    validateField(name): void;
}

interface BootstrapValidator {
    _init(): void;
    _parseOptions(field: JQuery): Object;
    _initField(field: string): void;
    _initField(field: JQuery): void;
    _getMessage(field: string, validatorName: string): string;
    _getMessageContainer(field: JQuery, group: string): JQuery;
    _submit(): void;
    _isExcluded(field: JQuery): boolean;
    _exceedTreshold(field: JQuery): boolean;

    // Events
    _onError(e: any): void;
    _onSuccess(e: any): void;
    _onFieldValidatred(field: JQuery, validatorName: string): void;

    // Public Methods
    getOptions(field: string, validator: string, option: string): any;
    getOptions(field: JQuery, validator: string, option: string): any;
    disableSubmitButtons(disabled: boolean): BootstrapValidator;
    validate(): BootstrapValidator;
    validateField(field: string): BootstrapValidator;
    validateField(field: JQuery): BootstrapValidator;
    updateMessage(field: string, validator: string, message: string): BootstrapValidator;
    updateMessage(field: JQuery, validator: string, message: string): BootstrapValidator;
    updateStatus(field: string, status: string, validatorName: string): BootstrapValidator;
    updateStatus(field: JQuery, status: string, validatorName: string): BootstrapValidator;
    isValid(): boolean;
    isValidField(field: string): boolean;
    isValidField(field: JQuery): boolean;
    isValidContainer(container: string): boolean;
    isValidContainer(container: JQuery): boolean;
    defaultSubmit(): void;
    getInvalidFields(): JQuery[];
    getSubmitButton(): JQuery;
    getMessages(field: string, validator: string): string;
    getMessages(field: JQuery, validator: string): string;
    updateOption(field: string, validator: string, option: string, value: string): BootstrapValidator;
    updateOption(field: JQuery, validator: string, option: string, value: string): BootstrapValidator;
    addField(field: string, options: Object): BootstrapValidator;
    addField(field: JQuery, options: Object): BootstrapValidator;
    removeField(field: string): BootstrapValidator;
    removeField(field: JQuery): BootstrapValidator;
    resetField(field: string, resetValue: boolean): BootstrapValidator;
    resetField(field: JQuery, resetValue: boolean): BootstrapValidator;
    resetForm(resetValue: boolean): BootstrapValidator;
    revalidateField(field: string): BootstrapValidator;
    revalidateField(field: JQuery): BootstrapValidator;
    enableFieldValidators(field: string, enabled: boolean, validatorName: string): BootstrapValidator;
    enableFieldValidators(field: JQuery, enabled: boolean, validatorName: string): BootstrapValidator;
    getDynamicOption(field: string, options: string): string;
    getDynamicOption(field: string, options: Function): string;
    getDynamicOption(field: JQuery, options: string): string;
    getDynamicOption(field: JQuery, options: Function): string;
    destroy(): void;
}