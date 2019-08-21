using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HgWorkflow.Models
{
    public class WorkOrder
    {
        [Key]
        public int Id { get; set; }

        public string WorkOrderId { get; set; }


        public string GoldSmithName { get; set; }

        [Required(ErrorMessage = "Kund namn")]
        [Display(Name = "Customer Name :")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Kund telefonenummer")]
        [Display(Name = "Contact Number :")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Phone number")]
        public string CustomerMobileNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }

        public string JewelleryDescription1 { get; set; }

        public string JewelleryDescription2 { get; set; }

        public string JewelleryDescription3 { get; set; }

        public string WorkToBeDone { get; set; }

        public string WorkToBeDone2 { get; set; }

        public string WorkToBeDone3 { get; set; }

        public string AgentName { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Föremål Datum")]
        public DateTime ProductGivenOn { get; set; }


        //[Required(ErrorMessage = "Date proposed required")]
        //[Display(Name = "Date Proposed :")]

        //public DateTime DateProposed { get; set; }


        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateAcceptedOrRejected { get; set; }

        public AcceptedRejectedStatus sAcceptedRejectedStatus { get; set; }

        // [Display(Name = "To be returned on :")]
        //public DateTime? ProductToBeReturnedOn { get; set; }

        public int? AmountToBeCollected { get; set; }

        //[Display(Name = "Estimate :")]

        //public int AmountEstimate { get; set; }

        public string Status { get; set; }

        public string Comments { get; set; }
    }

    public enum AcceptedRejectedStatus
        {
        Accepterat,
        Ejaccepterat,
        Vänteläge

    }
}