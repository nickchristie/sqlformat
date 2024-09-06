using Laan.Sql.Parser;
using Laan.Sql.Parser.Expressions;
using System.Text;

namespace Laan.Sql.Formatter
{
    public class VariableAssignmentFormatter : BaseFormatter
    {
        private string _identifier;
        private Expression _assignment;

        public VariableAssignmentFormatter(string identifier, Expression assignment, IIndentable indentable, StringBuilder sql) : base(indentable, sql)
        {
            _identifier = identifier;
            _assignment = assignment;
        }

        public void Execute()
        {
            var assignmentValue = _assignment.FormattedValue(0, this);
            var variableAssignment = $"{Constants.Set} {_identifier} = {assignmentValue};";

            IndentAppend(variableAssignment);
        }
    }
}
