/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/tidyui/coreweb
 *
 */

using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;

namespace RazorWeb.Models
{
    /// <summary>
    /// Basic product.
    /// </summary>
    [ContentType(Title = "Standard Product", UseCategory = true)]
    public class StandardProduct : Content<StandardProduct>
    {
    }
}
