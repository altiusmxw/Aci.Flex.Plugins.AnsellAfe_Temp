module Aci.Flex.Plugins.AnsellAfe.Server {
    export enum AfeTypeType {
        Original = 0,
        Supplement = 1
    }
    export enum AfeStatus {
        Pending = 0,
        Approved = 1,
        Closed = 2
    }
}
module Aci.Flex.Plugins.AnsellAfe.Web.Models {
    export enum AfeCreateType {
        Clone = 0,
        Edit = 1,
        New = 2,
        Resubmit = 3
    }
}