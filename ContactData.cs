namespace WebAddressbookTests
{
    public class ContactData
    {
        private string contact_firstname;
        private string contact_lastname = "";
        private string contact_address = "";

        //Required fields
        public ContactData(string contact_firstname, string contact_lastname)
        {
            this.contact_firstname = contact_firstname;
            this.contact_lastname = contact_lastname;
        }

        public string ContactFirstName
        {
            get
            {
                return contact_firstname;
            }
            set
            {
                contact_firstname = value;
            }
        }

        public string ContactLasttName
        {
            get
            {
                return contact_lastname;
            }
            set
            {
                contact_lastname = value;
            }
        }
    }
}
