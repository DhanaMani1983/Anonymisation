using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Saga.GMD.Adobe.Anonymisation.API;
using Saga.GMD.Adobe.Anonymisation.Data;

namespace Saga.GMD.Adobe.Anonymisation.API.Controllers
{
    public class ExtractCPRecipientsController : ApiController
    {
        private GMD_DWHEntities db = new GMD_DWHEntities();
        // POST: api/ExtractCPRecipients
        [ResponseType(typeof(Models.ObfuscatedRecipient))]
        public IHttpActionResult PostExtractRecipient(ExtractCPRecipient extractCPRecipient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ExtractCPRecipient queryObject = db.ExtractCPRecipients.Find(extractCPRecipient.Pers_id);
            Models.ObfuscatedRecipient returnDetails = new Models.ObfuscatedRecipient();

            returnDetails.Pers_ID = queryObject.Pers_id.ToString();
            returnDetails.Hgrp_ID = queryObject.Hgrp_id.ToString();
            returnDetails.Email_Saga = queryObject.Email_Saga;
            returnDetails.Encrypted_Email_Saga = queryObject.Encrypted_Email_Saga;
            returnDetails.Title = queryObject.Title;
            returnDetails.FirstName = queryObject.firstName;
            returnDetails.LastName = queryObject.lastName;
            returnDetails.Salutation_Detail = queryObject.Salutation_Detail;
            returnDetails.Salutation_Envelope = queryObject.Salutation_Envelope;

            return Ok(returnDetails);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ExtractCPRecipientExists(long id)
        {
            return db.ExtractCPRecipients.Count(e => e.Pers_id == id) > 0;
        }
    }
}