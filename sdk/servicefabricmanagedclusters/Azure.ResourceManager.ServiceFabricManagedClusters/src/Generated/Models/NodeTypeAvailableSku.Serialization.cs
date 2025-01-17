// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class NodeTypeAvailableSku
    {
        internal static NodeTypeAvailableSku DeserializeNodeTypeAvailableSku(JsonElement element)
        {
            Optional<string> resourceType = default;
            Optional<NodeTypeSupportedSku> sku = default;
            Optional<NodeTypeSkuCapacity> capacity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = NodeTypeSupportedSku.DeserializeNodeTypeSupportedSku(property.Value);
                    continue;
                }
                if (property.NameEquals("capacity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capacity = NodeTypeSkuCapacity.DeserializeNodeTypeSkuCapacity(property.Value);
                    continue;
                }
            }
            return new NodeTypeAvailableSku(resourceType.Value, sku.Value, capacity.Value);
        }
    }
}
