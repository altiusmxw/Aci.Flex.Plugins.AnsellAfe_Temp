using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server.Objects
{
    public enum NotificationSourceType
    {
        ApprovalRequired = 0,
        AfeRejected = 1,
        AfeApproved = 2
    }

    public class NotificationSources
    {
        public static string ApprovalRequired { get { return ((int)NotificationSourceType.ApprovalRequired).ToString(); } }
        public static string AfeRejected { get { return ((int)NotificationSourceType.AfeRejected).ToString(); } }
        public static string AfeApproved { get { return ((int)NotificationSourceType.AfeApproved).ToString(); } }
    }

    public class WorkflowStatusImages
    {
        public static string Success { get { return "./Resources/Images/Aci.Flex.Plugins.AnsellAfe.Web.Images.yes-sm.png"; } }
        public static string Fail { get { return "./Resources/Images/Aci.Flex.Plugins.AnsellAfe.Web.Images.no-sm.png"; } }
        public static string Submit { get { return "./Resources/Images/Aci.Flex.Plugins.AnsellAfe.Web.Images.submit-sm.png"; } }


        public static string Submitted { get { return "./Resources/Images/Aci.Flex.Plugins.AnsellAfe.Web.Images.doa-pending.png"; } }
        public static string Rejected { get { return "./Resources/Images/Aci.Flex.Plugins.AnsellAfe.Web.Images.doa-rejected.png"; } }
        public static string ApprovalInProgress { get { return "./Resources/Images/Aci.Flex.Plugins.AnsellAfe.Web.Images.doa-inprogress.png"; } }
        public static string Approved { get { return "./Resources/Images/Aci.Flex.Plugins.AnsellAfe.Web.Images.doa-approved.png"; } }
    }
}
