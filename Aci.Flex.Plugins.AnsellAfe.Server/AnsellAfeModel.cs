using Aci.Flex.Core.Configuration;
using Aci.Flex.DataModel;
using Aci.Flex.Interfaces;
using Aci.Flex.Plugins.AnsellAfe.Server.Objects;
using Aci.Flex.Server;
using Aci.Flex.Server.ObjectModel;
using Aci.Flex.Server.Workflow.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server
{
    [ExportAsFlexPlugin(typeof(AnsellAfeModel), typeof(IFlexModel), false)]
    public class AnsellAfeModel : BaseModel
    {
        public override string Name { get { return "Ansell AFE Tracker Demo"; } }

        public override IEnumerable<SiteMapNode> GetDefaultSiteMap()
        {
            return SiteMapHelper.GetDefaultSiteMap("Aci.Flex.Plugins.AnsellAfe.Server.ansellafe.sitemap");
        }

        public override Type ConfigurationType
        {
            get
            {
                return typeof(AnsellAfePlanningConfiguration);
            }
        }

        public override void HandleEventBrokerEvents(Core.EventBroker.EventManagerEventArgs eventArgs)
        {
            if (eventArgs.TopicName == WorkflowEventTopics.NotificationRequested.ToString())
            {
                NotificationRequestedEventArgs args = (NotificationRequestedEventArgs)eventArgs.InnerEventArgs;

                var notificationHelper = new NotificationHelper(ModelIdentifier);
                notificationHelper.HandleNotification(args);
            }
            else if (eventArgs.TopicName == WorkflowEventTopics.BeforeStateChanged.ToString())
            {
                var ev = eventArgs.InnerEventArgs as BeforeStateChangedEventArgs;

                if (ev != null)
                {
                    if (ev.NewState == "Recalled")
                        ev.StateImageUrl = string.Format("[{0}|{1}]", WorkflowStatusImages.Rejected, "Recalled");
                    else if (ev.NewState == "Submitted")
                        ev.StateImageUrl = string.Format("[{0}|{1}]", WorkflowStatusImages.Submitted, "Submitted");
                    else if (ev.NewState == "Rejected")
                        ev.StateImageUrl = string.Format("[{0}|{1}]", WorkflowStatusImages.Rejected, "Rejected");
                    else if (ev.NewState == "Approved")
                        ev.StateImageUrl = string.Format("[{0}|{1}]", WorkflowStatusImages.Approved, "Approval Complete");
                    else if (ev.NewState == "Approval In Progress")
                        ev.StateImageUrl = string.Format("[{0}|{1}]", WorkflowStatusImages.ApprovalInProgress, "Approval in Progress");
                }
            }
        }

        public override IEnumerable<SearchResult> Search(string searchTerm)
        {
            var afeModule = Aci.Flex.Server.Core.PlatformServices.Data.GetDataModule<AnsellAfeModule>(ModelIdentifier);
            return afeModule.Search(searchTerm);
        }
    }

    public class AnsellAfePlanningConfiguration : BaseConfiguration, IPlanningConfiguration
    {
        public Guid AdministratorRoleId { get; set; }
        public string ModelMailboxAddress { get; set; }
        public bool PersistNullOrEmptyValues { get; set; }
        public bool PersistZeroValues { get; set; }
        public Guid ReaderRoleId { get; set; }
        public string SiteTitle { get; set; }
        public Guid SubmitterRoleId { get; set; }

        public string OlapConnectionString { get; set; }
        public string OlapDatabaseId { get; set; }
        public string OlapServerName { get; set; }
    }
}
