using GatewayDTO.ResponseModel.EntityResponse;

namespace GatewayDTO.ResponseModel;

public record class ConditionResponse : BaseEntityResponse
{
    public string Name { get; set; } = string.Empty;
    public string IpAddress { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public DateTime DateWork { get; set; }
}
