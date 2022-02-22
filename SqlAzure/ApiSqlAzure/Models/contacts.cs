namespace ApiSqlAzure.Models;
using System.ComponentModel.DataAnnotations;

    public class contacts
    {
        [Key]
        public string Identificador{get;set;}
        public string Nombre {get;set;}
        public string Email{get; set;}
        public string Telefono{get;set;}
    }
