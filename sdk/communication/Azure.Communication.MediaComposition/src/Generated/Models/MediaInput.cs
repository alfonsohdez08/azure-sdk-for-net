// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Communication.MediaComposition;

namespace Azure.Communication.MediaComposition.Models
{
    /// <summary> Media input to be used in the composition. </summary>
    public partial class MediaInput
    {

        /// <summary> Initializes a new instance of MediaInput. </summary>
        /// <param name="kind"> Kind of media input. </param>
        /// <param name="placeholderImageUri"> Image url to be used if participant has no video stream. </param>
        internal MediaInput(MediaInputType kind, string placeholderImageUri)
        {
            Kind = kind;
            PlaceholderImageUri = placeholderImageUri;
        }

        /// <summary> Kind of media input. </summary>
        internal MediaInputType Kind { get; set; }
        /// <summary> Image url to be used if participant has no video stream. </summary>
        public string PlaceholderImageUri { get; set; }
    }
}
