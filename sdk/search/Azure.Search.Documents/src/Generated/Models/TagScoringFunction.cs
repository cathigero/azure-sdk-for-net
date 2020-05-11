// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Models
{
    /// <summary> Defines a function that boosts scores of documents with string values matching a given list of tags. </summary>
    public partial class TagScoringFunction : ScoringFunction
    {

        /// <summary> Initializes a new instance of TagScoringFunction. </summary>
        /// <param name="type"> Indicates the type of function to use. Valid values include magnitude, freshness, distance, and tag. The function type must be lower case. </param>
        /// <param name="fieldName"> The name of the field used as input to the scoring function. </param>
        /// <param name="boost"> A multiplier for the raw score. Must be a positive number not equal to 1.0. </param>
        /// <param name="interpolation"> A value indicating how boosting will be interpolated across document scores; defaults to &quot;Linear&quot;. </param>
        /// <param name="parameters"> Parameter values for the tag scoring function. </param>
        internal TagScoringFunction(string type, string fieldName, double boost, ScoringFunctionInterpolation? interpolation, TagScoringParameters parameters) : base(type, fieldName, boost, interpolation)
        {
            Parameters = parameters;
            Type = type ?? "tag";
        }

        /// <summary> Parameter values for the tag scoring function. </summary>
        public TagScoringParameters Parameters { get; set; }
    }
}