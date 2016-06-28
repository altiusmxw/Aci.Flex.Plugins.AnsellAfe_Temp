declare module Aci.Flex.Portal.ServiceHelper {
    function PostData<T>(url: string, payload: any): Q.Promise<T>;
    function PostDataArray<T>(url: string, payload: any): Q.Promise<Array<T>>;
    function GetData<T>(url: string, mapping: any, koMap: boolean): Q.Promise<T>;
    function GetArrayData<T>(url: string, mapping: any): Q.Promise<Array<T>>;
    function GetAssignedHierarchyRoles(userIdentifier: string): Q.Promise<Array<Aci.Flex.Server.ObjectModel.UserHierarchyRoleInfo>>;
}
