﻿using System.Collections.ObjectModel;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    class Command : ProtocolItem
    {
        public Command()
        {
            this.Returns = new Collection<Property>();
            this.Handlers = new Collection<string>();
            this.Parameters = new Collection<Property>();
        }

        public Collection<Property> Returns
        {
            get;
            set;
        }

        public Property Error
        {
            get;
            set;
        }

        public Collection<string> Handlers
        {
            get;
            set;
        }

        public Collection<Property> Parameters
        {
            get;
            set;
        }

        public bool async
        {
            get;
            set;
        }

        public string Redirect
        {
            get;
            set;
        }
    }
}