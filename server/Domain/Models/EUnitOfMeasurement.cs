using System.ComponentModel;

namespace Supermarket.API.Domain.Models
{
    public enum EUnitOfMeasurement : byte
    {
        [Description("UN")]
        unity = 1,
        [Description("MG")]
        miligram = 2,
        [Description("KG")]
        kilogram = 4
    }

}