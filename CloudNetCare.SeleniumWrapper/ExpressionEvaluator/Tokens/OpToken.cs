namespace CloudNetCare.SeleniumWrapper.ExpressionEvaluator.Tokens
{
    internal class OpToken : Token
    {
        public OpToken()
        {
            IsOperator = true;
            ArgCount = 0;
        }

    }
}