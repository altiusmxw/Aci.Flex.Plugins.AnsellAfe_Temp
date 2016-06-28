declare function initializeSignalR(): void;
declare function initializeSearch(): void;
declare function setMessageCount(count: any): void;
declare function changeModel(modelIdentifier: any): void;
declare function getQueryStrings(): any[];
declare function swConfirm(message: any, callback: any): void;
declare module Flex.Utils {
    function allTrue(values: boolean[]): boolean;
    function allPromisesTrue(promises: Q.Promise<boolean>[]): Q.Promise<boolean>;
    function join<U, V>(u1: Array<U>, v1: Array<V>, predicate: (item1: U, item2: V) => boolean, selector: (item1: U, item2: V) => any): Array<any>;
    function formatNumberAsCurrency(valueToBeFormatted: number, decimalPlaces: number, decimalSeparator: string, thousandSeparator: string): string;
}
