using System;
using System.Collections.Generic;
using System.Text;

namespace VanzariClient
{
    public enum EventType
    {
        ADDPRODUS,
        DELETEPRODUS,
        MODPRODUS,
        UPDATECOMANDA,
        RELOADPRODUSE
    }
    public class VanzariEvent
    {
        private readonly EventType userEvent;
        private readonly Object data;

        public VanzariEvent(EventType userEvent, object data)
        {
            this.userEvent = userEvent;
            this.data = data;
        }

        public EventType UserEventType
        {
            get { return userEvent; }
        }

        public object Data
        {
            get { return data; }
        }
    }
}
