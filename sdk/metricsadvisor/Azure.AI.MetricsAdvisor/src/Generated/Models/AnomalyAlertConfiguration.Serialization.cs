// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class AnomalyAlertConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ConditionOperator))
            {
                writer.WritePropertyName("crossMetricsOperator");
                writer.WriteStringValue(ConditionOperator.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SplitAlertByDimensions))
            {
                writer.WritePropertyName("splitAlertByDimensions");
                writer.WriteStartArray();
                foreach (var item in SplitAlertByDimensions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("hookIds");
            writer.WriteStartArray();
            foreach (var item in IdsOfHooksToAlert)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("metricAlertingConfigurations");
            writer.WriteStartArray();
            foreach (var item in MetricAlertConfigurations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static AnomalyAlertConfiguration DeserializeAnomalyAlertConfiguration(JsonElement element)
        {
            Optional<string> anomalyAlertingConfigurationId = default;
            string name = default;
            Optional<string> description = default;
            Optional<DetectionConditionOperator> crossMetricsOperator = default;
            Optional<IList<string>> splitAlertByDimensions = default;
            IList<string> hookIds = default;
            IList<MetricAlertConfiguration> metricAlertingConfigurations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("anomalyAlertingConfigurationId"))
                {
                    anomalyAlertingConfigurationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("crossMetricsOperator"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    crossMetricsOperator = new DetectionConditionOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("splitAlertByDimensions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    splitAlertByDimensions = array;
                    continue;
                }
                if (property.NameEquals("hookIds"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    hookIds = array;
                    continue;
                }
                if (property.NameEquals("metricAlertingConfigurations"))
                {
                    List<MetricAlertConfiguration> array = new List<MetricAlertConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricAlertConfiguration.DeserializeMetricAlertConfiguration(item));
                    }
                    metricAlertingConfigurations = array;
                    continue;
                }
            }
            return new AnomalyAlertConfiguration(anomalyAlertingConfigurationId.Value, name, description.Value, Optional.ToNullable(crossMetricsOperator), Optional.ToList(splitAlertByDimensions), hookIds, metricAlertingConfigurations);
        }
    }
}
