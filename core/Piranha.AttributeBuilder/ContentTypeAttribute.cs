﻿/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using System;

namespace Piranha.AttributeBuilder
{
    /// <summary>
    /// Attribute for marking a class as a content type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ContentTypeAttribute : ContentTypeBaseAttribute
    {
        /// <summary>
        /// Gets/sets the group name of the content type.
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Gets/sets if the content type should be categorized.
        /// </summary>
        public bool UseCategory { get; set; } = false;

        /// <summary>
        /// Gets/sets if excerpt should be used for the
        /// content type. The default value is true.
        /// </summary>
        public bool UseExcerpt { get; set; } = true;

        /// <summary>
        /// Gets/sets if primary image should be used for the
        /// content type. The default value is true.
        /// </summary>
        public bool UsePrimaryImage { get; set; } = true;

        /// <summary>
        /// Gets/sets if the content type should be tagged.
        /// </summary>
        public bool UseTags { get; set; } = false;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ContentTypeAttribute() : base() { }
    }
}
