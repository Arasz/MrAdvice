﻿#region Mr. Advice

// Mr. Advice
// A simple post build weaving package
// http://mradvice.arxone.com/
// Released under MIT license http://opensource.org/licenses/mit-license.php

#endregion

namespace ArxOne.MrAdvice.Threading
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Extensions to Tasks
    /// </summary>
    public static class TaskExtensions
    {
        /// <summary>
        /// Gets the type of the task.
        /// </summary>
        /// <param name="task">The task.</param>
        /// <returns></returns>
        public static Type GetTaskType(this Task task) => GetTaskType(task.GetType());

        /// <summary>
        /// Gets the type of the task.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static Type GetTaskType(this Type type)
        {
            if (!type.IsGenericType)
                return null;
            var arguments = type.GetGenericArguments();
            if (arguments.Length != 1)
                return null;
            return arguments[0];
        }

        /// <summary>
        /// Gets the result, as an object.
        /// </summary>
        /// <param name="task">The task.</param>
        /// <returns></returns>
        public static object GetResult(this Task task)
        {
            var resultProperty = task.GetType().GetProperty("Result");
            return resultProperty.GetValue(task, new object[0]);
        }
    }
}