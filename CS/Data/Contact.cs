using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAnnotationAttributes.Model {
    public class Contact {
        [ReadOnly(true)]
        [Display(AutoGenerateField = false)]
        public int Id { get; set; }

        [Display(GroupName = "General Info", AutoGenerateField = false)]
        public Gender Gender { get; set; }

        [Display(GroupName = "General Info")]
        [Required]
        [MaxLength(25, ErrorMessage = "Value is too long")]
        public string FirstName { get; set; }

        [Display(GroupName = "General Info")]
        [Required]
        public string LastName { get; set; }

        [Display(GroupName = "General Info")]
        [DisplayFormat(NullDisplayText = "<empty>")]
        [CreditCard]
        public string CreditCardNumber { get; set; }

        [Display(GroupName = "Contacts")]
        [DisplayFormat(NullDisplayText = "<empty>")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(GroupName = "Contacts")]
        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(NullDisplayText = "<empty>")]
        public string Phone { get; set; }

        [Display(GroupName = "Address")]
        [DisplayFormat(NullDisplayText = "<empty>")]
        public string Address { get; set; }

        [Display(GroupName = "Address")]
        [DisplayFormat(NullDisplayText = "<empty>")]
        [RegExMaskAttribute(Mask = @"\w{1,25}", UseAsDisplayFormat = true, ShowPlaceHolders = false)]
        public string City { get; set; }

        [Display(GroupName = "Address")]
        [DisplayFormat(NullDisplayText = "<empty>")]
        [CustomValidation(typeof(ContactValidator), "ValidateString")]
        public string State { get; set; }

        [Display(GroupName = "Address")]
        [DisplayFormat(NullDisplayText = "<empty>")]
        public string Zip { get; set; }

        [Display(AutoGenerateField = false)]
        [DisplayFormat(NullDisplayText = "<empty>")]
        public byte[] Photo { get; set; }

        public Contact() { }
        public Contact(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}