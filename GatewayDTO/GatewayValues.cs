using GatewayDTO.ResponseModel;

namespace GatewayDTO;

public class GatewayValues: BaseEntityRequest
{  public int Id { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public int? IdGateway { get; set; }
}