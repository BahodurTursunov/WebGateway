using GatewayDTO.ResponseModel;

namespace GatewayDTO;

public class GatewayNames: BaseEntityRequest
{
    public int Id { get; set; }

    public int? IdGateway { get; set; }

    public string? Name { get; set; }

    public int? Status { get; set; }
}