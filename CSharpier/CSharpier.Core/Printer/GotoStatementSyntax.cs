using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier.Core
{
    public partial class Printer
    {
        private Doc PrintGotoStatementSyntax(GotoStatementSyntax node)
        {
            var expression = node.Expression != null ? Concat(" ", this.Print(node.Expression)) : "";
            return Concat(
                    this.PrintExtraNewLines(node),
                this.PrintSyntaxToken(node.GotoKeyword),
                node.CaseOrDefaultKeyword.RawKind != 0 ? SpaceIfNoPreviousComment : null,
                this.PrintSyntaxToken(node.CaseOrDefaultKeyword),
                expression,
                this.PrintSyntaxToken(node.SemicolonToken));
        }
    }
}
