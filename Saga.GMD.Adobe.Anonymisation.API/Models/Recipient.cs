using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Saga.GMD.Adobe.Anonymisation.API.Models
{
    public class Recipient
    {
        public string Pers_ID { get; set; }
        public string Hgrp_ID { get; set; }
        public string Email_Saga { get; set; }
        public string Encrypted_Email_Saga { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salutation_Detail { get; set; }
        public string Salutation_Envelope { get; set; }
    }
}