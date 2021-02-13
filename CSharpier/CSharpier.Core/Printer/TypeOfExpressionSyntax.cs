using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier.Core
{
    public partial class Printer
    {
        private Doc PrintTypeOfExpressionSyntax(TypeOfExpressionSyntax node)
        {
            return Concat(
                this.PrintSyntaxToken(node.Keyword),
                this.PrintSyntaxToken(node.OpenParenToken),
                this.Print(node.Type),
                this.PrintSyntaxToken(node.CloseParenToken));
        }
    }
}
