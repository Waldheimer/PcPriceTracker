using CommunityToolkit.Mvvm.Messaging.Messages;
using System.Windows;

namespace PcPriceTracker.Messages
{
    //  *********************************************************************************
    //  Message for sending the current Size of the Application
    //  *********************************************************************************
    public class ApplicationSizeMessage : ValueChangedMessage<Size>
    {
        public ApplicationSizeMessage(Size value) : base(value) { }
    }
}
