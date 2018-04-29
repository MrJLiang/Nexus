using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Aiursoft.Pylon.Models.API.UserAddressModels
{
    public class BindNewEmailAddressModel : WithAccessTokenAddressModel
    {
        [Required]
        public string OpenId { get; set; }
        [Required]
        [MaxLength(30)]
        [EmailAddress]
        public string NewEmail { get; set; }
    }
}
