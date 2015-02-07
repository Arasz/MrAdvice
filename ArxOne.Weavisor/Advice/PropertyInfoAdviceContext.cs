﻿#region Weavisor
// Weavisor
// A simple post build weaving package
// https://github.com/ArxOne/Weavisor
// Released under MIT license http://opensource.org/licenses/mit-license.php
#endregion

namespace ArxOne.Weavisor.Advice
{
    using System.Reflection;

    /// <summary>
    /// Info context for MethodBase
    /// </summary>
    public class PropertyInfoAdviceContext : AdviceInfoContext
    {
        /// <summary>
        /// Gets the target method.
        /// </summary>
        /// <value>
        /// The target method.
        /// </value>
        public PropertyInfo TargetProperty { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyInfoAdviceContext"/> class.
        /// </summary>
        /// <param name="targetProperty">The target property.</param>
        internal PropertyInfoAdviceContext(PropertyInfo targetProperty)
        {
            TargetProperty = targetProperty;
        }
    }
}