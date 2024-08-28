using System.Collections.Generic;

namespace SwinAdventure
{
    public interface FullInventory
    {
        GameObject Locate(string id);
        string Name { get; }
    }
}
