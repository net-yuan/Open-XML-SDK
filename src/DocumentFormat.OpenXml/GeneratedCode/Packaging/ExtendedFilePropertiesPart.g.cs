﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the ExtendedFilePropertiesPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType("application/vnd.openxmlformats-officedocument.extended-properties+xml")]
    public partial class ExtendedFilePropertiesPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.extended-properties+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties";
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
        private static Dictionary<string, PartConstraintRule> _partConstraint;

        /// <summary>
        /// Creates an instance of the ExtendedFilePropertiesPart OpenXmlType
        /// </summary>
        internal protected ExtendedFilePropertiesPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "app";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "docProps";

        /// <inheritdoc/>
        internal sealed override IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
        {
            if (_dataPartReferenceConstraint is null)
            {
                _dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal) { };
            }

            return _dataPartReferenceConstraint;
        }

        /// <inheritdoc/>
        internal sealed override IDictionary<string, PartConstraintRule> GetPartConstraint()
        {
            if (_partConstraint is null)
            {
                _partConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal) { };
            }

            return _partConstraint;
        }
    }
}