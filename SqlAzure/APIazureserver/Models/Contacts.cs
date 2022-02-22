using System.ComponentModel.DataAnnotations;

namespace APIazureserver.Models

{
    public class Contacts
    {
        [Key]
        public string Identificador{
            get;
            set;
        }
        public string dni{
            get;
            set;
        }
        public string FirtsName{
            get;
            set;
        }
        public string LastName{
            get;
            set;
        }
        public string Name{
            get;
            set;
        }
        public string Email{
            get;
            set;
        }
    }
}