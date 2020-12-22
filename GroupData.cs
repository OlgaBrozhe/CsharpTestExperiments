using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    class GroupData
    {
        private string group_name;
        private string group_header = "";
        private string group_footer = "";

        //Handles working with group name only
        public GroupData(string group_name)
        {
            this.group_name = group_name;
        }

        //Working with all group fields
        public GroupData(string group_name, string group_header, string group_footer)
        {
            this.group_name = group_name;
            this.group_header = group_header;
            this.group_footer = group_footer;
        }

        public string GroupName
        {
            get
            {
                return group_name;
            }
            set
            {
                group_name = value;
            }
        }

        public string GroupHeader
        {
            get
            {
                return group_header;
            }
            set
            {
                group_header = value;
            }
        }

        public string GroupFooter
        {
            get
            {
                return group_footer;
            }
            set
            {
                group_footer = value;
            }
        }


    }
}
