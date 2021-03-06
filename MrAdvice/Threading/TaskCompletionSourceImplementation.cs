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

    internal class TaskCompletionSourceImplementation<TResult> : TaskCompletionSource
    {
        private readonly System.Threading.Tasks.TaskCompletionSource<TResult> _source;

        public override Task Task => _source.Task;

        /// <summary>
        ///     Sets the result.
        /// </summary>
        /// <param name="result">The result.</param>
        public override void SetResult(object result)
        {
            _source.SetResult((TResult) result);
        }

        /// <summary>
        ///     Sets the exception.
        /// </summary>
        /// <param name="e">The e.</param>
        public override void SetException(Exception e)
        {
            _source.SetException(e);
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="TaskCompletionSource" /> class.
        /// </summary>
        public TaskCompletionSourceImplementation()
        {
            _source = new TaskCompletionSource<TResult>();
        }
    }
}