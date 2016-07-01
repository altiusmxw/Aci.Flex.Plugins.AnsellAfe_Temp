using Aci.Flex.Core.Exceptions;
using Aci.Flex.Core.Logging;
using Aci.Flex.DataModel;
using Aci.Flex.Server.Core;
using Aci.Flex.Server.Workflow.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server
{
    public class NotificationHelper
    {
        private Guid m_ModelIdentifier;
        private static AnsellAfeModule m_AfeModule;

        public NotificationHelper(Guid modelIdentifier)
        {
            m_ModelIdentifier = modelIdentifier;

            if (m_AfeModule == null)
                m_AfeModule = Aci.Flex.Server.Core.PlatformServices.Data.GetDataModule<AnsellAfeModule>(modelIdentifier);
        }

        public void HandleNotification(NotificationRequestedEventArgs args)
        {
            try
            {
                var notificationSource = PlatformServices.Notification.GetNotificationSource(m_ModelIdentifier, "ModelDefaultNotificationSource");
                if (notificationSource == null)
                {
                    Log.Exception(new FlexException(string.Format("Could not find NotificationSource with ModelIdentifier: {0}, Id: {1}", m_ModelIdentifier, args.NotificationSourceId)));
                    return;
                }

                var message = "New Message";

                if (args.NotificationSourceId == "0")
                {
                    message = "Approval Required";
                }
                else if (args.NotificationSourceId == "1")
                {
                    message = "AFE Rejected";
                }
                else if (args.NotificationSourceId == "2")
                {
                    message = "AFE Approved";
                }

                PlatformServices.Notification.Notify(notificationSource, message, "", GetUserRestrictions(args.UserRestrictions), "", new Core.FlexUri(Guid.Parse("D6A11415-0C13-4198-B432-886234114AF9"), m_ModelIdentifier));
            }
            catch (Exception ex)
            {
                Log.Exception(new FlexException(
                    string.Format("Failed to send notification for WorkflowId: {0}, NotificationSourceId: {1}.", args.WorkflowId, args.NotificationSourceId),
                    ex));
            }
        }

        private IEnumerable<Guid> GetUserRestrictions(string restrictions)
        {
            List<Guid> result = new List<Guid>();

            if (!string.IsNullOrEmpty(restrictions))
            {
                var roles = restrictions.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var role in roles)
                {
                    Guid id;
                    if (Guid.TryParse(role, out id))
                    {
                        result.Add(id);
                    }
                }
            }

            return result;
        }
    }
}
