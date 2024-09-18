using GatewayDTO.Abstract.EntityRequest;
using System.ComponentModel.DataAnnotations;

namespace GatewayDTO.User;

public class UserReuestForToken: BaseEntityRequest
{
    [Required(AllowEmptyStrings = false,ErrorMessage = "Please provide Login")]
    public string? login { get; set; }
    
    [Required(AllowEmptyStrings = false ,ErrorMessage = "Please provide Password")]
    public string? password { get; set; }
}