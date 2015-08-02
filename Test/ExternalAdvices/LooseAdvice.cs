#region Mr. Advice
// Mr. Advice
// A simple post build weaving package
// http://mradvice.arxone.com/
// Released under MIT license http://opensource.org/licenses/mit-license.php
#endregion

namespace ExternalAdvices
{
    using System;
    using ArxOne.MrAdvice.Advice.Context;

    public class LooseAdvice: Attribute
    {
        public void AdviseMethod(MethodAdviceContext context)
        {
            context.Proceed();
        }

        public void AdviceProperty(PropertyAdviceContext context)
        {
            context.Proceed();
        }
    }
}
