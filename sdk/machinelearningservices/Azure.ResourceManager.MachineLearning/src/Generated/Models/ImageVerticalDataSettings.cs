// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Collection of registered Tabular Dataset Ids and other data settings required for training and validating models. </summary>
    public partial class ImageVerticalDataSettings : DataSettings
    {
        /// <summary> Initializes a new instance of ImageVerticalDataSettings. </summary>
        /// <param name="targetColumnName">
        /// [Required] Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </param>
        /// <param name="trainingDataSettings"> [Required] Training data input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetColumnName"/> or <paramref name="trainingDataSettings"/> is null. </exception>
        public ImageVerticalDataSettings(string targetColumnName, TrainingDataSettings trainingDataSettings) : base(targetColumnName, trainingDataSettings)
        {
            if (targetColumnName == null)
            {
                throw new ArgumentNullException(nameof(targetColumnName));
            }
            if (trainingDataSettings == null)
            {
                throw new ArgumentNullException(nameof(trainingDataSettings));
            }
        }

        /// <summary> Initializes a new instance of ImageVerticalDataSettings. </summary>
        /// <param name="targetColumnName">
        /// [Required] Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </param>
        /// <param name="testData"> Test data input. </param>
        /// <param name="trainingDataSettings"> [Required] Training data input. </param>
        /// <param name="validationData"> Settings for the validation dataset. </param>
        internal ImageVerticalDataSettings(string targetColumnName, TestDataSettings testData, TrainingDataSettings trainingDataSettings, ImageVerticalValidationDataSettings validationData) : base(targetColumnName, testData, trainingDataSettings)
        {
            ValidationData = validationData;
        }

        /// <summary> Settings for the validation dataset. </summary>
        public ImageVerticalValidationDataSettings ValidationData { get; set; }
    }
}
