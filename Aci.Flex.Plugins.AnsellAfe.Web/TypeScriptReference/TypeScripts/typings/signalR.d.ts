

interface MyHubConnection extends HubConnection {
    client: {
        workflowUpdated: (workflowInstanceId: string) => void;
        newInfoMessage: (title: string, message: string, onclick: string) => void;
        messageCountChange: (count: number) => void;
        avatarChanged: (userIdentifier: string, cacheStamp: string) => void;
        newMessageReceived: () => void;
        jobQueueChanged: (jobInstanceIdentifier: string) => void;
    };
}

interface SignalR {
    signalRDelivery: MyHubConnection;
}

