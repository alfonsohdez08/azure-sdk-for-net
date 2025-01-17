// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.StorageSync;

namespace Azure.ResourceManager.StorageSync.Models
{
    internal partial class SyncGroupArray
    {
        internal static SyncGroupArray DeserializeSyncGroupArray(JsonElement element)
        {
            Optional<IReadOnlyList<SyncGroupData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SyncGroupData> array = new List<SyncGroupData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncGroupData.DeserializeSyncGroupData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SyncGroupArray(Optional.ToList(value));
        }
    }
}
