using PackIT.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Policies.Gender
{
    public class FemaleGenderPolicy : IPackingItemsPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
                => new List<PackingItem>
                {
                    new("Lipstick", 1),
                    new("Powder", 1),
                    new("Eyeliner", 1)
                };

        public bool IsApplicable(PolicyData data)
            => data.Gender is Consts.Gender.Female;
    }
}
