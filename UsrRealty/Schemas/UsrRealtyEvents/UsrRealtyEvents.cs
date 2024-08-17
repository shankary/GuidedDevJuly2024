namespace Terrasoft.Configuration
{
    using System;
    using Terrasoft.Common;
    using Terrasoft.Core.Entities;
    using Terrasoft.Core.Entities.Events;
    using global::Common.Logging;
    [EntityEventListener(SchemaName = "UsrRealty")]
    public class RealtyEntityEventListener : BaseEntityEventListener
    {
        private static readonly ILog _log = LogManager.GetLogger("Notifications");

        public override void OnSaving(object sender, EntityBeforeEventArgs e)
        {
            base.OnSaving(sender, e);
            Entity realty = (Entity)sender;
            decimal price = realty.GetTypedColumnValue<decimal>("UsrPriceUSD");
            if (price > 1000000000)
            {
                e.IsCanceled = true;

                _log.Info("Price is too big! But logging in working!");

                string messageTemplate = new LocalizableString(realty.UserConnection.ResourceStorage, 
                    "UsrRealtyEvents", "LocalizableStrings.ValueIsTooBig.Value").ToString();

                string message = string.Format(messageTemplate, "1.0B$");
                throw new Exception(message);
            }
        }
    }
}